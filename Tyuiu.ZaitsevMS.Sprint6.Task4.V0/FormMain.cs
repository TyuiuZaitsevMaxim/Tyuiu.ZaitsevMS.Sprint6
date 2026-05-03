using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Tyuiu.ZaitsevMS.Sprint6.Task4.V0.Lib;

namespace Tyuiu.ZaitsevMS.Sprint6.Task4.V0
{
    public partial class FormMain : Form
    {
        private const int StartStep_ZMS = -5;
        private const int StopStep_ZMS = 5;
        private const string OutputFileName_ZMS = "OutputFileTask4.txt";

        DataService ds_ZMS = new DataService();

        public FormMain()
        {
            InitializeComponent();
            textBoxStartStep_ZMS.Text = Convert.ToString(StartStep_ZMS);
            textBoxStopStep_ZMS.Text = Convert.ToString(StopStep_ZMS);
        }

        private void buttonDone_ZMS_Click(object sender, EventArgs e)
        {
            FillOutput_ZMS();
        }

        private void buttonSave_ZMS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxResult_ZMS.Text))
            {
                FillOutput_ZMS();
            }

            string filePath = Path.Combine(Application.StartupPath, OutputFileName_ZMS);
            File.WriteAllText(filePath, textBoxResult_ZMS.Text, Encoding.UTF8);

            DialogResult result = MessageBox.Show(
                "Вывод сохранен в файл " + OutputFileName_ZMS + Environment.NewLine + "Открыть файл в блокноте?",
                "Файл сохранен",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Process.Start("notepad.exe", filePath);
            }
        }

        private void buttonHelp_ZMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИБКСб-25-1 Зайцев Максим Сергеевич");
        }

        private void FillOutput_ZMS()
        {
            double[] valueArray = ds_ZMS.GetMassFunction(StartStep_ZMS, StopStep_ZMS);

            textBoxResult_ZMS.Clear();
            chartFunction_ZMS.Series[0].Points.Clear();

            textBoxResult_ZMS.AppendText("+----------+----------+" + Environment.NewLine);
            textBoxResult_ZMS.AppendText("|    x     |  sin(x)  |" + Environment.NewLine);
            textBoxResult_ZMS.AppendText("+----------+----------+" + Environment.NewLine);

            for (int i = 0; i < valueArray.Length; i++)
            {
                int x = StartStep_ZMS + i;
                string line = string.Format("|{0,5:d}     |   {1,5:f2}   |", x, valueArray[i]);
                textBoxResult_ZMS.AppendText(line + Environment.NewLine);
                chartFunction_ZMS.Series[0].Points.AddXY(x, valueArray[i]);
            }

            textBoxResult_ZMS.AppendText("+----------+----------+" + Environment.NewLine);
        }
    }
}
