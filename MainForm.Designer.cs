namespace PasswordManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            entriesListView = new ListView();
            service = new ColumnHeader("(無)");
            username = new ColumnHeader();
            password = new ColumnHeader();
            note = new ColumnHeader();
            addEntryButton = new Button();
            editButton = new Button();
            saveButton = new Button();
            resetMasterPasswordButton = new Button();
            clipboardTimer = new System.Windows.Forms.Timer(components);
            toggleButton = new Button();
            copyButton = new Button();
            statusStrip1 = new StatusStrip();
            hintStatusLabel = new ToolStripStatusLabel();
            aboutButton = new Button();
            deleteButton = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // entriesListView
            // 
            entriesListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            entriesListView.Columns.AddRange(new ColumnHeader[] { service, username, password, note });
            entriesListView.FullRowSelect = true;
            entriesListView.GridLines = true;
            entriesListView.Location = new Point(12, 86);
            entriesListView.MultiSelect = false;
            entriesListView.Name = "entriesListView";
            entriesListView.Size = new Size(614, 251);
            entriesListView.TabIndex = 0;
            entriesListView.UseCompatibleStateImageBehavior = false;
            entriesListView.View = View.Details;
            entriesListView.SelectedIndexChanged += entriesListView_SelectedIndexChanged;
            entriesListView.DoubleClick += copyPassword;
            // 
            // service
            // 
            service.Text = "Service";
            service.Width = 120;
            // 
            // username
            // 
            username.Text = "Username";
            username.Width = 120;
            // 
            // password
            // 
            password.Text = "Password";
            password.Width = 120;
            // 
            // note
            // 
            note.Text = "Note";
            note.Width = 200;
            // 
            // addEntryButton
            // 
            addEntryButton.Location = new Point(12, 12);
            addEntryButton.Name = "addEntryButton";
            addEntryButton.Size = new Size(72, 31);
            addEntryButton.TabIndex = 1;
            addEntryButton.Text = "Add";
            addEntryButton.UseVisualStyleBackColor = true;
            addEntryButton.Click += addEntryButton_Click;
            // 
            // editButton
            // 
            editButton.Enabled = false;
            editButton.Location = new Point(90, 12);
            editButton.Name = "editButton";
            editButton.Size = new Size(72, 31);
            editButton.TabIndex = 2;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            saveButton.Enabled = false;
            saveButton.Location = new Point(553, 12);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(73, 31);
            saveButton.TabIndex = 3;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // resetMasterPasswordButton
            // 
            resetMasterPasswordButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            resetMasterPasswordButton.Location = new Point(375, 12);
            resetMasterPasswordButton.Name = "resetMasterPasswordButton";
            resetMasterPasswordButton.Size = new Size(172, 31);
            resetMasterPasswordButton.TabIndex = 4;
            resetMasterPasswordButton.Text = "Reset Master Password";
            resetMasterPasswordButton.UseVisualStyleBackColor = true;
            resetMasterPasswordButton.Click += resetMasterPasswordButton_Click;
            // 
            // clipboardTimer
            // 
            clipboardTimer.Interval = 15000;
            clipboardTimer.Tick += clipboardTimer_Tick;
            // 
            // toggleButton
            // 
            toggleButton.Enabled = false;
            toggleButton.Location = new Point(12, 49);
            toggleButton.Name = "toggleButton";
            toggleButton.Size = new Size(72, 31);
            toggleButton.TabIndex = 5;
            toggleButton.Text = "Toggle";
            toggleButton.UseVisualStyleBackColor = true;
            toggleButton.Click += toggleButton_Click;
            toggleButton.MouseEnter += toggleButton_MouseEnter;
            toggleButton.MouseLeave += clearHintStatusLabel;
            // 
            // copyButton
            // 
            copyButton.Enabled = false;
            copyButton.Location = new Point(90, 49);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(72, 31);
            copyButton.TabIndex = 6;
            copyButton.Text = "Copy";
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyPassword;
            copyButton.MouseEnter += copyButton_MouseEnter;
            copyButton.MouseLeave += clearHintStatusLabel;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { hintStatusLabel });
            statusStrip1.Location = new Point(0, 340);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(638, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // hintStatusLabel
            // 
            hintStatusLabel.Name = "hintStatusLabel";
            hintStatusLabel.Size = new Size(0, 16);
            // 
            // aboutButton
            // 
            aboutButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            aboutButton.Location = new Point(553, 49);
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new Size(73, 31);
            aboutButton.TabIndex = 8;
            aboutButton.Text = "About";
            aboutButton.UseVisualStyleBackColor = true;
            aboutButton.Click += aboutButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Enabled = false;
            deleteButton.Location = new Point(168, 12);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(72, 31);
            deleteButton.TabIndex = 9;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 362);
            Controls.Add(deleteButton);
            Controls.Add(aboutButton);
            Controls.Add(statusStrip1);
            Controls.Add(copyButton);
            Controls.Add(toggleButton);
            Controls.Add(resetMasterPasswordButton);
            Controls.Add(saveButton);
            Controls.Add(editButton);
            Controls.Add(addEntryButton);
            Controls.Add(entriesListView);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "MainForm";
            Text = "Password Manager";
            FormClosing += MainForm_FormClosing;
            Load += Form1_Load;
            KeyDown += MainForm_KeyDown;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView entriesListView;
        private Button addEntryButton;
        private ColumnHeader service;
        private ColumnHeader username;
        private ColumnHeader password;
        private ColumnHeader note;
        private Button editButton;
        private Button saveButton;
        private Button resetMasterPasswordButton;
        private System.Windows.Forms.Timer clipboardTimer;
        private Button toggleButton;
        private Button copyButton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel hintStatusLabel;
        private Button aboutButton;
        private Button deleteButton;
    }
}