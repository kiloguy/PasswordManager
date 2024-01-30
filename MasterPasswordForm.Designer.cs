namespace PasswordManager
{
    partial class MasterPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterPasswordForm));
            masterPasswordTextBox = new TextBox();
            masterPasswordLabel = new Label();
            okButton = new Button();
            verifyMasterPasswordTextBox = new TextBox();
            verifyMasterPasswordLabel = new Label();
            originalMasterPasswordTextBox = new TextBox();
            originalMasterPasswordLabel = new Label();
            SuspendLayout();
            // 
            // masterPasswordTextBox
            // 
            masterPasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            masterPasswordTextBox.Location = new Point(194, 45);
            masterPasswordTextBox.Name = "masterPasswordTextBox";
            masterPasswordTextBox.PasswordChar = '*';
            masterPasswordTextBox.PlaceholderText = "Master password";
            masterPasswordTextBox.Size = new Size(288, 27);
            masterPasswordTextBox.TabIndex = 1;
            masterPasswordTextBox.TextChanged += setOKButtonEnabled;
            // 
            // masterPasswordLabel
            // 
            masterPasswordLabel.Location = new Point(12, 46);
            masterPasswordLabel.Name = "masterPasswordLabel";
            masterPasswordLabel.Size = new Size(176, 25);
            masterPasswordLabel.TabIndex = 1;
            masterPasswordLabel.Text = "Master Password";
            masterPasswordLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okButton.Enabled = false;
            okButton.Location = new Point(414, 113);
            okButton.Name = "okButton";
            okButton.Size = new Size(68, 31);
            okButton.TabIndex = 2;
            okButton.TabStop = false;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // verifyMasterPasswordTextBox
            // 
            verifyMasterPasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            verifyMasterPasswordTextBox.Location = new Point(194, 78);
            verifyMasterPasswordTextBox.Name = "verifyMasterPasswordTextBox";
            verifyMasterPasswordTextBox.PasswordChar = '*';
            verifyMasterPasswordTextBox.PlaceholderText = "Enter the master password again";
            verifyMasterPasswordTextBox.Size = new Size(288, 27);
            verifyMasterPasswordTextBox.TabIndex = 2;
            verifyMasterPasswordTextBox.Visible = false;
            verifyMasterPasswordTextBox.TextChanged += setOKButtonEnabled;
            // 
            // verifyMasterPasswordLabel
            // 
            verifyMasterPasswordLabel.AutoSize = true;
            verifyMasterPasswordLabel.Location = new Point(28, 81);
            verifyMasterPasswordLabel.Name = "verifyMasterPasswordLabel";
            verifyMasterPasswordLabel.Size = new Size(160, 20);
            verifyMasterPasswordLabel.TabIndex = 4;
            verifyMasterPasswordLabel.Text = "Verify Master Password";
            verifyMasterPasswordLabel.Visible = false;
            // 
            // originalMasterPasswordTextBox
            // 
            originalMasterPasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            originalMasterPasswordTextBox.Location = new Point(194, 12);
            originalMasterPasswordTextBox.Name = "originalMasterPasswordTextBox";
            originalMasterPasswordTextBox.PasswordChar = '*';
            originalMasterPasswordTextBox.PlaceholderText = "Original master password";
            originalMasterPasswordTextBox.Size = new Size(288, 27);
            originalMasterPasswordTextBox.TabIndex = 0;
            originalMasterPasswordTextBox.Visible = false;
            originalMasterPasswordTextBox.TextChanged += setOKButtonEnabled;
            // 
            // originalMasterPasswordLabel
            // 
            originalMasterPasswordLabel.AutoSize = true;
            originalMasterPasswordLabel.Location = new Point(12, 15);
            originalMasterPasswordLabel.Name = "originalMasterPasswordLabel";
            originalMasterPasswordLabel.Size = new Size(176, 20);
            originalMasterPasswordLabel.TabIndex = 6;
            originalMasterPasswordLabel.Text = "Original Master Password";
            originalMasterPasswordLabel.Visible = false;
            // 
            // MasterPasswordForm
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 156);
            Controls.Add(originalMasterPasswordLabel);
            Controls.Add(originalMasterPasswordTextBox);
            Controls.Add(verifyMasterPasswordLabel);
            Controls.Add(verifyMasterPasswordTextBox);
            Controls.Add(okButton);
            Controls.Add(masterPasswordLabel);
            Controls.Add(masterPasswordTextBox);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MasterPasswordForm";
            TopMost = true;
            FormClosed += MasterPasswordForm_FormClosed;
            Shown += MasterPasswordForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox masterPasswordTextBox;
        private Label masterPasswordLabel;
        private Button okButton;
        private TextBox verifyMasterPasswordTextBox;
        private Label verifyMasterPasswordLabel;
        private TextBox originalMasterPasswordTextBox;
        private Label originalMasterPasswordLabel;
    }
}