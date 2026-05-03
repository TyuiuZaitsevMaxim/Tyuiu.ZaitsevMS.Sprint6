namespace Tyuiu.ZaitsevMS.Sprint6.Task6.V0
{
    partial class FormAbout
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
            this.labelInfo_ZMS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInfo_ZMS
            // 
            this.labelInfo_ZMS.AutoSize = true;
            this.labelInfo_ZMS.Location = new System.Drawing.Point(12, 9);
            this.labelInfo_ZMS.Name = "labelInfo_ZMS";
            this.labelInfo_ZMS.Size = new System.Drawing.Size(377, 13);
            this.labelInfo_ZMS.TabIndex = 0;
            this.labelInfo_ZMS.Text = "Таск 6 выполнил студент группы ИБКСб-25-1 Зайцев Максим Сергеевич";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 51);
            this.Controls.Add(this.labelInfo_ZMS);
            this.Name = "FormAbout";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_ZMS;
    }
}