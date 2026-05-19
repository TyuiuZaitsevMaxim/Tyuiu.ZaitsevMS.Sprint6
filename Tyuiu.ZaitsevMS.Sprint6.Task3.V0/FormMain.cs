using System;
using System.Windows.Forms;
using Tyuiu.ZaitsevMS.Sprint6.Task3.V19.Lib;

namespace Tyuiu.ZaitsevMS.Sprint6.Task3.V19
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        int[,] matrix =
        {
            {  4, 32, -20, 27, 21 },
            { 17, 15,  -1, -2, -1 },
            { -3, 18,  12,-10, 29 },
            {  7,-15,   2, -8, 12 },
            {-10, 25,   5, 27, 21 }
        };

        public FormMain()
        {
            InitializeComponent();
            LoadMatrix_ZMS(matrix);
        }

        private void LoadMatrix_ZMS(int[,] mtrx)
        {
            dataGridViewMatrix.RowCount = mtrx.GetLength(0);
            dataGridViewMatrix.ColumnCount = mtrx.GetLength(1);

            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                dataGridViewMatrix.Rows[i].Height = 40;
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    dataGridViewMatrix.Columns[j].Width = 55;
                    dataGridViewMatrix.Columns[j].HeaderText = (j + 1).ToString();
                    dataGridViewMatrix.Rows[i].Cells[j].Value = mtrx[i, j];
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] sorted = ds.Calculate(matrix);
            LoadMatrix_ZMS(sorted);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИБКСб-25-1 Зайцев Максим Сергеевич");
        }
    }
}