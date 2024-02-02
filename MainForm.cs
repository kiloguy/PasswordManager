using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace PasswordManager
{
    public partial class MainForm : Form
    {
        private ICryptoTransform? encryptor;
        private ICryptoTransform? decryptor;
        private SHA256 sha256 = SHA256.Create();
        private PMData? pmdata;
        private string pmdataPath = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".pmdata");
        private bool clipboardContainsPassword = false;
        private string clipboardOriginalText = "";
        private List<bool> toggles = new();

        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(pmdataPath))
                new MasterPasswordForm(this, MasterPasswordForm.Mode.Validate).Show(this);
            else
                new MasterPasswordForm(this, MasterPasswordForm.Mode.Create).Show(this);
        }

        public byte[] encrypt(string password)
        {
            byte[] passwordBytes = UnicodeEncoding.Unicode.GetBytes(password);

            return encryptor.TransformFinalBlock(passwordBytes, 0, passwordBytes.Length);
        }

        public string decrypt(byte[] encryptedPassword)
        {
            byte[] passwordBytes = decryptor.TransformFinalBlock(encryptedPassword, 0, encryptedPassword.Length);

            return UnicodeEncoding.Unicode.GetString(passwordBytes);
        }

        public byte[] hash(string masterPassword, string salt)
        {
            return sha256.ComputeHash(UnicodeEncoding.Unicode.GetBytes(masterPassword + salt));
        }

        private void addEntryButton_Click(object sender, EventArgs e)
        {
            new EntryForm(this, EntryForm.Mode.Add).Show();
        }

        public void addEntry(string service, string username, string password, string note)
        {
            Entry entry = new Entry(service, username, encrypt(password), note);

            pmdata.entries.Add(entry);
            listViewAppend(entry);
            saveButton.Enabled = true;
        }

        public void editEntry(int editIndex, string service, string username, string password, string note)
        {
            Entry entry = new Entry(service, username, encrypt(password), note);

            pmdata.entries[editIndex] = entry;
            entriesListView.Items[editIndex].SubItems[0].Text = entry.service;
            entriesListView.Items[editIndex].SubItems[1].Text = entry.username;
            entriesListView.Items[editIndex].SubItems[2].Text = toggles[editIndex] ? password : "*****";
            entriesListView.Items[editIndex].SubItems[3].Text = entry.note;
            saveButton.Enabled = true;
        }

        private void createAes(string masterPassword)
        {
            Aes aes = Aes.Create();
            byte[] IV = new byte[16];
            byte[] key = new byte[32];

            aes.BlockSize = 128;
            aes.KeySize = 256;
            UnicodeEncoding.Unicode.GetBytes(masterPassword, 0, masterPassword.Length, key, 0);
            encryptor = aes.CreateEncryptor(key, IV);
            decryptor = aes.CreateDecryptor(key, IV);
        }

        public static string createRandomString(int length)
        {
            string s = "";
            string charset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_";

            for (int i = 0; i < length; i++)
                s += charset[RandomNumberGenerator.GetInt32(charset.Length)];

            return s;
        }

        public void createPMData(string masterPassword)
        {
            string salt = createRandomString(8);

            pmdata = new PMData(hash(masterPassword, salt), salt);
            createAes(masterPassword);
            saveButton.Enabled = true;
        }

        public bool loadPMData(string masterPassword)
        {
            try
            {
                pmdata = JsonSerializer.Deserialize<PMData>(File.ReadAllText(pmdataPath));
            }
            catch
            {
                MessageBox.Show($"Failed to read {pmdataPath}, the file may be damaged.", "Error");
                Close();
                return false;
            }

            if (!hash(masterPassword, pmdata.salt).SequenceEqual(pmdata.hashedMasterPassword))
            {
                MessageBox.Show("Wrong password.", "Error");
                return false;
            }

            foreach (Entry entry in pmdata.entries)
                listViewAppend(entry);

            createAes(masterPassword);
            return true;
        }

        public bool resetMasterPassword(string originalMasterPassword, string newMasterPassword)
        {
            if (!hash(originalMasterPassword, pmdata.salt).SequenceEqual(pmdata.hashedMasterPassword))
            {
                MessageBox.Show("Wrong original master password.", "Error");
                return false;
            }
            // re-encrypt all password
            List<string> passwords = new();

            foreach (Entry entry in pmdata.entries)
                passwords.Add(decrypt(entry.encryptedPassword));

            pmdata.hashedMasterPassword = hash(newMasterPassword, pmdata.salt);
            createAes(newMasterPassword);

            for (int i = 0; i < pmdata.entries.Count; i++)
                editEntry(i, pmdata.entries[i].service, pmdata.entries[i].username, passwords[i], pmdata.entries[i].note);

            saveButton.Enabled = true;
            return true;
        }

        private void listViewAppend(Entry entry)
        {
            ListViewItem item = new ListViewItem(entry.service);

            item.SubItems.Add(entry.username);
            item.SubItems.Add("*****");
            item.SubItems.Add(entry.note);
            entriesListView.Items.Add(item);
            toggles.Add(false);
        }

        private void entriesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool selected = entriesListView.SelectedIndices.Count > 0;

            editButton.Enabled = deleteButton.Enabled = toggleButton.Enabled = copyButton.Enabled = selected;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int editIndex = entriesListView.SelectedIndices[0];
            new EntryForm(this, EntryForm.Mode.Edit, editIndex, pmdata.entries[editIndex]).Show();
        }

        private void saveButton_Click(object? sender, EventArgs? e)
        {
            File.WriteAllText(pmdataPath, JsonSerializer.Serialize(pmdata));
            saveButton.Enabled = false;
        }

        private void resetMasterPasswordButton_Click(object sender, EventArgs e)
        {
            new MasterPasswordForm(this, MasterPasswordForm.Mode.Reset).Show();
        }

        private void copyPassword(object sender, EventArgs e)
        {
            if (entriesListView.SelectedIndices.Count > 0)
            {
                if (!clipboardContainsPassword)
                    clipboardOriginalText = Clipboard.GetText();

                Clipboard.SetText(decrypt(pmdata.entries[entriesListView.SelectedIndices[0]].encryptedPassword));
                clipboardContainsPassword = true;
                clipboardTimer.Stop();
                clipboardTimer.Start();
                hintStatusLabel.Text = "Password copied. Clipboard restore after 15 seconds.";
            }
        }

        private void clipboardTimer_Tick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(clipboardOriginalText)) // Clipboard.SetText("") throws exception
                Clipboard.Clear();
            else
                Clipboard.SetText(clipboardOriginalText);

            clipboardContainsPassword = false;
            clipboardTimer.Stop();
            hintStatusLabel.Text = "Clipboard restored.";
        }

        private void toggleButton_MouseEnter(object sender, EventArgs e)
        {
            if (!clipboardContainsPassword)
                hintStatusLabel.Text = "Show/hide password";
        }

        private void copyButton_MouseEnter(object sender, EventArgs e)
        {
            if (!clipboardContainsPassword)
                hintStatusLabel.Text = "Copy password to clipboard (or double-click)";
        }

        private void clearHintStatusLabel(object sender, EventArgs e)
        {
            if (!clipboardContainsPassword)
                hintStatusLabel.Text = "";
        }

        private void toggleButton_Click(object sender, EventArgs e)
        {
            int index = entriesListView.SelectedIndices[0];

            if (toggles[index])
                entriesListView.Items[index].SubItems[2].Text = "*****";
            else
                entriesListView.Items[index].SubItems[2].Text = decrypt(pmdata.entries[index].encryptedPassword);

            toggles[index] = !toggles[index];
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
                saveButton_Click(null, null);
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            new AboutForm(this).Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = entriesListView.SelectedIndices[0];

            DialogResult result = MessageBox.Show(
                $"Delete entry {index} ({pmdata.entries[index].service}, {pmdata.entries[index].username}). Are you sure?",
                "Delete Entry",
                MessageBoxButtons.OKCancel
            );

            if (result == DialogResult.OK)
            {
                pmdata.entries.RemoveAt(index);
                toggles.RemoveAt(index);
                entriesListView.Items.RemoveAt(index);
                saveButton.Enabled = true;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (saveButton.Enabled)
            {
                DialogResult result = MessageBox.Show(
                    "Some changes have not been saved. Save before closing?",
                    "Save Changes",
                    MessageBoxButtons.YesNoCancel
                );

                if (result == DialogResult.Yes)
                    saveButton_Click(null, null);
                else if (result == DialogResult.No)
                    return;
                else
                    e.Cancel = true;
            }
        }
    }
}