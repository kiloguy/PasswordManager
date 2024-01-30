namespace PasswordManager
{
    public partial class EntryForm : Form
    {
        public enum Mode
        {
            Add, Edit
        }

        private MainForm mainForm;
        private Mode mode;
        private int editIndex;

        public EntryForm(MainForm mainForm, Mode mode, int editIndex = 0, Entry? entry = null)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(
                mainForm.Location.X + mainForm.Width / 2 - Width / 2,
                mainForm.Location.Y + mainForm.Height / 2 - Height / 2
            );
            this.mainForm = mainForm;
            this.mode = mode;
            this.editIndex = editIndex;
            mainForm.Enabled = false;

            switch (mode)
            {
                case Mode.Add:
                    Text = "Add New Entry";
                    break;
                case Mode.Edit:
                    Text = "Edit Entry";
                    serviceTextBox.Text = entry.service;
                    usernameTextBox.Text = entry.username;
                    passwordTextBox.Text = mainForm.decrypt(entry.encryptedPassword);
                    verifyPasswordTextBox.Text = passwordTextBox.Text;
                    noteTextBox.Text = entry.note;
                    setOKButtonEnabled(null, null);
                    break;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case Mode.Add:
                    mainForm.addEntry(serviceTextBox.Text, usernameTextBox.Text, passwordTextBox.Text, noteTextBox.Text);
                    break;
                case Mode.Edit:
                    mainForm.editEntry(editIndex, serviceTextBox.Text, usernameTextBox.Text, passwordTextBox.Text, noteTextBox.Text);
                    break;
            }

            Close();
        }

        private void EntryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void setOKButtonEnabled(object? sender, EventArgs? e)
        {
            okButton.Enabled = serviceTextBox.Text.Length * usernameTextBox.Text.Length * passwordTextBox.Text.Length > 0 && passwordTextBox.Text == verifyPasswordTextBox.Text;
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {
            BringToFront();
            Activate();
        }

        private void EntryForm_Shown(object sender, EventArgs e)
        {
            Focus();
            ActiveControl = null;
        }

        private void toggleButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.PasswordChar == '*')
                passwordTextBox.PasswordChar = verifyPasswordTextBox.PasswordChar = '\0';
            else
                passwordTextBox.PasswordChar = verifyPasswordTextBox.PasswordChar = '*';
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = verifyPasswordTextBox.Text = MainForm.createRandomString(16);
        }
    }
}
