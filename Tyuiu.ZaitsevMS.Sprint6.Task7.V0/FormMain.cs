using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.ZaitsevMS.Sptint6.Task7.V0.Lib;

namespace Tyuiu.ZaitsevMS.Sprint6.Task7.V0
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
            int[,] matrix = dataService_ZMS.LoadFromCsv(path);

            FillDataGridView(dataGridViewIn_ZMS, matrix);

            groupBoxInput_ZMS.Text = "Ввод: " + path;
            buttonDone_ZMS.Enabled = true;
            buttonSave_ZMS.Enabled = false;
            dataGridViewOut_ZMS.Rows.Clear();
            dataGridViewOut_ZMS.Columns.Clear();
        }

        private void buttonDone_ZMS_Click(object sender, EventArgs e)
        {
            int rows = dataGridViewIn_ZMS.Rows.Count;
            int cols = dataGridViewIn_ZMS.Columns.Count;
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = int.Parse(dataGridViewIn_ZMS.Rows[i].Cells[j].Value.ToString());

            matrixResult_ZMS = dataService_ZMS.GetMatrix(matrix);
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