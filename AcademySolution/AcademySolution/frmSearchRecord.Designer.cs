namespace AcademySolution
{
    partial class frmSearchFicha
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txbCodigo = new MetroFramework.Controls.MetroTextBox();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(38, 107);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Código :";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // txbCodigo
            // 
            // 
            // 
            // 
            this.txbCodigo.CustomButton.Image = null;
            this.txbCodigo.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txbCodigo.CustomButton.Name = "";
            this.txbCodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbCodigo.CustomButton.TabIndex = 1;
            this.txbCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbCodigo.CustomButton.UseSelectable = true;
            this.txbCodigo.CustomButton.Visible = false;
            this.txbCodigo.Lines = new string[0];
            this.txbCodigo.Location = new System.Drawing.Point(104, 107);
            this.txbCodigo.MaxLength = 32767;
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.PasswordChar = '\0';
            this.txbCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbCodigo.SelectedText = "";
            this.txbCodigo.SelectionLength = 0;
            this.txbCodigo.SelectionStart = 0;
            this.txbCodigo.ShortcutsEnabled = true;
            this.txbCodigo.Size = new System.Drawing.Size(164, 23);
            this.txbCodigo.TabIndex = 6;
            this.txbCodigo.UseSelectable = true;
            this.txbCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(38, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(158, 220);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(110, 23);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "Procurar";
            this.metroButton1.UseSelectable = true;
            // 
            // frmSearchFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 296);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmSearchFicha";
            this.Resizable = false;
            this.Text = "Procurar Ficha";
            this.Load += new System.EventHandler(this.frmSearchFicha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txbCodigo;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}