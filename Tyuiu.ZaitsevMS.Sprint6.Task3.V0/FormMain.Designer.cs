namespace Tyuiu.ZaitsevMS.Sprint6.Task3.V19
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
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.labelCondition = new System.Windows.Forms.Label();
            this.groupBoxMatrix = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.groupBoxOutputData = new System.Windows.Forms.GroupBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBoxCondition.SuspendLayout();
            this.groupBoxMatrix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            this.groupBoxOutputData.SuspendLayout();
            this.SuspendLayout();

            // groupBoxCondition
            this.groupBoxCondition.Controls.Add(this.labelCondition);
            this.groupBoxCondition.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(245, 426);
            this.groupBoxCondition.TabIndex = 0;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие";

            // labelCondition
            this.labelCondition.Location = new System.Drawing.Point(6, 19);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(233, 394);
            this.labelCondition.TabIndex = 0;
            this.labelCondition.Text = "Дан массив 5 на 5 элементов:\r\n\r\n" +
                "  4  32 -20  27  21\r\n" +
                " 17  15  -1  -2  -1\r\n" +
                " -3  18  12 -10  29\r\n" +
                "  7 -15   2  -8  12\r\n" +
                "-10  25   5  27  21\r\n\r\n" +
                "Выполнить сортировку по возрастанию в пятом столбце. Результат вывести в DataGridView.";

            // groupBoxMatrix
            this.groupBoxMatrix.Controls.Add(this.dataGridViewMatrix);
            this.groupBoxMatrix.Location = new System.Drawing.Point(263, 12);
            this.groupBoxMatrix.Name = "groupBoxMatrix";
            this.groupBoxMatrix.Size = new System.Drawing.Size(330, 426);
            this.groupBoxMatrix.TabIndex = 1;
            this.groupBoxMatrix.TabStop = false;
            this.groupBoxMatrix.Text = "Матрица";

            // dataGridViewMatrix
            this.dataGridViewMatrix.AllowUserToAddRows = false;
            this.dataGridViewMatrix.AllowUserToDeleteRows = false;
            this.dataGridViewMatrix.AllowUserToResizeColumns = false;
            this.dataGridViewMatrix.AllowUserToResizeRows = false;
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(15, 80);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.ReadOnly = true;
            this.dataGridViewMatrix.RowHeadersWidth = 50;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(300, 230);
            this.dataGridViewMatrix.TabIndex = 0;

            // groupBoxOutputData
            this.groupBoxOutputData.Controls.Add(this.buttonHelp);
            this.groupBoxOutputData.Controls.Add(this.buttonDone);
            this.groupBoxOutputData.Location = new System.Drawing.Point(599, 12);
            this.groupBoxOutputData.Name = "groupBoxOutputData";
            this.groupBoxOutputData.Size = new System.Drawing.Size(189, 426);
            this.groupBoxOutputData.TabIndex = 2;
            this.groupBoxOutputData.TabStop = false;
            this.groupBoxOutputData.Text = "Управление";

            // buttonDone
            this.buttonDone.Location = new System.Drawing.Point(9, 383);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(170, 31);
            this.buttonDone.TabIndex = 0;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);

            // buttonHelp
            this.buttonHelp.Location = new System.Drawing.Point(9, 346);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(170, 31);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);

            // FormMain
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxOutputData);
            this.Controls.Add(this.groupBoxMatrix);
            this.Controls.Add(this.groupBoxCondition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 19 | Зайцев М.С.";
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxMatrix.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            this.groupBoxOutputData.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.GroupBox groupBoxMatrix;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.GroupBox groupBoxOutputData;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonDone;
    }
}