namespace Tyuiu.ZaitsevMS.Sprint6.Task1.V20
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tableLayoutPanelMain_ZMS = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTop_ZMS = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxCondition_ZMS = new System.Windows.Forms.GroupBox();
            this.labelCondition_ZMS = new System.Windows.Forms.Label();
            this.groupBoxInputData_ZMS = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelInput_ZMS = new System.Windows.Forms.TableLayoutPanel();
            this.labelStartStep_ZMS = new System.Windows.Forms.Label();
            this.textBoxStartStep_ZMS = new System.Windows.Forms.TextBox();
            this.labelStopStep_ZMS = new System.Windows.Forms.Label();
            this.textBoxStopStep_ZMS = new System.Windows.Forms.TextBox();
            this.buttonDone_ZMS = new System.Windows.Forms.Button();
            this.buttonHelp_ZMS = new System.Windows.Forms.Button();
            this.groupBoxOutputData_ZMS = new System.Windows.Forms.GroupBox();
            this.textBoxResult_ZMS = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelMain_ZMS.SuspendLayout();
            this.tableLayoutPanelTop_ZMS.SuspendLayout();
            this.groupBoxCondition_ZMS.SuspendLayout();
            this.groupBoxInputData_ZMS.SuspendLayout();
            this.tableLayoutPanelInput_ZMS.SuspendLayout();
            this.groupBoxOutputData_ZMS.SuspendLayout();
            this.SuspendLayout();

            // tableLayoutPanelMain_ZMS
            this.tableLayoutPanelMain_ZMS.ColumnCount = 1;
            this.tableLayoutPanelMain_ZMS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain_ZMS.Controls.Add(this.tableLayoutPanelTop_ZMS, 0, 0);
            this.tableLayoutPanelMain_ZMS.Controls.Add(this.groupBoxOutputData_ZMS, 0, 1);
            this.tableLayoutPanelMain_ZMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain_ZMS.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain_ZMS.Name = "tableLayoutPanelMain_ZMS";
            this.tableLayoutPanelMain_ZMS.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanelMain_ZMS.RowCount = 2;
            this.tableLayoutPanelMain_ZMS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanelMain_ZMS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain_ZMS.Size = new System.Drawing.Size(684, 561);
            this.tableLayoutPanelMain_ZMS.TabIndex = 0;

            // tableLayoutPanelTop_ZMS
            this.tableLayoutPanelTop_ZMS.ColumnCount = 4;
            this.tableLayoutPanelTop_ZMS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanelTop_ZMS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanelTop_ZMS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanelTop_ZMS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanelTop_ZMS.Controls.Add(this.groupBoxCondition_ZMS, 0, 0);
            this.tableLayoutPanelTop_ZMS.Controls.Add(this.groupBoxInputData_ZMS, 1, 0);
            this.tableLayoutPanelTop_ZMS.Controls.Add(this.buttonDone_ZMS, 2, 0);
            this.tableLayoutPanelTop_ZMS.Controls.Add(this.buttonHelp_ZMS, 3, 0);
            this.tableLayoutPanelTop_ZMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTop_ZMS.Location = new System.Drawing.Point(11, 11);
            this.tableLayoutPanelTop_ZMS.Name = "tableLayoutPanelTop_ZMS";
            this.tableLayoutPanelTop_ZMS.RowCount = 1;
            this.tableLayoutPanelTop_ZMS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop_ZMS.Size = new System.Drawing.Size(662, 126);
            this.tableLayoutPanelTop_ZMS.TabIndex = 0;

            // groupBoxCondition_ZMS
            this.groupBoxCondition_ZMS.Controls.Add(this.labelCondition_ZMS);
            this.groupBoxCondition_ZMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCondition_ZMS.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCondition_ZMS.Name = "groupBoxCondition_ZMS";
            this.groupBoxCondition_ZMS.Size = new System.Drawing.Size(285, 120);
            this.groupBoxCondition_ZMS.TabIndex = 0;
            this.groupBoxCondition_ZMS.TabStop = false;
            this.groupBoxCondition_ZMS.Text = "Условие";

            // labelCondition_ZMS
            this.labelCondition_ZMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCondition_ZMS.Location = new System.Drawing.Point(3, 16);
            this.labelCondition_ZMS.Name = "labelCondition_ZMS";
            this.labelCondition_ZMS.Padding = new System.Windows.Forms.Padding(4);
            this.labelCondition_ZMS.Size = new System.Drawing.Size(279, 101);
            this.labelCondition_ZMS.TabIndex = 0;
            this.labelCondition_ZMS.Text = "Табулирование F(x) = (2x-3)/(cos(x)-2x) + 5x - sin(x) на диапазоне [-5; 5] с шагом 1. Проверка деления на 0. Округление до 2 знаков.";

            // groupBoxInputData_ZMS
            this.groupBoxInputData_ZMS.Controls.Add(this.tableLayoutPanelInput_ZMS);
            this.groupBoxInputData_ZMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInputData_ZMS.Location = new System.Drawing.Point(294, 3);
            this.groupBoxInputData_ZMS.Name = "groupBoxInputData_ZMS";
            this.groupBoxInputData_ZMS.Size = new System.Drawing.Size(206, 120);
            this.groupBoxInputData_ZMS.TabIndex = 1;
            this.groupBoxInputData_ZMS.TabStop = false;
            this.groupBoxInputData_ZMS.Text = "Ввод данных";

            // tableLayoutPanelInput_ZMS
            this.tableLayoutPanelInput_ZMS.ColumnCount = 2;
            this.tableLayoutPanelInput_ZMS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInput_ZMS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInput_ZMS.Controls.Add(this.labelStartStep_ZMS, 0, 0);
            this.tableLayoutPanelInput_ZMS.Controls.Add(this.textBoxStartStep_ZMS, 0, 1);
            this.tableLayoutPanelInput_ZMS.Controls.Add(this.labelStopStep_ZMS, 1, 0);
            this.tableLayoutPanelInput_ZMS.Controls.Add(this.textBoxStopStep_ZMS, 1, 1);
            this.tableLayoutPanelInput_ZMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelInput_ZMS.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelInput_ZMS.Name = "tableLayoutPanelInput_ZMS";
            this.tableLayoutPanelInput_ZMS.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelInput_ZMS.RowCount = 2;
            this.tableLayoutPanelInput_ZMS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanelInput_ZMS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelInput_ZMS.Size = new System.Drawing.Size(200, 68);
            this.tableLayoutPanelInput_ZMS.TabIndex = 0;

            // labelStartStep_ZMS
            this.labelStartStep_ZMS.AutoSize = true;
            this.labelStartStep_ZMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStartStep_ZMS.Location = new System.Drawing.Point(7, 4);
            this.labelStartStep_ZMS.Name = "labelStartStep_ZMS";
            this.labelStartStep_ZMS.Size = new System.Drawing.Size(90, 28);
            this.labelStartStep_ZMS.TabIndex = 0;
            this.labelStartStep_ZMS.Text = "Старт шага";
            this.labelStartStep_ZMS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // textBoxStartStep_ZMS
            this.textBoxStartStep_ZMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxStartStep_ZMS.Location = new System.Drawing.Point(7, 35);
            this.textBoxStartStep_ZMS.Name = "textBoxStartStep_ZMS";
            this.textBoxStartStep_ZMS.ReadOnly = true;
            this.textBoxStartStep_ZMS.Size = new System.Drawing.Size(90, 20);
            this.textBoxStartStep_ZMS.TabIndex = 1;

            // labelStopStep_ZMS
            this.labelStopStep_ZMS.AutoSize = true;
            this.labelStopStep_ZMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStopStep_ZMS.Location = new System.Drawing.Point(104, 4);
            this.labelStopStep_ZMS.Name = "labelStopStep_ZMS";
            this.labelStopStep_ZMS.Size = new System.Drawing.Size(90, 28);
            this.labelStopStep_ZMS.TabIndex = 2;
            this.labelStopStep_ZMS.Text = "Конец шага";
            this.labelStopStep_ZMS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // textBoxStopStep_ZMS
            this.textBoxStopStep_ZMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxStopStep_ZMS.Location = new System.Drawing.Point(104, 35);
            this.textBoxStopStep_ZMS.Name = "textBoxStopStep_ZMS";
            this.textBoxStopStep_ZMS.ReadOnly = true;
            this.textBoxStopStep_ZMS.Size = new System.Drawing.Size(90, 20);
            this.textBoxStopStep_ZMS.TabIndex = 3;

            // buttonDone_ZMS
            this.buttonDone_ZMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDone_ZMS.Location = new System.Drawing.Point(506, 3);
            this.buttonDone_ZMS.Name = "buttonDone_ZMS";
            this.buttonDone_ZMS.Size = new System.Drawing.Size(104, 120);
            this.buttonDone_ZMS.TabIndex = 2;
            this.buttonDone_ZMS.Text = "Выполнить";
            this.buttonDone_ZMS.UseVisualStyleBackColor = true;
            this.buttonDone_ZMS.Click += new System.EventHandler(this.buttonDone_ZMS_Click);

            // buttonHelp_ZMS
            this.buttonHelp_ZMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHelp_ZMS.Location = new System.Drawing.Point(616, 3);
            this.buttonHelp_ZMS.Name = "buttonHelp_ZMS";
            this.buttonHelp_ZMS.Size = new System.Drawing.Size(104, 120);
            this.buttonHelp_ZMS.TabIndex = 3;
            this.buttonHelp_ZMS.Text = "Справка";
            this.buttonHelp_ZMS.UseVisualStyleBackColor = true;
            this.buttonHelp_ZMS.Click += new System.EventHandler(this.buttonHelp_ZMS_Click);

            // groupBoxOutputData_ZMS
            this.groupBoxOutputData_ZMS.Controls.Add(this.textBoxResult_ZMS);
            this.groupBoxOutputData_ZMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutputData_ZMS.Location = new System.Drawing.Point(11, 143);
            this.groupBoxOutputData_ZMS.Name = "groupBoxOutputData_ZMS";
            this.groupBoxOutputData_ZMS.Size = new System.Drawing.Size(662, 407);
            this.groupBoxOutputData_ZMS.TabIndex = 1;
            this.groupBoxOutputData_ZMS.TabStop = false;
            this.groupBoxOutputData_ZMS.Text = "Вывод";

            // textBoxResult_ZMS
            this.textBoxResult_ZMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_ZMS.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_ZMS.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_ZMS.Multiline = true;
            this.textBoxResult_ZMS.Name = "textBoxResult_ZMS";
            this.textBoxResult_ZMS.ReadOnly = true;
            this.textBoxResult_ZMS.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResult_ZMS.Size = new System.Drawing.Size(656, 388);
            this.textBoxResult_ZMS.TabIndex = 0;
            this.textBoxResult_ZMS.WordWrap = false;

            // FormMain
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.tableLayoutPanelMain_ZMS);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 20 | Зайцев М.С.";
            this.tableLayoutPanelMain_ZMS.ResumeLayout(false);
            this.tableLayoutPanelTop_ZMS.ResumeLayout(false);
            this.groupBoxCondition_ZMS.ResumeLayout(false);
            this.groupBoxInputData_ZMS.ResumeLayout(false);
            this.tableLayoutPanelInput_ZMS.ResumeLayout(false);
            this.tableLayoutPanelInput_ZMS.PerformLayout();
            this.groupBoxOutputData_ZMS.ResumeLayout(false);
            this.groupBoxOutputData_ZMS.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain_ZMS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop_ZMS;
        private System.Windows.Forms.GroupBox groupBoxCondition_ZMS;
        private System.Windows.Forms.Label labelCondition_ZMS;
        private System.Windows.Forms.GroupBox groupBoxInputData_ZMS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInput_ZMS;
        private System.Windows.Forms.Label labelStartStep_ZMS;
        private System.Windows.Forms.TextBox textBoxStartStep_ZMS;
        private System.Windows.Forms.Label labelStopStep_ZMS;
        private System.Windows.Forms.TextBox textBoxStopStep_ZMS;
        private System.Windows.Forms.Button buttonDone_ZMS;
        private System.Windows.Forms.Button buttonHelp_ZMS;
        private System.Windows.Forms.GroupBox groupBoxOutputData_ZMS;
        private System.Windows.Forms.TextBox textBoxResult_ZMS;
    }
}