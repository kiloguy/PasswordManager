namespace PasswordManager
{
    public partial class AboutForm : Form
    {
        private MainForm mainForm;

        public AboutForm(MainForm mainForm)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(
                mainForm.Location.X + mainForm.Width / 2 - Width / 2,
                mainForm.Location.Y + mainForm.Height / 2 - Height / 2
            );
            this.mainForm = mainForm;
            mainForm.Enabled = false;
            string build = Properties.Resources.build;

            aboutRichTextBox.Text = $"Password Manager by kilo\r\nBuild {build}\r\nRepository: https://github.com/kiloguy/PasswordManager\r\n";
        }

        private void AboutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }
    }
}
