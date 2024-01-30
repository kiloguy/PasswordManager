namespace PasswordManager
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            aboutRichTextBox = new RichTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // aboutRichTextBox
            // 
            aboutRichTextBox.BorderStyle = BorderStyle.None;
            aboutRichTextBox.Location = new Point(95, 12);
            aboutRichTextBox.Name = "aboutRichTextBox";
            aboutRichTextBox.ReadOnly = true;
            aboutRichTextBox.ScrollBars = RichTextBoxScrollBars.None;
            aboutRichTextBox.Size = new Size(389, 88);
            aboutRichTextBox.TabIndex = 2;
            aboutRichTextBox.Text = "Password Manager by kilo\nBuild\nRepository: https://github.com/kiloguy/PasswordManager";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_key;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 112);
            Controls.Add(pictureBox1);
            Controls.Add(aboutRichTextBox);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AboutForm";
            Text = "About";
            FormClosed += AboutForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox aboutRichTextBox;
        private PictureBox pictureBox1;
    }
}