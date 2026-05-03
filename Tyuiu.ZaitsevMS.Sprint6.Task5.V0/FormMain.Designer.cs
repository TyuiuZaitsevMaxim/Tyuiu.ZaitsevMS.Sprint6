namespace Tyuiu.ZaitsevMS.Sprint6.Task5.V0
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea_ZMS = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series_ZMS = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanelMain_ZMS = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTop_ZMS = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxCondition_ZMS = new System.Windows.Forms.GroupBox();
            this.labelCondition_ZMS = new System.Windows.Forms.Label();
            this.buttonDone_ZMS = new System.Windows.Forms.Button();
            this.buttonOpenFile_ZMS = new System.Windows.Forms.Button();
            this.buttonHelp_ZMS = new System.Windows.Forms.Button();
            this.splitContainerData_ZMS = new System.Windows.Forms.SplitContainer();
            this.groupBoxOutputData_ZMS = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_ZMS = new System.Windows.Forms.DataGridView();
            this.ColumnNumber_ZMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValue_ZMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxChart_ZMS = new System.Windows.Forms.GroupBox();
            this.chartResult_ZMS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanelMain_ZMS.SuspendLayout();
            this.tableLayoutPanelTop_ZMS.SuspendLayout();
            this.groupBoxCondition_ZMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerData_ZMS)).BeginInit();
            this.splitContainerData_ZMS.Panel1.SuspendLayout();
            this.splitContainerData_ZMS.Panel2.SuspendLayout();
            this.splitContainerData_ZMS.SuspendLayout();
            this.groupBoxOutputData_ZMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_ZMS)).BeginInit();
            this.groupBoxChart_ZMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_ZMS)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain_ZMS
            // 
            this.tableLayoutPanelMain_ZMS.ColumnCount = 1;
            this.tableLayoutPanelMain_ZMS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain_ZMS.Controls.Add(this.tableLayoutPanelTop_ZMS, 0, 0);
            this.tableLayoutPanelMain_ZMS.Controls.Add(this.splitContainerData_ZMS, 0, 1);
            this.tableLayoutPanelMain_ZMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain_ZMS.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain_ZMS.Name = "tableLayoutPanelMain_ZMS";
            this.tableLayoutPanelMain_ZMS.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanelMain_ZMS.RowCount = 2;
            this.tableLayoutPanelMain_ZMS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelMain_ZMS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain_ZMS.Size = new System.Drawing.Size(984, 561);
            this.tableLayoutPanelMain_ZMS.TabIndex = 0;
            // 
            // tableLayoutPanelTop_ZMS
            // 
            this.tableLayoutPanelTop_ZMS.ColumnCount = 4;
            this.tableLayoutPanelTop_ZMS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop_ZMS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelTop_ZMS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelTop_ZMS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelTop_ZMS.Controls.Add(this.groupBoxCondition_ZMS, 0, 0);
            this.tableLayoutPanelTop_ZMS.Controls.Add(this.buttonDone_ZMS, 1, 0);
            this.tableLayoutPanelTop_ZMS.Controls.Add(this.buttonOpenFile_ZMS, 2, 0);
            this.tableLayoutPanelTop_ZMS.Controls.Add(this.buttonHelp_ZMS, 3, 0);
            this.tableLayoutPanelTop_ZMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTop_ZMS.Location = new System.Drawing.Point(11, 11);
            this.tableLayoutPanelTop_ZMS.Name = "tableLayoutPanelTop_ZMS";
            this.tableLayoutPanelTop_ZMS.RowCount = 1;
            this.tableLayoutPanelTop_ZMS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop_ZMS.Size = new System.Drawing.Size(962, 114);
            this.tableLayoutPanelTop_ZMS.TabIndex = 0;
            // 
            // groupBoxCondition_ZMS
            // 
            this.groupBoxCondition_ZMS.Controls.Add(this.labelCondition_ZMS);
            this.groupBoxCondition_ZMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCondition_ZMS.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCondition_ZMS.Name = "groupBoxCondition_ZMS";
            this.groupBoxCondition_ZMS.Size = new System.Drawing.Size(596, 108);
            this.groupBoxCondition_ZMS.TabIndex = 0;
            this.groupBoxCondition_ZMS.TabStop = false;
            this.groupBoxCondition_ZMS.Text = "Условие";
            // 
            // labelCondition_ZMS
            // 
            this.labelCondition_ZMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCondition_ZMS.Location = new System.Drawing.Point(3, 16);
            this.labelCondition_ZMS.Name = "labelCondition_ZMS";
            this.labelCondition_ZMS.Padding = new System.Windows.Forms.Padding(4);
            this.labelCondition_ZMS.Size = new System.Drawing.Size(590, 89);
            this.labelCondition_ZMS.TabIndex = 0;
            this.labelCondition_ZMS.Text = "Прочитать данные из файла InputFileTask5.txt. Вывести в dataGridView положительные значения и построить диаграмму по этим значениям.";
            // 
            // buttonDone_ZMS
            // 
            this.buttonDone_ZMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDone_ZMS.Location = new System.Drawing.Point(605, 3);
            this.buttonDone_ZMS.Name = "buttonDone_ZMS";
            this.buttonDone_ZMS.Size = new System.Drawing.Size(114, 108);
            this.buttonDone_ZMS.TabIndex = 1;
            this.buttonDone_ZMS.Text = "Выполнить";
            this.buttonDone_ZMS.UseVisualStyleBackColor = true;
            this.buttonDone_ZMS.Click += new System.EventHandler(this.buttonDone_ZMS_Click);
            // 
            // buttonOpenFile_ZMS
            // 
            this.buttonOpenFile_ZMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOpenFile_ZMS.Location = new System.Drawing.Point(725, 3);
            this.buttonOpenFile_ZMS.Name = "buttonOpenFile_ZMS";
            this.buttonOpenFile_ZMS.Size = new System.Drawing.Size(114, 108);
            this.buttonOpenFile_ZMS.TabIndex = 2;
            this.buttonOpenFile_ZMS.Text = "Открыть файл";
            this.buttonOpenFile_ZMS.UseVisualStyleBackColor = true;
            this.buttonOpenFile_ZMS.Click += new System.EventHandler(this.buttonOpenFile_ZMS_Click);
            // 
            // buttonHelp_ZMS
            // 
            this.buttonHelp_ZMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHelp_ZMS.Location = new System.Drawing.Point(845, 3);
            this.buttonHelp_ZMS.Name = "buttonHelp_ZMS";
            this.buttonHelp_ZMS.Size = new System.Drawing.Size(114, 108);
            this.buttonHelp_ZMS.TabIndex = 3;
            this.buttonHelp_ZMS.Text = "Справка";
            this.buttonHelp_ZMS.UseVisualStyleBackColor = true;
            this.buttonHelp_ZMS.Click += new System.EventHandler(this.buttonHelp_ZMS_Click);
            // 
            // splitContainerData_ZMS
            // 
            this.splitContainerData_ZMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerData_ZMS.Location = new System.Drawing.Point(11, 131);
            this.splitContainerData_ZMS.Name = "splitContainerData_ZMS";
            // 
            // splitContainerData_ZMS.Panel1
            // 
            this.splitContainerData_ZMS.Panel1.Controls.Add(this.groupBoxOutputData_ZMS);
            // 
            // splitContainerData_ZMS.Panel2
            // 
            this.splitContainerData_ZMS.Panel2.Controls.Add(this.groupBoxChart_ZMS);
            this.splitContainerData_ZMS.Size = new System.Drawing.Size(962, 419);
            this.splitContainerData_ZMS.SplitterDistance = 382;
            this.splitContainerData_ZMS.TabIndex = 1;
            // 
            // groupBoxOutputData_ZMS
            // 
            this.groupBoxOutputData_ZMS.Controls.Add(this.dataGridViewResult_ZMS);
            this.groupBoxOutputData_ZMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutputData_ZMS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutputData_ZMS.Name = "groupBoxOutputData_ZMS";
            this.groupBoxOutputData_ZMS.Size = new System.Drawing.Size(382, 419);
            this.groupBoxOutputData_ZMS.TabIndex = 0;
            this.groupBoxOutputData_ZMS.TabStop = false;
            this.groupBoxOutputData_ZMS.Text = "Вывод данных";
            // 
            // dataGridViewResult_ZMS
            // 
            this.dataGridViewResult_ZMS.AllowUserToAddRows = false;
            this.dataGridViewResult_ZMS.AllowUserToDeleteRows = false;
            this.dataGridViewResult_ZMS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult_ZMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_ZMS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber_ZMS,
            this.ColumnValue_ZMS});
            this.dataGridViewResult_ZMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_ZMS.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_ZMS.Name = "dataGridViewResult_ZMS";
            this.dataGridViewResult_ZMS.ReadOnly = true;
            this.dataGridViewResult_ZMS.RowHeadersVisible = false;
            this.dataGridViewResult_ZMS.Size = new System.Drawing.Size(376, 400);
            this.dataGridViewResult_ZMS.TabIndex = 0;
            // 
            // ColumnNumber_ZMS
            // 
            this.ColumnNumber_ZMS.HeaderText = "N";
            this.ColumnNumber_ZMS.Name = "ColumnNumber_ZMS";
            this.ColumnNumber_ZMS.ReadOnly = true;
            // 
            // ColumnValue_ZMS
            // 
            this.ColumnValue_ZMS.HeaderText = "Значение";
            this.ColumnValue_ZMS.Name = "ColumnValue_ZMS";
            this.ColumnValue_ZMS.ReadOnly = true;
            // 
            // groupBoxChart_ZMS
            // 
            this.groupBoxChart_ZMS.Controls.Add(this.chartResult_ZMS);
            this.groupBoxChart_ZMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxChart_ZMS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxChart_ZMS.Name = "groupBoxChart_ZMS";
            this.groupBoxChart_ZMS.Size = new System.Drawing.Size(576, 419);
            this.groupBoxChart_ZMS.TabIndex = 0;
            this.groupBoxChart_ZMS.TabStop = false;
            this.groupBoxChart_ZMS.Text = "Диаграмма";
            // 
            // chartResult_ZMS
            // 
            chartArea_ZMS.AxisX.Title = "N";
            chartArea_ZMS.AxisY.Title = "Значение";
            chartArea_ZMS.Name = "ChartArea_ZMS";
            this.chartResult_ZMS.ChartAreas.Add(chartArea_ZMS);
            this.chartResult_ZMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartResult_ZMS.Location = new System.Drawing.Point(3, 16);
            this.chartResult_ZMS.Name = "chartResult_ZMS";
            series_ZMS.ChartArea = "ChartArea_ZMS";
            series_ZMS.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series_ZMS.Name = "Положительные значения";
            this.chartResult_ZMS.Series.Add(series_ZMS);
            this.chartResult_ZMS.Size = new System.Drawing.Size(570, 400);
            this.chartResult_ZMS.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tableLayoutPanelMain_ZMS);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 0 | Зайцев М.С.";
            this.tableLayoutPanelMain_ZMS.ResumeLayout(false);
            this.tableLayoutPanelTop_ZMS.ResumeLayout(false);
            this.groupBoxCondition_ZMS.ResumeLayout(false);
            this.splitContainerData_ZMS.Panel1.ResumeLayout(false);
            this.splitContainerData_ZMS.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerData_ZMS)).EndInit();
            this.splitContainerData_ZMS.ResumeLayout(false);
            this.groupBoxOutputData_ZMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_ZMS)).EndInit();
            this.groupBoxChart_ZMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_ZMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain_ZMS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop_ZMS;
        private System.Windows.Forms.GroupBox groupBoxCondition_ZMS;
        private System.Windows.Forms.Label labelCondition_ZMS;
        private System.Windows.Forms.Button buttonDone_ZMS;
        private System.Windows.Forms.Button buttonOpenFile_ZMS;
        private System.Windows.Forms.Button buttonHelp_ZMS;
        private System.Windows.Forms.SplitContainer splitContainerData_ZMS;
        private System.Windows.Forms.GroupBox groupBoxOutputData_ZMS;
        private System.Windows.Forms.DataGridView dataGridViewResult_ZMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber_ZMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValue_ZMS;
        private System.Windows.Forms.GroupBox groupBoxChart_ZMS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_ZMS;
    }
}
