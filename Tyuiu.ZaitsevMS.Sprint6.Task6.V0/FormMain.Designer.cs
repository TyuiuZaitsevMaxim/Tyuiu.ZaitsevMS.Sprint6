namespace Tyuiu.ZaitsevMS.Sprint6.Task6.V27
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
            this.buttonOpenFile_ZMS = new System.Windows.Forms.Button();
            this.buttonDone_ZMS = new System.Windows.Forms.Button();
            this.buttonHelp_ZMS = new System.Windows.Forms.Button();
            this.groupBoxCondition_ZMS = new System.Windows.Forms.GroupBox();
            this.labelCondition_ZMS = new System.Windows.Forms.Label();
            this.openFileDialogTask_ZMS = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxInput_ZMS = new System.Windows.Forms.GroupBox();
            this.textBoxIn_ZMS = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_ZMS = new System.Windows.Forms.GroupBox();
            this.textBoxOut_ZMS = new System.Windows.Forms.TextBox();
            this.groupBoxCondition_ZMS.SuspendLayout();
            this.groupBoxInput_ZMS.SuspendLayout();
            this.groupBoxOutput_ZMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFile_ZMS
            // 
            this.buttonOpenFile_ZMS.Location = new System.Drawing.Point(0, 0);
            this.buttonOpenFile_ZMS.Name = "buttonOpenFile_ZMS";
            this.buttonOpenFile_ZMS.Size = new System.Drawing.Size(100, 51);
            this.buttonOpenFile_ZMS.TabIndex = 0;
            this.buttonOpenFile_ZMS.Text = "Открыть файл";
            this.buttonOpenFile_ZMS.UseVisualStyleBackColor = true;
            this.buttonOpenFile_ZMS.Click += new System.EventHandler(this.buttonOpenFile_ZMS_Click);
            // 
            // buttonDone_ZMS
            // 
            this.buttonDone_ZMS.Enabled = false;
            this.buttonDone_ZMS.Location = new System.Drawing.Point(106, 0);
            this.buttonDone_ZMS.Name = "buttonDone_ZMS";
            this.buttonDone_ZMS.Size = new System.Drawing.Size(100, 51);
            this.buttonDone_ZMS.TabIndex = 1;
            this.buttonDone_ZMS.Text = "Выполнить";
            this.buttonDone_ZMS.UseVisualStyleBackColor = true;
            this.buttonDone_ZMS.Click += new System.EventHandler(this.buttonDone_ZMS_Click);
            // 
            // buttonHelp_ZMS
            // 
            this.buttonHelp_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_ZMS.Location = new System.Drawing.Point(700, 0);
            this.buttonHelp_ZMS.Name = "buttonHelp_ZMS";
            this.buttonHelp_ZMS.Size = new System.Drawing.Size(100, 51);
            this.buttonHelp_ZMS.TabIndex = 2;
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
            this.groupBoxCondition_ZMS.TabIndex = 3;
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
            this.labelCondition_ZMS.Text = "Дан файл InPutFileTask6V27.txt который может находится в любом месте на диске. Загрузить файл в textBoxIn через openFileDialog. Вывести слова в которых встречается H в результирующею строку и вывести ее в textBoxOut.";
            // 
            // openFileDialogTask_ZMS
            // 
            this.openFileDialogTask_ZMS.FileName = "";
            this.openFileDialogTask_ZMS.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // groupBoxInput_ZMS
            // 
            this.groupBoxInput_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInput_ZMS.Controls.Add(this.textBoxIn_ZMS);
            this.groupBoxInput_ZMS.Location = new System.Drawing.Point(0, 123);
            this.groupBoxInput_ZMS.Name = "groupBoxInput_ZMS";
            this.groupBoxInput_ZMS.Size = new System.Drawing.Size(397, 327);
            this.groupBoxInput_ZMS.TabIndex = 4;
            this.groupBoxInput_ZMS.TabStop = false;
            this.groupBoxInput_ZMS.Text = "Ввод:";
            // 
            // textBoxIn_ZMS
            // 
            this.textBoxIn_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIn_ZMS.Location = new System.Drawing.Point(6, 19);
            this.textBoxIn_ZMS.Multiline = true;
            this.textBoxIn_ZMS.Name = "textBoxIn_ZMS";
            this.textBoxIn_ZMS.ReadOnly = true;
            this.textBoxIn_ZMS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn_ZMS.Size = new System.Drawing.Size(385, 302);
            this.textBoxIn_ZMS.TabIndex = 0;
            // 
            // groupBoxOutput_ZMS
            // 
            this.groupBoxOutput_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutput_ZMS.Controls.Add(this.textBoxOut_ZMS);
            this.groupBoxOutput_ZMS.Location = new System.Drawing.Point(403, 123);
            this.groupBoxOutput_ZMS.Name = "groupBoxOutput_ZMS";
            this.groupBoxOutput_ZMS.Size = new System.Drawing.Size(397, 327);
            this.groupBoxOutput_ZMS.TabIndex = 5;
            this.groupBoxOutput_ZMS.TabStop = false;
            this.groupBoxOutput_ZMS.Text = "Вывод:";
            // 
            // textBoxOut_ZMS
            // 
            this.textBoxOut_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOut_ZMS.Location = new System.Drawing.Point(6, 19);
            this.textBoxOut_ZMS.Multiline = true;
            this.textBoxOut_ZMS.Name = "textBoxOut_ZMS";
            this.textBoxOut_ZMS.ReadOnly = true;
            this.textBoxOut_ZMS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut_ZMS.Size = new System.Drawing.Size(385, 302);
            this.textBoxOut_ZMS.TabIndex = 1;
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
            this.Controls.Add(this.buttonDone_ZMS);
            this.Controls.Add(this.buttonOpenFile_ZMS);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 27 | Зайцев М.С.";
            this.groupBoxCondition_ZMS.ResumeLayout(false);
            this.groupBoxInput_ZMS.ResumeLayout(false);
            this.groupBoxInput_ZMS.PerformLayout();
            this.groupBoxOutput_ZMS.ResumeLayout(false);
            this.groupBoxOutput_ZMS.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile_ZMS;
        private System.Windows.Forms.Button buttonDone_ZMS;
        private System.Windows.Forms.Button buttonHelp_ZMS;
        private System.Windows.Forms.GroupBox groupBoxCondition_ZMS;
        private System.Windows.Forms.Label labelCondition_ZMS;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_ZMS;
        private System.Windows.Forms.GroupBox groupBoxInput_ZMS;
        private System.Windows.Forms.TextBox textBoxIn_ZMS;
        private System.Windows.Forms.GroupBox groupBoxOutput_ZMS;
        private System.Windows.Forms.TextBox textBoxOut_ZMS;
    }
}