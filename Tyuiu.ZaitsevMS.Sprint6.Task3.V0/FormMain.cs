using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZaitsevMS.Sprint6.Task3.V0.Lib;

namespace Tyuiu.ZaitsevMS.Sprint6.Task3.V0
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        int[,] matrix = { { 0, 1, 2 }, { 3, 0, 5 }, { 3, 4, 5 } };

        public FormMain()
        {
            InitializeComponent();
            LoadMatrix();
        }

        private void LoadMatrix()
        {
            dataGridViewMatrix.RowCount = matrix.GetLength(0);
            dataGridViewMatrix.ColumnCount = matrix.GetLength(1);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                dataGridViewMatrix.Rows[i].Height = 40;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridViewMatrix.Columns[j].Width = 55;
                    dataGridViewMatrix.Columns[j].HeaderText = (j + 1).ToString();
                    dataGridViewMatrix.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = Convert.ToString(ds.GetCountZero(matrix));
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИБКСб-25-1 Зайцев Максим Сергеевич");
        }
    }
}
