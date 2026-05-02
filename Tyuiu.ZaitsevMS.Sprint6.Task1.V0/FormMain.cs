using System;
using System.Drawing;
using System.Windows.Forms;
using Tyuiu.ZaitsevMS.Sprint6.Task1.V0.Lib;

namespace Tyuiu.ZaitsevMS.Sprint6.Task1.V0
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
        private TextBox textBoxResult;

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
            textBoxResult = new TextBox();

            SuspendLayout();

            groupBoxCondition.Controls.Add(labelCondition);
            groupBoxCondition.Location = new Point(12, 12);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(776, 93);
            groupBoxCondition.Text = "Условие";

            labelCondition.Location = new Point(6, 19);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(764, 61);
            labelCondition.Text = "Протабулировать функцию sin(x) на заданном диапазоне. Результат вывести в виде таблицы.";

            groupBoxInputData.Controls.Add(labelStartStep);
            groupBoxInputData.Controls.Add(labelStopStep);
            groupBoxInputData.Controls.Add(textBoxStartStep);
            groupBoxInputData.Controls.Add(textBoxStopStep);
            groupBoxInputData.Controls.Add(buttonHelp);
            groupBoxInputData.Controls.Add(buttonDone);
            groupBoxInputData.Location = new Point(12, 111);
            groupBoxInputData.Name = "groupBoxInputData";
            groupBoxInputData.Size = new Size(245, 327);
            groupBoxInputData.Text = "Ввод данных";

            labelStartStep.AutoSize = true;
            labelStartStep.Location = new Point(6, 28);
            labelStartStep.Name = "labelStartStep";
            labelStartStep.Text = "Старт шага";

            textBoxStartStep.Location = new Point(9, 44);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(222, 20);

            labelStopStep.AutoSize = true;
            labelStopStep.Location = new Point(6, 74);
            labelStopStep.Name = "labelStopStep";
            labelStopStep.Text = "Конец шага";

            textBoxStopStep.Location = new Point(9, 90);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(222, 20);

            buttonHelp.Location = new Point(9, 284);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(108, 31);
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;

            buttonDone.Location = new Point(123, 284);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(108, 31);
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;

            groupBoxOutputData.Controls.Add(textBoxResult);
            groupBoxOutputData.Location = new Point(263, 111);
            groupBoxOutputData.Name = "groupBoxOutputData";
            groupBoxOutputData.Size = new Size(525, 327);
            groupBoxOutputData.Text = "Вывод данных";

            textBoxResult.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(6, 19);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(513, 296);

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxOutputData);
            Controls.Add(groupBoxInputData);
            Controls.Add(groupBoxCondition);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 0 | Зайцев М.С.";

            ResumeLayout(false);
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

                textBoxResult.Clear();
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult.AppendText("|    x     |  sin(x)  |" + Environment.NewLine);
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i < valueArray.Length; i++)
                {
                    string strLine = string.Format("|{0,5:d}     |   {1,5:f2}   |", startStep + i, valueArray[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);
                }

                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИБКСб-25-1 Зайцев Максим Сергеевич");
        }
    }
}
