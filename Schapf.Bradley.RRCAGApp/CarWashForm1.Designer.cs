namespace Schapf.Bradley.RRCAGApp
{
    partial class CarWashForm1
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
            this.SuspendLayout();
            // 
            // cboPackage
            // 
            this.cboPackage.Size = new System.Drawing.Size(149, 21);
            // 
            // cboFragrance
            // 
            this.cboFragrance.Size = new System.Drawing.Size(149, 21);
            // 
            // CarWashForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Name = "CarWashForm1";
            this.Text = "Car Wash";
            this.Load += new System.EventHandler(this.CarWashForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}