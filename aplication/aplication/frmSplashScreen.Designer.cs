namespace AcademySolution
{
    partial class frmSplashScreen
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new MetroFramework.Controls.MetroLabel();
            this.lblCountLoading = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.SteelBlue;
            this.progressBar1.Location = new System.Drawing.Point(-1, 543);
            this.progressBar1.MarqueeAnimationSpeed = 30;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(505, 10);
            this.progressBar1.Step = 2;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 20;
            this.progressBar1.Value = 100;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(62, 511);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(80, 19);
            this.lblLoading.TabIndex = 21;
            this.lblLoading.Text = "% Loading...";
            // 
            // lblCountLoading
            // 
            this.lblCountLoading.AutoSize = true;
            this.lblCountLoading.Location = new System.Drawing.Point(42, 511);
            this.lblCountLoading.Name = "lblCountLoading";
            this.lblCountLoading.Size = new System.Drawing.Size(14, 19);
            this.lblCountLoading.TabIndex = 22;
            this.lblCountLoading.Text = "1";
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 553);
            this.Controls.Add(this.lblCountLoading);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.progressBar1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Name = "frmSplashScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private MetroFramework.Controls.MetroLabel lblLoading;
        private MetroFramework.Controls.MetroLabel lblCountLoading;
    }
}