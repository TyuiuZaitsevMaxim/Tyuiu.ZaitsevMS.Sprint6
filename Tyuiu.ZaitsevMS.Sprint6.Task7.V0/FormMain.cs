using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.ZaitsevMS.Sprint6.Task7.V3.Lib;

namespace Tyuiu.ZaitsevMS.Sprint6.Task7.V3
{
    public partial class FormMain : Form
    {
        private readonly DataService dataService_ZMS = new DataService();
        private int[,] matrixResult_ZMS;

        public FormMain()
        {
            InitializeComponent();
            buttonDone_ZMS.Enabled = false;
            buttonSave_ZMS.Enabled = false;
        }

        private void buttonOpenFile_ZMS_Click(object sender, EventArgs e)
        {
            if (openFileDialogTask_ZMS.ShowDialog() != DialogResult.OK) return;

            string path = openFileDialogTask_ZMS.FileName;

            string[] lines = File.ReadAllLines(path);
            dataGridViewIn_ZMS.Rows.Clear();
            dataGridViewIn_ZMS.Columns.Clear();

            if (lines.Length == 0) return;

            int cols = lines[0].Split(',').Length;
            for (int j = 0; j < cols; j++)
                dataGridViewIn_ZMS.Columns.Add("col" + j, j.ToString());

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                string[] parts = line.Split(',');
                var row = new DataGridViewRow();
                row.CreateCells(dataGridViewIn_ZMS);
                for (int j = 0; j < parts.Length; j++)
                    row.Cells[j].Value = int.Parse(parts[j].Trim());
                dataGridViewIn_ZMS.Rows.Add(row);
            }

            groupBoxInput_ZMS.Text = "Ввод: " + path;
            buttonDone_ZMS.Enabled = true;
            buttonSave_ZMS.Enabled = false;
            dataGridViewOut_ZMS.Rows.Clear();
            dataGridViewOut_ZMS.Columns.Clear();
        }

        private void buttonDone_ZMS_Click(object sender, EventArgs e)
        {
            string path = openFileDialogTask_ZMS.FileName;
            matrixResult_ZMS = dataService_ZMS.GetMatrix(path);
            FillDataGridView(dataGridViewOut_ZMS, matrixResult_ZMS);
            buttonSave_ZMS.Enabled = true;
        }

        private void buttonSave_ZMS_Click(object sender, EventArgs e)
        {
            if (saveFileDialogTask_ZMS.ShowDialog() != DialogResult.OK) return;
            dataService_ZMS.SaveToCsv(saveFileDialogTask_ZMS.FileName, matrixResult_ZMS);
            MessageBox.Show("Файл сохранён: " + saveFileDialogTask_ZMS.FileName, "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonHelp_ZMS_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        private void FillDataGridView(DataGridView dgv, int[,] matrix)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int j = 0; j < cols; j++)
                dgv.Columns.Add("col" + j, j.ToString());

            for (int i = 0; i < rows; i++)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dgv);
                for (int j = 0; j < cols; j++)
                    row.Cells[j].Value = matrix[i, j];
                dgv.Rows.Add(row);
            }
        }
    }
}