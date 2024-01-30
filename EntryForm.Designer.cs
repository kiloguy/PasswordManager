namespace PasswordManager
{
    partial class EntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            serviceTextBox = new TextBox();
            usernameTextBox = new TextBox();
            noteTextBox = new TextBox();
            okButton = new Button();
            passwordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            verifyPasswordTextBox = new TextBox();
            label5 = new Label();
            toggleButton = new Button();
            generateButton = new Button();
            SuspendLayout();
            // 
            // serviceTextBox
            // 
            serviceTextBox.Location = new Point(129, 12);
            serviceTextBox.Name = "serviceTextBox";
            serviceTextBox.PlaceholderText = "Service, website, URL, ...";
            serviceTextBox.Size = new Size(219, 27);
            serviceTextBox.TabIndex = 0;
            serviceTextBox.TextChanged += setOKButtonEnabled;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(129, 45);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "Username, account, ...";
            usernameTextBox.Size = new Size(219, 27);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.TextChanged += setOKButtonEnabled;
            // 
            // noteTextBox
            // 
            noteTextBox.AcceptsReturn = true;
            noteTextBox.AcceptsTab = true;
            noteTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            noteTextBox.Location = new Point(129, 144);
            noteTextBox.Multiline = true;
            noteTextBox.Name = "noteTextBox";
            noteTextBox.PlaceholderText = "Note, description, ...";
            noteTextBox.ScrollBars = ScrollBars.Both;
            noteTextBox.Size = new Size(412, 85);
            noteTextBox.TabIndex = 4;
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okButton.Enabled = false;
            okButton.Location = new Point(470, 235);
            okButton.Name = "okButton";
            okButton.Size = new Size(71, 31);
            okButton.TabIndex = 5;
            okButton.TabStop = false;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(129, 78);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(219, 27);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.TextChanged += setOKButtonEnabled;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 15);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 5;
            label1.Text = "Service";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 48);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 6;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 81);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 147);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 8;
            label4.Text = "Note";
            // 
            // verifyPasswordTextBox
            // 
            verifyPasswordTextBox.Location = new Point(129, 111);
            verifyPasswordTextBox.Name = "verifyPasswordTextBox";
            verifyPasswordTextBox.PasswordChar = '*';
            verifyPasswordTextBox.PlaceholderText = "Enter the password again";
            verifyPasswordTextBox.Size = new Size(219, 27);
            verifyPasswordTextBox.TabIndex = 3;
            verifyPasswordTextBox.TextChanged += setOKButtonEnabled;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 114);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 11;
            label5.Text = "Verify Password";
            // 
            // toggleButton
            // 
            toggleButton.Location = new Point(354, 78);
            toggleButton.Name = "toggleButton";
            toggleButton.Size = new Size(81, 27);
            toggleButton.TabIndex = 12;
            toggleButton.Text = "Toggle";
            toggleButton.UseVisualStyleBackColor = true;
            toggleButton.Click += toggleButton_Click;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(441, 78);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(90, 27);
            generateButton.TabIndex = 13;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // EntryForm
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 278);
            Controls.Add(generateButton);
            Controls.Add(toggleButton);
            Controls.Add(label5);
            Controls.Add(verifyPasswordTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordTextBox);
            Controls.Add(okButton);
            Controls.Add(noteTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(serviceTextBox);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "EntryForm";
            TopMost = true;
            FormClosed += EntryForm_FormClosed;
            Shown += EntryForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox serviceTextBox;
        private TextBox usernameTextBox;
        private TextBox noteTextBox;
        private Button okButton;
        private TextBox passwordTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox verifyPasswordTextBox;
        private Label label5;
        private Button toggleButton;
        private Button generateButton;
    }
}