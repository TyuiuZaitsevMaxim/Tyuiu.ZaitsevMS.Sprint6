namespace Tyuiu.ZaitsevMS.Sprint6.Task7.V3
{
    partial class FormAbout
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
            this.labelInfo_ZMS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInfo_ZMS
            // 
            this.labelInfo_ZMS.AutoSize = true;
            this.labelInfo_ZMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelInfo_ZMS.Location = new System.Drawing.Point(12, 20);
            this.labelInfo_ZMS.Name = "labelInfo_ZMS";
            this.labelInfo_ZMS.Text = "Таск 7 выполнил студент группы ИБКСб-25-1 Зайцев Максим Сергеевич";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 80);
            this.Controls.Add(this.labelInfo_ZMS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справка";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelInfo_ZMS;
    }
}