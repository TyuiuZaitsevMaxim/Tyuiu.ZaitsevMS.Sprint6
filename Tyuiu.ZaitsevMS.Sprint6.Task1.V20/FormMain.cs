using System;
using System.Windows.Forms;
using Tyuiu.ZaitsevMS.Sprint6.Task1.V20.Lib;

namespace Tyuiu.ZaitsevMS.Sprint6.Task1.V20
{
    public partial class FormMain : Form
    {
        private const int StartStep_ZMS = -5;
        private const int StopStep_ZMS = 5;

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

        private void buttonHelp_ZMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИБКСб-25-1 Зайцев Максим Сергеевич");
        }

        private void FillOutput_ZMS()
        {
            double[] valueArray = ds_ZMS.GetMassFunction(StartStep_ZMS, StopStep_ZMS);

            textBoxResult_ZMS.Clear();

            textBoxResult_ZMS.AppendText("+----------+----------+" + Environment.NewLine);
            textBoxResult_ZMS.AppendText("|    x     |   f(x)   |" + Environment.NewLine);
            textBoxResult_ZMS.AppendText("+----------+----------+" + Environment.NewLine);

            for (int i = 0; i < valueArray.Length; i++)
            {
                int x = StartStep_ZMS + i;
                string line = string.Format("|{0,5:d}     |  {1,6:f2}   |", x, valueArray[i]);
                textBoxResult_ZMS.AppendText(line + Environment.NewLine);
            }

            textBoxResult_ZMS.AppendText("+----------+----------+" + Environment.NewLine);
        }
    }
}