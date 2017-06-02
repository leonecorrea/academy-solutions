namespace AcademySolution
{
    partial class frmExcluirFicha
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
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.txbCodFicha = new MetroFramework.Controls.MetroTextBox();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(67, 140);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(113, 19);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Código da Ficha :";
            // 
            // txbCodFicha
            // 
            // 
            // 
            // 
            this.txbCodFicha.CustomButton.Image = null;
            this.txbCodFicha.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txbCodFicha.CustomButton.Name = "";
            this.txbCodFicha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbCodFicha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbCodFicha.CustomButton.TabIndex = 1;
            this.txbCodFicha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbCodFicha.CustomButton.UseSelectable = true;
            this.txbCodFicha.CustomButton.Visible = false;
            this.txbCodFicha.Lines = new string[0];
            this.txbCodFicha.Location = new System.Drawing.Point(195, 140);
            this.txbCodFicha.MaxLength = 32767;
            this.txbCodFicha.Name = "txbCodFicha";
            this.txbCodFicha.PasswordChar = '\0';
            this.txbCodFicha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbCodFicha.SelectedText = "";
            this.txbCodFicha.SelectionLength = 0;
            this.txbCodFicha.SelectionStart = 0;
            this.txbCodFicha.ShortcutsEnabled = true;
            this.txbCodFicha.Size = new System.Drawing.Size(127, 23);
            this.txbCodFicha.TabIndex = 3;
            this.txbCodFicha.UseSelectable = true;
            this.txbCodFicha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbCodFicha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(307, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(166, 220);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 23);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseSelectable = true;
            this.btnExcluir.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // frmExcluirFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 291);
            this.ControlBox = false;
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txbCodFicha);
            this.Controls.Add(this.lblNome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmExcluirFicha";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Excluir Ficha";
            this.Load += new System.EventHandler(this.frmExcluirFicha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroTextBox txbCodFicha;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnExcluir;
    }
}