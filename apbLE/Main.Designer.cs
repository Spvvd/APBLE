namespace apbLE
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReloadFileListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetLocalizationFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SGPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartAPBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MainStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.FileListBox = new System.Windows.Forms.ListBox();
            this.PanelSpacerLeft = new System.Windows.Forms.Panel();
            this.VariableListBox = new System.Windows.Forms.ListBox();
            this.VariableTextBox = new System.Windows.Forms.TextBox();
            this.PanelRight = new System.Windows.Forms.Panel();
            this.RightPanelSplitter = new System.Windows.Forms.Splitter();
            this.PreviewTextBox = new System.Windows.Forms.TextBox();
            this.OptionsPanelRight = new System.Windows.Forms.Panel();
            this.ReloadVariableButton = new System.Windows.Forms.Button();
            this.SaveVariableButton = new System.Windows.Forms.Button();
            this.SplitterMiddleLeft = new System.Windows.Forms.Splitter();
            this.SplitterMiddleRight = new System.Windows.Forms.Splitter();
            this.PanelSpacerRight = new System.Windows.Forms.Panel();
            this.VariableComboBox = new System.Windows.Forms.ComboBox();
            this.PanelMiddle = new System.Windows.Forms.Panel();
            this.MainMenuStrip.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            this.PanelRight.SuspendLayout();
            this.OptionsPanelRight.SuspendLayout();
            this.PanelMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.gameToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1084, 24);
            this.MainMenuStrip.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReloadFileListToolStripMenuItem,
            this.ResetLocalizationFilesToolStripMenuItem,
            this.SGPToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ReloadFileListToolStripMenuItem
            // 
            this.ReloadFileListToolStripMenuItem.Enabled = false;
            this.ReloadFileListToolStripMenuItem.Name = "ReloadFileListToolStripMenuItem";
            this.ReloadFileListToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.ReloadFileListToolStripMenuItem.Text = "Reload File List";
            this.ReloadFileListToolStripMenuItem.Click += new System.EventHandler(this.ReloadFileListToolStripMenuItem_Click);
            // 
            // ResetLocalizationFilesToolStripMenuItem
            // 
            this.ResetLocalizationFilesToolStripMenuItem.Enabled = false;
            this.ResetLocalizationFilesToolStripMenuItem.Name = "ResetLocalizationFilesToolStripMenuItem";
            this.ResetLocalizationFilesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.ResetLocalizationFilesToolStripMenuItem.Text = "Reset Localization Files";
            this.ResetLocalizationFilesToolStripMenuItem.Click += new System.EventHandler(this.ResetLocalizationFilesToolStripMenuItem_Click);
            // 
            // SGPToolStripMenuItem
            // 
            this.SGPToolStripMenuItem.Name = "SGPToolStripMenuItem";
            this.SGPToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.SGPToolStripMenuItem.Text = "Set Game Path";
            this.SGPToolStripMenuItem.Click += new System.EventHandler(this.SetGamePathToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PropertiesToolStripMenuItem});
            this.EditToolStripMenuItem.Enabled = false;
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // PropertiesToolStripMenuItem
            // 
            this.PropertiesToolStripMenuItem.Enabled = false;
            this.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem";
            this.PropertiesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.PropertiesToolStripMenuItem.Text = "Properties";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartAPBToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // StartAPBToolStripMenuItem
            // 
            this.StartAPBToolStripMenuItem.Enabled = false;
            this.StartAPBToolStripMenuItem.Name = "StartAPBToolStripMenuItem";
            this.StartAPBToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.StartAPBToolStripMenuItem.Text = "Start APB";
            this.StartAPBToolStripMenuItem.Click += new System.EventHandler(this.StartAPBToolStripMenuItem_Click);
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainStripStatusLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 439);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(1084, 22);
            this.MainStatusStrip.TabIndex = 1;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // MainStripStatusLabel
            // 
            this.MainStripStatusLabel.Name = "MainStripStatusLabel";
            this.MainStripStatusLabel.Size = new System.Drawing.Size(66, 17);
            this.MainStripStatusLabel.Text = "Path: None";
            // 
            // FileListBox
            // 
            this.FileListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.FileListBox.Enabled = false;
            this.FileListBox.FormattingEnabled = true;
            this.FileListBox.Location = new System.Drawing.Point(10, 24);
            this.FileListBox.Name = "FileListBox";
            this.FileListBox.Size = new System.Drawing.Size(250, 415);
            this.FileListBox.TabIndex = 0;
            this.FileListBox.SelectedIndexChanged += new System.EventHandler(this.FileListBox_SelectedIndexChanged);
            // 
            // PanelSpacerLeft
            // 
            this.PanelSpacerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSpacerLeft.Location = new System.Drawing.Point(0, 24);
            this.PanelSpacerLeft.Name = "PanelSpacerLeft";
            this.PanelSpacerLeft.Size = new System.Drawing.Size(10, 415);
            this.PanelSpacerLeft.TabIndex = 3;
            // 
            // VariableListBox
            // 
            this.VariableListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VariableListBox.BackColor = System.Drawing.SystemColors.Window;
            this.VariableListBox.Enabled = false;
            this.VariableListBox.FormattingEnabled = true;
            this.VariableListBox.Location = new System.Drawing.Point(3, 30);
            this.VariableListBox.Name = "VariableListBox";
            this.VariableListBox.Size = new System.Drawing.Size(489, 381);
            this.VariableListBox.TabIndex = 2;
            this.VariableListBox.SelectedIndexChanged += new System.EventHandler(this.VariableListBox_SelectedIndexChanged);
            // 
            // VariableTextBox
            // 
            this.VariableTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VariableTextBox.Enabled = false;
            this.VariableTextBox.Location = new System.Drawing.Point(0, 197);
            this.VariableTextBox.Multiline = true;
            this.VariableTextBox.Name = "VariableTextBox";
            this.VariableTextBox.Size = new System.Drawing.Size(299, 187);
            this.VariableTextBox.TabIndex = 4;
            this.VariableTextBox.TextChanged += new System.EventHandler(this.VariableTextBox_TextChanged);
            // 
            // PanelRight
            // 
            this.PanelRight.Controls.Add(this.VariableTextBox);
            this.PanelRight.Controls.Add(this.RightPanelSplitter);
            this.PanelRight.Controls.Add(this.PreviewTextBox);
            this.PanelRight.Controls.Add(this.OptionsPanelRight);
            this.PanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRight.Location = new System.Drawing.Point(775, 24);
            this.PanelRight.Name = "PanelRight";
            this.PanelRight.Size = new System.Drawing.Size(299, 415);
            this.PanelRight.TabIndex = 6;
            // 
            // RightPanelSplitter
            // 
            this.RightPanelSplitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.RightPanelSplitter.Location = new System.Drawing.Point(0, 187);
            this.RightPanelSplitter.Name = "RightPanelSplitter";
            this.RightPanelSplitter.Size = new System.Drawing.Size(299, 10);
            this.RightPanelSplitter.TabIndex = 9;
            this.RightPanelSplitter.TabStop = false;
            // 
            // PreviewTextBox
            // 
            this.PreviewTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PreviewTextBox.Location = new System.Drawing.Point(0, 0);
            this.PreviewTextBox.Multiline = true;
            this.PreviewTextBox.Name = "PreviewTextBox";
            this.PreviewTextBox.ReadOnly = true;
            this.PreviewTextBox.Size = new System.Drawing.Size(299, 187);
            this.PreviewTextBox.TabIndex = 3;
            // 
            // OptionsPanelRight
            // 
            this.OptionsPanelRight.Controls.Add(this.ReloadVariableButton);
            this.OptionsPanelRight.Controls.Add(this.SaveVariableButton);
            this.OptionsPanelRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OptionsPanelRight.Location = new System.Drawing.Point(0, 384);
            this.OptionsPanelRight.Name = "OptionsPanelRight";
            this.OptionsPanelRight.Size = new System.Drawing.Size(299, 31);
            this.OptionsPanelRight.TabIndex = 8;
            // 
            // ReloadVariableButton
            // 
            this.ReloadVariableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReloadVariableButton.Enabled = false;
            this.ReloadVariableButton.Location = new System.Drawing.Point(143, 5);
            this.ReloadVariableButton.Name = "ReloadVariableButton";
            this.ReloadVariableButton.Size = new System.Drawing.Size(75, 23);
            this.ReloadVariableButton.TabIndex = 5;
            this.ReloadVariableButton.Text = "Reload";
            this.ReloadVariableButton.UseVisualStyleBackColor = true;
            this.ReloadVariableButton.Click += new System.EventHandler(this.ReloadVariableButton_Click);
            // 
            // SaveVariableButton
            // 
            this.SaveVariableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveVariableButton.Enabled = false;
            this.SaveVariableButton.Location = new System.Drawing.Point(224, 5);
            this.SaveVariableButton.Name = "SaveVariableButton";
            this.SaveVariableButton.Size = new System.Drawing.Size(75, 23);
            this.SaveVariableButton.TabIndex = 6;
            this.SaveVariableButton.Text = "Save";
            this.SaveVariableButton.UseVisualStyleBackColor = true;
            this.SaveVariableButton.Click += new System.EventHandler(this.SaveVariableButton_Click);
            // 
            // SplitterMiddleLeft
            // 
            this.SplitterMiddleLeft.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.SplitterMiddleLeft.Location = new System.Drawing.Point(260, 24);
            this.SplitterMiddleLeft.Name = "SplitterMiddleLeft";
            this.SplitterMiddleLeft.Size = new System.Drawing.Size(10, 415);
            this.SplitterMiddleLeft.TabIndex = 7;
            this.SplitterMiddleLeft.TabStop = false;
            // 
            // SplitterMiddleRight
            // 
            this.SplitterMiddleRight.Location = new System.Drawing.Point(765, 24);
            this.SplitterMiddleRight.Name = "SplitterMiddleRight";
            this.SplitterMiddleRight.Size = new System.Drawing.Size(10, 415);
            this.SplitterMiddleRight.TabIndex = 8;
            this.SplitterMiddleRight.TabStop = false;
            // 
            // PanelSpacerRight
            // 
            this.PanelSpacerRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelSpacerRight.Location = new System.Drawing.Point(1074, 24);
            this.PanelSpacerRight.Name = "PanelSpacerRight";
            this.PanelSpacerRight.Size = new System.Drawing.Size(10, 415);
            this.PanelSpacerRight.TabIndex = 4;
            // 
            // VariableComboBox
            // 
            this.VariableComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VariableComboBox.FormattingEnabled = true;
            this.VariableComboBox.Location = new System.Drawing.Point(3, 0);
            this.VariableComboBox.Name = "VariableComboBox";
            this.VariableComboBox.Size = new System.Drawing.Size(489, 21);
            this.VariableComboBox.TabIndex = 1;
            this.VariableComboBox.SelectedIndexChanged += new System.EventHandler(this.VariableComboBox_SelectedIndexChanged);
            // 
            // PanelMiddle
            // 
            this.PanelMiddle.Controls.Add(this.VariableComboBox);
            this.PanelMiddle.Controls.Add(this.VariableListBox);
            this.PanelMiddle.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMiddle.Location = new System.Drawing.Point(270, 24);
            this.PanelMiddle.Name = "PanelMiddle";
            this.PanelMiddle.Size = new System.Drawing.Size(495, 415);
            this.PanelMiddle.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.PanelRight);
            this.Controls.Add(this.SplitterMiddleRight);
            this.Controls.Add(this.PanelMiddle);
            this.Controls.Add(this.PanelSpacerRight);
            this.Controls.Add(this.SplitterMiddleLeft);
            this.Controls.Add(this.FileListBox);
            this.Controls.Add(this.PanelSpacerLeft);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.MainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "APB Localization Editor";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.PanelRight.ResumeLayout(false);
            this.PanelRight.PerformLayout();
            this.OptionsPanelRight.ResumeLayout(false);
            this.PanelMiddle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SGPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PropertiesToolStripMenuItem;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel MainStripStatusLabel;
        private System.Windows.Forms.ListBox FileListBox;
        private System.Windows.Forms.Panel PanelSpacerLeft;
        private System.Windows.Forms.ListBox VariableListBox;
        private System.Windows.Forms.TextBox VariableTextBox;
        private System.Windows.Forms.Panel PanelRight;
        private System.Windows.Forms.Button SaveVariableButton;
        private System.Windows.Forms.Panel OptionsPanelRight;
        private System.Windows.Forms.Button ReloadVariableButton;
        private System.Windows.Forms.Splitter SplitterMiddleLeft;
        private System.Windows.Forms.Splitter SplitterMiddleRight;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartAPBToolStripMenuItem;
        private System.Windows.Forms.Panel PanelSpacerRight;
        private System.Windows.Forms.ToolStripMenuItem ReloadFileListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResetLocalizationFilesToolStripMenuItem;
        private System.Windows.Forms.ComboBox VariableComboBox;
        private System.Windows.Forms.Panel PanelMiddle;
        private System.Windows.Forms.Splitter RightPanelSplitter;
        private System.Windows.Forms.TextBox PreviewTextBox;
    }
}

