namespace AcademySolution.Forms
{
    partial class ExcluirExercicio
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
            this.btnExcluirExercicio = new MetroFramework.Controls.MetroButton();
            this.txbCancelarExcluirExercicio = new MetroFramework.Controls.MetroButton();
            this.txbIdExcluirExercicio = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(139, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Codigo do Exercicio : ";
            // 
            // btnExcluirExercicio
            // 
            this.btnExcluirExercicio.Location = new System.Drawing.Point(87, 184);
            this.btnExcluirExercicio.Name = "btnExcluirExercicio";
            this.btnExcluirExercicio.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirExercicio.TabIndex = 1;
            this.btnExcluirExercicio.Text = "Excluir";
            this.btnExcluirExercicio.UseSelectable = true;
            this.btnExcluirExercicio.Click += new System.EventHandler(this.btnExcluirExercicio_Click);
            // 
            // txbCancelarExcluirExercicio
            // 
            this.txbCancelarExcluirExercicio.Location = new System.Drawing.Point(240, 184);
            this.txbCancelarExcluirExercicio.Name = "txbCancelarExcluirExercicio";
            this.txbCancelarExcluirExercicio.Size = new System.Drawing.Size(75, 23);
            this.txbCancelarExcluirExercicio.TabIndex = 2;
            this.txbCancelarExcluirExercicio.Text = "Cancelar";
            this.txbCancelarExcluirExercicio.UseSelectable = true;
            this.txbCancelarExcluirExercicio.Click += new System.EventHandler(this.txbCancelarExcluirExercicio_Click);
            // 
            // txbIdExcluirExercicio
            // 
            // 
            // 
            // 
            this.txbIdExcluirExercicio.CustomButton.Image = null;
            this.txbIdExcluirExercicio.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txbIdExcluirExercicio.CustomButton.Name = "";
            this.txbIdExcluirExercicio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbIdExcluirExercicio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbIdExcluirExercicio.CustomButton.TabIndex = 1;
            this.txbIdExcluirExercicio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbIdExcluirExercicio.CustomButton.UseSelectable = true;
            this.txbIdExcluirExercicio.CustomButton.Visible = false;
            this.txbIdExcluirExercicio.Lines = new string[0];
            this.txbIdExcluirExercicio.Location = new System.Drawing.Point(168, 84);
            this.txbIdExcluirExercicio.MaxLength = 32767;
            this.txbIdExcluirExercicio.Name = "txbIdExcluirExercicio";
            this.txbIdExcluirExercicio.PasswordChar = '\0';
            this.txbIdExcluirExercicio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbIdExcluirExercicio.SelectedText = "";
            this.txbIdExcluirExercicio.SelectionLength = 0;
            this.txbIdExcluirExercicio.SelectionStart = 0;
            this.txbIdExcluirExercicio.ShortcutsEnabled = true;
            this.txbIdExcluirExercicio.Size = new System.Drawing.Size(147, 23);
            this.txbIdExcluirExercicio.TabIndex = 3;
            this.txbIdExcluirExercicio.UseSelectable = true;
            this.txbIdExcluirExercicio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbIdExcluirExercicio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ExcluirExercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 230);
            this.Controls.Add(this.txbIdExcluirExercicio);
            this.Controls.Add(this.txbCancelarExcluirExercicio);
            this.Controls.Add(this.btnExcluirExercicio);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ExcluirExercicio";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Excluir  Exercicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnExcluirExercicio;
        private MetroFramework.Controls.MetroButton txbCancelarExcluirExercicio;
        private MetroFramework.Controls.MetroTextBox txbIdExcluirExercicio;
    }
}