namespace Tyuiu.ZaitsevMS.Sprint6.Task3.V0
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.labelCondition = new System.Windows.Forms.Label();
            this.groupBoxMatrix = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.groupBoxOutputData = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBoxCondition.SuspendLayout();
            this.groupBoxMatrix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            this.groupBoxOutputData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.labelCondition);
            this.groupBoxCondition.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(245, 426);
            this.groupBoxCondition.TabIndex = 0;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие";
            // 
            // labelCondition
            // 
            this.labelCondition.Location = new System.Drawing.Point(6, 19);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(233, 394);
            this.labelCondition.TabIndex = 0;
            this.labelCondition.Text = "Дана матрица 3 на 3\r\n\r\n  0   1   2\r\n  3   0   5\r\n  3   4   5\r\n\r\nПодсчитать кол-" +
    "во нулей";
            // 
            // groupBoxMatrix
            // 
            this.groupBoxMatrix.Controls.Add(this.dataGridViewMatrix);
            this.groupBoxMatrix.Location = new System.Drawing.Point(263, 12);
            this.groupBoxMatrix.Name = "groupBoxMatrix";
            this.groupBoxMatrix.Size = new System.Drawing.Size(250, 426);
            this.groupBoxMatrix.TabIndex = 1;
            this.groupBoxMatrix.TabStop = false;
            this.groupBoxMatrix.Text = "Матрица";
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.AllowUserToAddRows = false;
            this.dataGridViewMatrix.AllowUserToDeleteRows = false;
            this.dataGridViewMatrix.AllowUserToResizeColumns = false;
            this.dataGridViewMatrix.AllowUserToResizeRows = false;
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(36, 126);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.ReadOnly = true;
            this.dataGridViewMatrix.RowHeadersWidth = 50;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(178, 152);
            this.dataGridViewMatrix.TabIndex = 0;
            // 
            // groupBoxOutputData
            // 
            this.groupBoxOutputData.Controls.Add(this.labelResult);
            this.groupBoxOutputData.Controls.Add(this.textBoxResult);
            this.groupBoxOutputData.Controls.Add(this.buttonHelp);
            this.groupBoxOutputData.Controls.Add(this.buttonDone);
            this.groupBoxOutputData.Location = new System.Drawing.Point(519, 12);
            this.groupBoxOutputData.Name = "groupBoxOutputData";
            this.groupBoxOutputData.Size = new System.Drawing.Size(269, 426);
            this.groupBoxOutputData.TabIndex = 2;
            this.groupBoxOutputData.TabStop = false;
            this.groupBoxOutputData.Text = "Вывод данных";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(6, 28);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(108, 13);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Количество нулей:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(9, 44);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(247, 20);
            this.textBoxResult.TabIndex = 1;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(9, 383);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(120, 31);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(136, 383);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(120, 31);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxOutputData);
            this.Controls.Add(this.groupBoxMatrix);
            this.Controls.Add(this.groupBoxCondition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 0 | Зайцев М.С.";
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxMatrix.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            this.groupBoxOutputData.ResumeLayout(false);
            this.groupBoxOutputData.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.GroupBox groupBoxMatrix;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.GroupBox groupBoxOutputData;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonDone;
    }
}

