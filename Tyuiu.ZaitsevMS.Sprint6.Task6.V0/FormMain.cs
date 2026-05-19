using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.ZaitsevMS.Sprint6.Task6.V27.Lib;

namespace Tyuiu.ZaitsevMS.Sprint6.Task6.V27
{
    public partial class FormMain : Form
    {
        private readonly DataService dataService_ZMS = new DataService();
        private string openFilePath_ZMS = string.Empty;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_ZMS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ZMS.ShowDialog();
            openFilePath_ZMS = openFileDialogTask_ZMS.FileName;
            textBoxIn_ZMS.Text = File.ReadAllText(openFilePath_ZMS);
            groupBoxInput_ZMS.Text = "Ввод: " + openFilePath_ZMS;
            buttonDone_ZMS.Enabled = true;
        }

        private void buttonDone_ZMS_Click(object sender, EventArgs e)
        {
            textBoxOut_ZMS.Text = dataService_ZMS.CollectTextFromFile(textBoxIn_ZMS.Text);
        }

        private void buttonHelp_ZMS_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }
    }
}