using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace apbLE
{
    public partial class Main : Form
    {
        string gamePath;
        string localizationExt = "GER";
        string localizationCode = "1031";
        char[] equal = new char[1] { '=' };

        int prevSelectedIndexFileListBox = -1;
        int prevSelectedIndexVariableComboBox = -1;
        int prevSelectedIndexVariableListBox = -1;

        public Main()
        {
            InitializeComponent();
            CheckSettings();
        }

        private void CheckSettings()
        {
            if (File.Exists("settings.ini")) {
                gamePath = GetSettingsEntry("GamePath");
                if (gamePath == null || gamePath == "None")
                {
                    MessageBox.Show("Game path not set!\nFile -> Set Game Path");
                }
                else if (!Directory.Exists(gamePath))
                {
                    MessageBox.Show(String.Format("Directory \"{0}\" does not exist!", gamePath));
                }
                else if (!CheckGameFiles())
                {
                    MessageBox.Show("Missing game files detected!\nFile -> Set Game Path");
                }
                else if (gamePath != null && gamePath != "None")
                {
                    if (CheckLocalizationFolder())
                    {
                        LoadFileList();
                    }
                }
                SetMenuStripStatus();
            } else {
                SetGamePath();
                MessageBox.Show("Game path not set!\nFile -> Set Game Path");
            }
        }

        private bool CheckLocalizationFolder()
        {
            if (gamePath != "None")
            {
                string locDir = String.Format("{0}\\APBGame\\Localization\\{1}", gamePath, localizationExt);
                Directory.CreateDirectory(locDir);
                if (Directory.GetFiles(locDir, "*.GER").Length == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("You are missing the GER localization files! Create?", "Missing Files", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        CreateLocalizationFiles();
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckGameFiles()
        {
            if (File.Exists(gamePath + "\\Binaries\\APB.exe"))
            {
                return true;
            }
            return false;
        }

        private void CreateLocalizationFiles()
        {
            foreach (var file in Directory.GetFiles(String.Format("{0}\\APBGame\\Localization\\{1}", gamePath, "INT")))
            {
                string newFileName = Path.ChangeExtension(Path.GetFileName(file), localizationExt);
                File.Copy(file, Path.Combine(String.Format("{0}\\APBGame\\Localization\\{1}", gamePath, localizationExt), newFileName));
            }
        }

        private void DeleteLocalizationFiles()
        {
            DirectoryInfo locDir = new DirectoryInfo(String.Format("{0}\\APBGame\\Localization\\{1}", gamePath, localizationExt));
            foreach (FileInfo file in locDir.GetFiles())
            {
                file.Delete();
            }
        }

        private void SetGamePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    SetGamePath(folderDialog.SelectedPath);
                }
            }
        }

        private void FileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FileListBox.SelectedItem != null && prevSelectedIndexFileListBox != FileListBox.SelectedIndex && AskSaveChanges())
            {
                GetLocalizationFileSections(FileListBox.SelectedItem.ToString());
                prevSelectedIndexFileListBox = FileListBox.SelectedIndex;
                VariableListBox.Enabled = true;
            }
            else
            {
                FileListBox.SelectedIndex = prevSelectedIndexFileListBox;
            }
        }

        private void VariableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VariableComboBox.SelectedItem != null && prevSelectedIndexVariableComboBox != VariableComboBox.SelectedIndex && AskSaveChanges())
            {
                GetLocalizationFileVariable(VariableComboBox.Text);
                prevSelectedIndexVariableComboBox = VariableComboBox.SelectedIndex;
            }
            else
            {
                VariableComboBox.SelectedIndex = prevSelectedIndexVariableComboBox;
            }
        }

        private void VariableListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VariableListBox.SelectedItem != null && prevSelectedIndexVariableListBox != VariableListBox.SelectedIndex && AskSaveChanges())
            {
                GetLocalizationFileVariableText(VariableListBox.SelectedItem.ToString());
                prevSelectedIndexVariableListBox = VariableListBox.SelectedIndex;
            }
            else
            {
                VariableListBox.SelectedIndex = prevSelectedIndexVariableListBox;
            }
        }

        private void VariableTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PreviewTextBox.Text != VariableTextBox.Text)
            {
                PreviewTextBox.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                PreviewTextBox.BackColor = System.Drawing.Color.Empty;
            }
        }

        private void ReloadVariableButton_Click(object sender, EventArgs e)
        {
            GetLocalizationFileVariableText(VariableListBox.SelectedItem.ToString());
        }

        private void SaveVariableButton_Click(object sender, EventArgs e)
        {
            string file = FileListBox.SelectedItem.ToString();
            var locFile = new IniFile(String.Format("{0}\\APBGame\\Localization\\{1}\\{2}.{1}", gamePath, localizationExt, file));
            locFile.Write(VariableListBox.SelectedItem.ToString(), VariableTextBox.Text.Replace(Environment.NewLine, " "), VariableComboBox.Text);
            PreviewTextBox.Text = VariableTextBox.Text.Replace(Environment.NewLine, "↵");
            PreviewTextBox.BackColor = System.Drawing.Color.Empty;
        }

        private bool AskSaveChanges()
        {
            if (VariableTextBox.Text != PreviewTextBox.Text)
            {
                DialogResult dialogResult = MessageBox.Show("You have unsaved changes. Discard?", "Unsaved changes", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }

        private void GetLocalizationFileSections(string file)
        {
            VariableComboBox.Text = "";
            VariableComboBox.Items.Clear();
            VariableListBox.Items.Clear();
            VariableListBox.Enabled = false;
            PreviewTextBox.Clear();
            VariableTextBox.Clear();
            VariableTextBox.Enabled = false;

            var locFile = new IniFile(String.Format("{0}\\APBGame\\Localization\\{1}\\{2}.{1}", gamePath, localizationExt, file));
            foreach (string sectionName in locFile.ReadSections())
            {
                VariableComboBox.Items.Add(sectionName);
            }
        }

        private void GetLocalizationFileVariable(string section)
        {
            PreviewTextBox.Clear();
            VariableTextBox.Clear();
            VariableTextBox.Enabled = false;
            VariableListBox.Items.Clear();

            var locFile = new IniFile(String.Format("{0}\\APBGame\\Localization\\{1}\\{2}.{1}", gamePath, localizationExt, FileListBox.SelectedItem));
            foreach (string key in locFile.GetKeys(section))
            {
                VariableListBox.Items.Add(key);
            }
        }

        private void GetLocalizationFileVariableText(string variable)
        {
            PreviewTextBox.Clear();
            VariableTextBox.Clear();

            var locFile = new IniFile(String.Format("{0}\\APBGame\\Localization\\{1}\\{2}.{1}", gamePath, localizationExt, FileListBox.SelectedItem));
            PreviewTextBox.Text = locFile.Read(variable, VariableComboBox.Text);
            VariableTextBox.Text = locFile.Read(variable, VariableComboBox.Text);
            VariableTextBox.Enabled = true;
            SaveVariableButton.Enabled = true;
            ReloadVariableButton.Enabled = true;
        }

        private System.Collections.Generic.IEnumerable<string> ReadLocalizationFileLines(string path)
        {   
            return File.ReadLines(path);
        }

        private void LoadFileList()
        {
            FileListBox.Items.Clear();
            VariableComboBox.Items.Clear();
            VariableComboBox.Text = "";
            VariableListBox.Items.Clear();
            PreviewTextBox.Clear();
            VariableTextBox.Clear();
            FileListBox.Enabled = false;
            VariableListBox.Enabled = false;
            VariableTextBox.Enabled = false;
            SaveVariableButton.Enabled = false;
            ReloadVariableButton.Enabled = false;

            try
            {
                foreach (FileInfo file in GetLocalizationFileList())
                {
                    FileListBox.Items.Add(file.Name.Replace(String.Format(".{0}", localizationExt), ""));
                }
                FileListBox.Enabled = true;
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("Error: Failed loading localization files. Is your Game Path properly set?\nFile -> Set Game Path");
            }
        }

        private void SetMenuStripStatus()
        {
            if (CheckGameFiles())
            {
                StartAPBToolStripMenuItem.Enabled = true;
                ReloadFileListToolStripMenuItem.Enabled = true;
                ResetLocalizationFilesToolStripMenuItem.Enabled = true;
                var exe = FileVersionInfo.GetVersionInfo(gamePath + "\\Binaries\\APB.exe");
                MainStripStatusLabel.Text = String.Format("Path: {0} (APB {1})", gamePath, exe.ProductVersion);
                SetSettingsEntry("LastVersion", exe.ProductVersion);
            }
            else
            {
                StartAPBToolStripMenuItem.Enabled = false;
                ReloadFileListToolStripMenuItem.Enabled = false;
                ResetLocalizationFilesToolStripMenuItem.Enabled = false;
                MainStripStatusLabel.Text = String.Format("Path: {0} (missing game files)", gamePath);
            }
        }

        private void SetGamePath(string path = "None")
        {
            SetSettingsEntry("GamePath", path);
            gamePath = path;
            SetMenuStripStatus();

            if (path != "None")
            {
                CheckSettings();
            }
        }

        private void SetSettingsEntry(string variable, string text)
        {
            var settings = new IniFile("settings.ini");
            settings.Write(variable, text, "Options");
        }

        private string GetSettingsEntry(string variable)
        {
            var settings = new IniFile("settings.ini");
            return settings.Read(variable, "Options");
        }

        private FileInfo[] GetLocalizationFileList()
        {
            DirectoryInfo d = new DirectoryInfo(String.Format("{0}\\APBGame\\Localization\\{1}", gamePath, localizationExt));
            return d.GetFiles(String.Format("*.{0}", localizationExt));
        }

        private void ReloadFileListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AskSaveChanges())
            {
                CheckSettings();
            }
        }

        private void ResetLocalizationFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gamePath != "None")
            {
                DialogResult dialogResult = MessageBox.Show("This will delete all changes. Are you sure?", "Reset Localization Files", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteLocalizationFiles();
                    CreateLocalizationFiles();
                    CheckSettings();
                }

            }
            else
            {
                MessageBox.Show("Game path not set!\nFile -> Set Game Path");
            }
        }

        private void StartAPBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(gamePath + "\\Binaries\\APB.exe", "-language=" + localizationCode);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AskSaveChanges())
            {
                Application.Exit();
            }
        }
    }
}
