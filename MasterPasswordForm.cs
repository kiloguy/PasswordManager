namespace PasswordManager
{
    public partial class MasterPasswordForm : Form
    {
        public enum Mode
        {
            Create, Validate, Reset
        }

        private MainForm mainForm;
        private Mode mode;
        private bool closeByOK = false;
        private bool mainFrameCloseCalled = false;

        public MasterPasswordForm(MainForm mainForm, Mode mode)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(
                mainForm.Location.X + mainForm.Width / 2 - Width / 2,
                mainForm.Location.Y + mainForm.Height / 2 - Height / 2
            );
            this.mainForm = mainForm;
            this.mode = mode;
            mainForm.Enabled = false;

            switch (mode)
            {
                case Mode.Create:
                    verifyMasterPasswordTextBox.Visible = true;
                    verifyMasterPasswordLabel.Visible = true;
                    Text = "Create Master Password";
                    break;
                case Mode.Validate:
                    Text = "Enter Master Password";
                    break;
                case Mode.Reset:
                    verifyMasterPasswordTextBox.Visible = true;
                    verifyMasterPasswordTextBox.PlaceholderText = "Enter the new master password again";
                    verifyMasterPasswordLabel.Visible = true;
                    originalMasterPasswordTextBox.Visible = true;
                    originalMasterPasswordLabel.Visible = true;
                    masterPasswordTextBox.PlaceholderText = "New master password";
                    masterPasswordLabel.Text = "New Master Password";
                    Text = "Reset Master Password";
                    break;
            }
        }

        private void setOKButtonEnabled(object sender, EventArgs e)
        {
            switch (mode)
            {
                case Mode.Create:
                    okButton.Enabled = masterPasswordTextBox.Text.Length > 0 && masterPasswordTextBox.Text == verifyMasterPasswordTextBox.Text;
                    break;
                case Mode.Reset:
                    okButton.Enabled = originalMasterPasswordTextBox.Text.Length * masterPasswordTextBox.Text.Length > 0 && masterPasswordTextBox.Text == verifyMasterPasswordTextBox.Text;
                    break;
                case Mode.Validate:
                    okButton.Enabled = masterPasswordTextBox.Text.Length > 0;
                    break;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case Mode.Create:
                    mainForm.createPMData(masterPasswordTextBox.Text);
                    mainForm.Enabled = true;
                    closeByOK = true;
                    Close();
                    break;
                case Mode.Validate:
                    if (mainForm.loadPMData(masterPasswordTextBox.Text))
                    {
                        closeByOK = true;
                        mainForm.Enabled = true;
                        Close();
                    }
                    break;
                case Mode.Reset:
                    if (mainForm.resetMasterPassword(originalMasterPasswordTextBox.Text, masterPasswordTextBox.Text))
                    {
                        closeByOK = true;
                        mainForm.Enabled = true;
                        Close();
                    }
                    break;
            }
        }

        private void MasterPasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!closeByOK && (mode == Mode.Create || mode == Mode.Validate)) // Exit the program
            {
                // Prevent infinite loop,
                // since calling mainForm.Close() seems to cause the FormClosed event of all other forms.
                if (!mainFrameCloseCalled)
                {
                    mainFrameCloseCalled = true;
                    mainForm.Close();
                }
            }
            else
                mainForm.Enabled = true;
        }

        private void MasterPasswordForm_Shown(object sender, EventArgs e)
        {
            Focus();

            if (mode == Mode.Reset)
                ActiveControl = originalMasterPasswordTextBox;
            else
                ActiveControl = masterPasswordTextBox;
        }
    }
}
