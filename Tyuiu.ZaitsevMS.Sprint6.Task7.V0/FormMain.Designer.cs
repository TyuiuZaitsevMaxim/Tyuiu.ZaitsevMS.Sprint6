namespace Tyuiu.ZaitsevMS.Sprint6.Task7.V3
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.buttonOpenFile_ZMS = new System.Windows.Forms.Button();
            this.buttonDone_ZMS = new System.Windows.Forms.Button();
            this.buttonSave_ZMS = new System.Windows.Forms.Button();
            this.buttonHelp_ZMS = new System.Windows.Forms.Button();
            this.groupBoxCondition_ZMS = new System.Windows.Forms.GroupBox();
            this.labelCondition_ZMS = new System.Windows.Forms.Label();
            this.groupBoxInput_ZMS = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_ZMS = new System.Windows.Forms.DataGridView();
            this.groupBoxOutput_ZMS = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_ZMS = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_ZMS = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogTask_ZMS = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxCondition_ZMS.SuspendLayout();
            this.groupBoxInput_ZMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_ZMS)).BeginInit();
            this.groupBoxOutput_ZMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_ZMS)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenFile_ZMS
            // 
            this.buttonOpenFile_ZMS.Location = new System.Drawing.Point(0, 0);
            this.buttonOpenFile_ZMS.Name = "buttonOpenFile_ZMS";
            this.buttonOpenFile_ZMS.Size = new System.Drawing.Size(110, 51);
            this.buttonOpenFile_ZMS.TabIndex = 0;
            this.buttonOpenFile_ZMS.Text = "Открыть файл";
            this.buttonOpenFile_ZMS.UseVisualStyleBackColor = true;
            this.buttonOpenFile_ZMS.Click += new System.EventHandler(this.buttonOpenFile_ZMS_Click);
            // 
            // buttonDone_ZMS
            // 
            this.buttonDone_ZMS.Location = new System.Drawing.Point(116, 0);
            this.buttonDone_ZMS.Name = "buttonDone_ZMS";
            this.buttonDone_ZMS.Size = new System.Drawing.Size(110, 51);
            this.buttonDone_ZMS.TabIndex = 1;
            this.buttonDone_ZMS.Text = "Выполнить";
            this.buttonDone_ZMS.UseVisualStyleBackColor = true;
            this.buttonDone_ZMS.Click += new System.EventHandler(this.buttonDone_ZMS_Click);
            // 
            // buttonSave_ZMS
            // 
            this.buttonSave_ZMS.Location = new System.Drawing.Point(232, 0);
            this.buttonSave_ZMS.Name = "buttonSave_ZMS";
            this.buttonSave_ZMS.Size = new System.Drawing.Size(110, 51);
            this.buttonSave_ZMS.TabIndex = 2;
            this.buttonSave_ZMS.Text = "Сохранить";
            this.buttonSave_ZMS.UseVisualStyleBackColor = true;
            this.buttonSave_ZMS.Click += new System.EventHandler(this.buttonSave_ZMS_Click);
            // 
            // buttonHelp_ZMS
            // 
            this.buttonHelp_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_ZMS.Location = new System.Drawing.Point(690, 0);
            this.buttonHelp_ZMS.Name = "buttonHelp_ZMS";
            this.buttonHelp_ZMS.Size = new System.Drawing.Size(110, 51);
            this.buttonHelp_ZMS.TabIndex = 3;
            this.buttonHelp_ZMS.Text = "Справка";
            this.buttonHelp_ZMS.UseVisualStyleBackColor = true;
            this.buttonHelp_ZMS.Click += new System.EventHandler(this.buttonHelp_ZMS_Click);
            // 
            // groupBoxCondition_ZMS
            // 
            this.groupBoxCondition_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCondition_ZMS.Controls.Add(this.labelCondition_ZMS);
            this.groupBoxCondition_ZMS.Location = new System.Drawing.Point(0, 57);
            this.groupBoxCondition_ZMS.Name = "groupBoxCondition_ZMS";
            this.groupBoxCondition_ZMS.Size = new System.Drawing.Size(800, 60);
            this.groupBoxCondition_ZMS.TabIndex = 4;
            this.groupBoxCondition_ZMS.TabStop = false;
            this.groupBoxCondition_ZMS.Text = "Условие:";
            // 
            // labelCondition_ZMS
            // 
            this.labelCondition_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCondition_ZMS.Location = new System.Drawing.Point(6, 18);
            this.labelCondition_ZMS.Name = "labelCondition_ZMS";
            this.labelCondition_ZMS.Size = new System.Drawing.Size(788, 36);
            this.labelCondition_ZMS.TabIndex = 0;
            this.labelCondition_ZMS.Text = "Дан файл InPutFileTask7V3.csv с матрицей целочисленных значений. Загрузить файл через openFileDialog в dataGridViewIn. Изменить в первом столбце чётные значения на -1. Результат вывести в dataGridViewOut. Сохранить в OutPutFileTask7.csv через saveFileDialog.";
            // 
            // groupBoxInput_ZMS
            // 
            this.groupBoxInput_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInput_ZMS.Controls.Add(this.dataGridViewIn_ZMS);
            this.groupBoxInput_ZMS.Location = new System.Drawing.Point(0, 123);
            this.groupBoxInput_ZMS.Name = "groupBoxInput_ZMS";
            this.groupBoxInput_ZMS.Size = new System.Drawing.Size(397, 327);
            this.groupBoxInput_ZMS.TabIndex = 5;
            this.groupBoxInput_ZMS.TabStop = false;
            this.groupBoxInput_ZMS.Text = "Ввод:";
            // 
            // dataGridViewIn_ZMS
            // 
            this.dataGridViewIn_ZMS.AllowUserToAddRows = false;
            this.dataGridViewIn_ZMS.AllowUserToDeleteRows = false;
            this.dataGridViewIn_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewIn_ZMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_ZMS.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewIn_ZMS.Name = "dataGridViewIn_ZMS";
            this.dataGridViewIn_ZMS.ReadOnly = true;
            this.dataGridViewIn_ZMS.Size = new System.Drawing.Size(385, 302);
            this.dataGridViewIn_ZMS.TabIndex = 0;
            // 
            // groupBoxOutput_ZMS
            // 
            this.groupBoxOutput_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutput_ZMS.Controls.Add(this.dataGridViewOut_ZMS);
            this.groupBoxOutput_ZMS.Location = new System.Drawing.Point(403, 123);
            this.groupBoxOutput_ZMS.Name = "groupBoxOutput_ZMS";
            this.groupBoxOutput_ZMS.Size = new System.Drawing.Size(397, 327);
            this.groupBoxOutput_ZMS.TabIndex = 6;
            this.groupBoxOutput_ZMS.TabStop = false;
            this.groupBoxOutput_ZMS.Text = "Вывод:";
            // 
            // dataGridViewOut_ZMS
            // 
            this.dataGridViewOut_ZMS.AllowUserToAddRows = false;
            this.dataGridViewOut_ZMS.AllowUserToDeleteRows = false;
            this.dataGridViewOut_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOut_ZMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_ZMS.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewOut_ZMS.Name = "dataGridViewOut_ZMS";
            this.dataGridViewOut_ZMS.ReadOnly = true;
            this.dataGridViewOut_ZMS.Size = new System.Drawing.Size(385, 302);
            this.dataGridViewOut_ZMS.TabIndex = 1;
            // 
            // openFileDialogTask_ZMS
            // 
            this.openFileDialogTask_ZMS.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            // 
            // saveFileDialogTask_ZMS
            // 
            this.saveFileDialogTask_ZMS.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            this.saveFileDialogTask_ZMS.FileName = "OutPutFileTask7.csv";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxOutput_ZMS);
            this.Controls.Add(this.groupBoxInput_ZMS);
            this.Controls.Add(this.groupBoxCondition_ZMS);
            this.Controls.Add(this.buttonHelp_ZMS);
            this.Controls.Add(this.buttonSave_ZMS);
            this.Controls.Add(this.buttonDone_ZMS);
            this.Controls.Add(this.buttonOpenFile_ZMS);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 7 | Вариант 3 | Зайцев М.С.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxCondition_ZMS.ResumeLayout(false);
            this.groupBoxInput_ZMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_ZMS)).EndInit();
            this.groupBoxOutput_ZMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_ZMS)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile_ZMS;
        private System.Windows.Forms.Button buttonDone_ZMS;
        private System.Windows.Forms.Button buttonSave_ZMS;
        private System.Windows.Forms.Button buttonHelp_ZMS;
        private System.Windows.Forms.GroupBox groupBoxCondition_ZMS;
        private System.Windows.Forms.Label labelCondition_ZMS;
        private System.Windows.Forms.GroupBox groupBoxInput_ZMS;
        private System.Windows.Forms.DataGridView dataGridViewIn_ZMS;
        private System.Windows.Forms.GroupBox groupBoxOutput_ZMS;
        private System.Windows.Forms.DataGridView dataGridViewOut_ZMS;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_ZMS;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTask_ZMS;
    }
}