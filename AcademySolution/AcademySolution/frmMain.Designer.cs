namespace AcademySolution
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lnkLogOut = new MetroFramework.Controls.MetroLink();
            this.lblInformation = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lnkLogOut
            // 
            this.lnkLogOut.Image = ((System.Drawing.Image)(resources.GetObject("lnkLogOut.Image")));
            this.lnkLogOut.ImageSize = 36;
            this.lnkLogOut.Location = new System.Drawing.Point(23, 16);
            this.lnkLogOut.Name = "lnkLogOut";
            this.lnkLogOut.Size = new System.Drawing.Size(36, 44);
            this.lnkLogOut.TabIndex = 0;
            this.lnkLogOut.UseSelectable = true;
            this.lnkLogOut.Click += new System.EventHandler(this.lnkLogOut_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(744, 30);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(105, 19);
            this.lblInformation.TabIndex = 1;
            this.lblInformation.Text = "Logado como: ?";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(928, 544);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.lnkLogOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 10);
            this.Text = "         Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnkLogOut;
        private MetroFramework.Controls.MetroLabel lblInformation;
    }
}