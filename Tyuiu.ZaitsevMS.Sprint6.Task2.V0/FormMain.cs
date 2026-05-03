using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.ZaitsevMS.Sprint6.Task2.V0.Lib;

namespace Tyuiu.ZaitsevMS.Sprint6.Task2.V0
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }

    public class FormMain : Form
    {
        private GroupBox groupBoxCondition;
        private Label labelCondition;
        private GroupBox groupBoxInputData;
        private Label labelStartStep;
        private Label labelStopStep;
        private TextBox textBoxStartStep;
        private TextBox textBoxStopStep;
        private Button buttonHelp;
        private Button buttonDone;
        private GroupBox groupBoxOutputData;
        private DataGridView dataGridViewResult;
        private GroupBox groupBoxChart;
        private Chart chartFunction;

        DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            groupBoxCondition = new GroupBox();
            labelCondition = new Label();
            groupBoxInputData = new GroupBox();
            labelStartStep = new Label();
            labelStopStep = new Label();
            textBoxStartStep = new TextBox();
            textBoxStopStep = new TextBox();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBoxOutputData = new GroupBox();
            dataGridViewResult = new DataGridView();
            groupBoxChart = new GroupBox();
            chartFunction = new Chart();

            SuspendLayout();

            groupBoxCondition.Controls.Add(labelCondition);
            groupBoxCondition.Location = new Point(12, 12);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(960, 85);
            groupBoxCondition.Text = "Условие";

            labelCondition.Location = new Point(6, 19);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(948, 50);
            labelCondition.Text = "Протабулировать функцию sin(x) на заданном диапазоне. Результат вывести в виде таблицы.";

            groupBoxInputData.Controls.Add(labelStartStep);
            groupBoxInputData.Controls.Add(labelStopStep);
            groupBoxInputData.Controls.Add(textBoxStartStep);
            groupBoxInputData.Controls.Add(textBoxStopStep);
            groupBoxInputData.Controls.Add(buttonHelp);
            groupBoxInputData.Controls.Add(buttonDone);
            groupBoxInputData.Location = new Point(12, 103);
            groupBoxInputData.Name = "groupBoxInputData";
            groupBoxInputData.Size = new Size(230, 445);
            groupBoxInputData.Text = "Ввод данных";

            labelStartStep.AutoSize = true;
            labelStartStep.Location = new Point(6, 28);
            labelStartStep.Name = "labelStartStep";
            labelStartStep.Text = "Старт шага";

            textBoxStartStep.Location = new Point(9, 44);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(207, 20);

            labelStopStep.AutoSize = true;
            labelStopStep.Location = new Point(6, 77);
            labelStopStep.Name = "labelStopStep";
            labelStopStep.Text = "Конец шага";

            textBoxStopStep.Location = new Point(9, 93);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(207, 20);

            buttonHelp.Location = new Point(9, 402);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(100, 31);
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;

            buttonDone.Location = new Point(116, 402);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(100, 31);
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;

            groupBoxOutputData.Controls.Add(dataGridViewResult);
            groupBoxOutputData.Location = new Point(248, 103);
            groupBoxOutputData.Name = "groupBoxOutputData";
            groupBoxOutputData.Size = new Size(330, 445);
            groupBoxOutputData.Text = "Вывод данных";

            dataGridViewResult.AllowUserToAddRows = false;
            dataGridViewResult.AllowUserToDeleteRows = false;
            dataGridViewResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Location = new Point(6, 19);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.ReadOnly = true;
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.Size = new Size(318, 414);
            dataGridViewResult.Columns.Add("ColumnX", "x");
            dataGridViewResult.Columns.Add("ColumnSinX", "sin(x)");

            groupBoxChart.Controls.Add(chartFunction);
            groupBoxChart.Location = new Point(584, 103);
            groupBoxChart.Name = "groupBoxChart";
            groupBoxChart.Size = new Size(388, 445);
            groupBoxChart.Text = "График функции";

            ChartArea chartArea = new ChartArea("ChartArea");
            chartArea.AxisX.Title = "x";
            chartArea.AxisY.Title = "sin(x)";
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartFunction.ChartAreas.Add(chartArea);
            chartFunction.Location = new Point(6, 19);
            chartFunction.Name = "chartFunction";
            chartFunction.Size = new Size(376, 414);
            chartFunction.Series.Add(CreateFunctionSeries());

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(groupBoxChart);
            Controls.Add(groupBoxOutputData);
            Controls.Add(groupBoxInputData);
            Controls.Add(groupBoxCondition);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 0 | Зайцев М.С.";

            ResumeLayout(false);
        }

        private Series CreateFunctionSeries()
        {
            Series series = new Series("sin(x)");
            series.ChartType = SeriesChartType.Spline;
            series.BorderWidth = 3;
            series.Color = Color.RoyalBlue;
            return series;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep.Text);

                if (startStep > stopStep)
                {
                    MessageBox.Show("Старт шага должен быть меньше или равен концу шага", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double[] valueArray = ds.GetMassFunction(startStep, stopStep);

                dataGridViewResult.Rows.Clear();
                chartFunction.Series[0].Points.Clear();

                for (int i = 0; i < valueArray.Length; i++)
                {
                    int x = startStep + i;
                    dataGridViewResult.Rows.Add(x, valueArray[i]);
                    chartFunction.Series[0].Points.AddXY(x, valueArray[i]);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИБКСб-25-1 Зайцев Максим Сергеевич");
        }
    }
}
