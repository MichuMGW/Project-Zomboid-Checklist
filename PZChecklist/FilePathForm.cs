using PZChecklistLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PZChecklist
{
    public partial class FilePathSelector : Form
    {
        public string SelectedSteamappsPath { get; private set; }
        public string SelectedGameFilesPath { get; private set; }
        public string SelectedModsPath { get; private set; }
        public bool AllowMods { get; private set; }

        public FilePathSelector() : this("C:\\Program Files (x86)\\Steam\\steamapps") { }

        public FilePathSelector(string path)
        {
            InitializeComponent();

            textBoxFilePath.Text = path;

            browseButton.Click += OnBrowseButtonClick;

            acceptButton.Click += OnAcceptButtonClick;
        }

        private void OnBrowseButtonClick(object? sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            //folderBrowserDialog.Description = "Select the folder where your Project Zomboid save files are located.";
            folderBrowserDialog.ShowNewFolderButton = false;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void OnAcceptButtonClick(object? sender, EventArgs e)
        {
            string path = textBoxFilePath.Text;
            if (Directory.Exists($@"{path}\common\ProjectZomboid"))
            {
                SelectedSteamappsPath = path;
                SelectedGameFilesPath = $"{path}\\common\\ProjectZomboid\\media\\scripts\\items";
                SelectedModsPath = $"{path}\\workshop\\content\\108600";
                AllowMods = modsCheckBox.Checked;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("The selected folder does not contain the required files.");
            }

        }

    }
}
