using System;
using System.IO;
using Newtonsoft.Json;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Windows.Forms;

namespace Stream_Counter
{
    public partial class Settings : Form
    {
        private string pathLocation;

        public Settings()
        {
            InitializeComponent();
        }

        public void Settings_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            pathText.Text = path;
            pathLocation = path;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveToFile();
            this.Close();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            var output = readFromFile();
            pathText.Text = output.directory;
        }

        private void folderBtn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                pathText.Text = dialog.FileName;
                pathLocation = dialog.FileName;
            }
        }

        private void saveToFile()
        {
            settingsFile file = new settingsFile();
            file.directory = pathLocation;
            file.isDarkMode = false;

            string output = JsonConvert.SerializeObject(file);

            StreamWriter outSettings = new StreamWriter("settings.json", false);
            outSettings.Write(output);
            outSettings.Close();
        }

        public settingsFile readFromFile()
        {
            string output = File.ReadAllText("settings.json");

            settingsFile deserializedProduct = JsonConvert.DeserializeObject<settingsFile>(output);
            return deserializedProduct;
        }

        public class settingsFile
        {
            public string directory;
            public bool isDarkMode;

        }
    }
}
