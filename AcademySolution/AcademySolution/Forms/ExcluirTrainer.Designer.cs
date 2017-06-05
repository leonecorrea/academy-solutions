namespace AcademySolution.Forms
{
    partial class frmExcluirTrainer
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
            this.txbCodTrainer = new MetroFramework.Controls.MetroTextBox();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(83, 130);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(123, 19);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Código do Trainer :";
            // 
            // txbCodTrainer
            // 
            // 
            // 
            // 
            this.txbCodTrainer.CustomButton.Image = null;
            this.txbCodTrainer.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txbCodTrainer.CustomButton.Name = "";
            this.txbCodTrainer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbCodTrainer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbCodTrainer.CustomButton.TabIndex = 1;
            this.txbCodTrainer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbCodTrainer.CustomButton.UseSelectable = true;
            this.txbCodTrainer.CustomButton.Visible = false;
            this.txbCodTrainer.Lines = new string[0];
            this.txbCodTrainer.Location = new System.Drawing.Point(212, 130);
            this.txbCodTrainer.MaxLength = 32767;
            this.txbCodTrainer.Name = "txbCodTrainer";
            this.txbCodTrainer.PasswordChar = '\0';
            this.txbCodTrainer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbCodTrainer.SelectedText = "";
            this.txbCodTrainer.SelectionLength = 0;
            this.txbCodTrainer.SelectionStart = 0;
            this.txbCodTrainer.ShortcutsEnabled = true;
            this.txbCodTrainer.Size = new System.Drawing.Size(127, 23);
            this.txbCodTrainer.TabIndex = 5;
            this.txbCodTrainer.UseSelectable = true;
            this.txbCodTrainer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbCodTrainer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(189, 213);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 23);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseSelectable = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(324, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmExcluirTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 286);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txbCodTrainer);
            this.Controls.Add(this.lblNome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmExcluirTrainer";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Excluir Trainer";
            this.Load += new System.EventHandler(this.frmExcluirTrainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroTextBox txbCodTrainer;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroButton btnCancel;
    }
}