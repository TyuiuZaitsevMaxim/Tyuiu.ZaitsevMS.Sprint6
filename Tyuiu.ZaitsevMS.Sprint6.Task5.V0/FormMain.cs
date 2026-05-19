using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Tyuiu.ZaitsevMS.Sprint6.Task5.V29.Lib;

namespace Tyuiu.ZaitsevMS.Sprint6.Task5.V29
{
    public partial class FormMain : Form
    {
        private readonly string path_ZMS = Path.Combine(Application.StartupPath, "InPutFileTask5V29.txt");
        DataService ds_ZMS = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_ZMS_Click(object sender, EventArgs e)
        {
            try
            {
                double[] values = ds_ZMS.LoadFromDataFile(path_ZMS);

                dataGridViewResult_ZMS.Rows.Clear();
                chartResult_ZMS.Series[0].Points.Clear();

                for (int i = 0; i < values.Length; i++)
                {
                    dataGridViewResult_ZMS.Rows.Add(i + 1, values[i]);
                    chartResult_ZMS.Series[0].Points.AddXY(i + 1, values[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось прочитать файл InPutFileTask5V29.txt\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpenFile_ZMS_Click(object sender, EventArgs e)
        {
            if (File.Exists(path_ZMS))
            {
                Process.Start("notepad.exe", path_ZMS);
            }
            else
            {
                MessageBox.Show("Файл InPutFileTask5V29.txt не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_ZMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИБКСб-25-1 Зайцев Максим Сергеевич");
        }
    }
}