namespace AcademySolution.Forms
{
    partial class ListarExercicios
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
            this.btnListarExercicios = new MetroFramework.Controls.MetroButton();
            this.listaNomeExercicio = new System.Windows.Forms.ListBox();
            this.listaDescricaoExercicio = new System.Windows.Forms.ListBox();
            this.labelListaNomeExercicio = new MetroFramework.Controls.MetroLabel();
            this.labelListaDescricaoExercicio = new MetroFramework.Controls.MetroLabel();
            this.labelListaIdExercicio = new MetroFramework.Controls.MetroLabel();
            this.listaIdExercicio = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnListarExercicios
            // 
            this.btnListarExercicios.Location = new System.Drawing.Point(23, 302);
            this.btnListarExercicios.Name = "btnListarExercicios";
            this.btnListarExercicios.Size = new System.Drawing.Size(737, 48);
            this.btnListarExercicios.TabIndex = 0;
            this.btnListarExercicios.Text = "Listar Exercicios";
            this.btnListarExercicios.UseSelectable = true;
            this.btnListarExercicios.Click += new System.EventHandler(this.btnListarExercicios_Click);
            // 
            // listaNomeExercicio
            // 
            this.listaNomeExercicio.FormattingEnabled = true;
            this.listaNomeExercicio.Location = new System.Drawing.Point(77, 104);
            this.listaNomeExercicio.Name = "listaNomeExercicio";
            this.listaNomeExercicio.Size = new System.Drawing.Size(330, 173);
            this.listaNomeExercicio.TabIndex = 1;
            // 
            // listaDescricaoExercicio
            // 
            this.listaDescricaoExercicio.FormattingEnabled = true;
            this.listaDescricaoExercicio.Location = new System.Drawing.Point(430, 104);
            this.listaDescricaoExercicio.Name = "listaDescricaoExercicio";
            this.listaDescricaoExercicio.Size = new System.Drawing.Size(330, 173);
            this.listaDescricaoExercicio.TabIndex = 2;
            // 
            // labelListaNomeExercicio
            // 
            this.labelListaNomeExercicio.AutoSize = true;
            this.labelListaNomeExercicio.Location = new System.Drawing.Point(77, 72);
            this.labelListaNomeExercicio.Name = "labelListaNomeExercicio";
            this.labelListaNomeExercicio.Size = new System.Drawing.Size(46, 19);
            this.labelListaNomeExercicio.TabIndex = 3;
            this.labelListaNomeExercicio.Text = "Nome";
            // 
            // labelListaDescricaoExercicio
            // 
            this.labelListaDescricaoExercicio.AutoSize = true;
            this.labelListaDescricaoExercicio.Location = new System.Drawing.Point(430, 72);
            this.labelListaDescricaoExercicio.Name = "labelListaDescricaoExercicio";
            this.labelListaDescricaoExercicio.Size = new System.Drawing.Size(65, 19);
            this.labelListaDescricaoExercicio.TabIndex = 4;
            this.labelListaDescricaoExercicio.Text = "Descrição";
            // 
            // labelListaIdExercicio
            // 
            this.labelListaIdExercicio.AutoSize = true;
            this.labelListaIdExercicio.Location = new System.Drawing.Point(23, 72);
            this.labelListaIdExercicio.Name = "labelListaIdExercicio";
            this.labelListaIdExercicio.Size = new System.Drawing.Size(20, 19);
            this.labelListaIdExercicio.TabIndex = 5;
            this.labelListaIdExercicio.Text = "Id";
            // 
            // listaIdExercicio
            // 
            this.listaIdExercicio.FormattingEnabled = true;
            this.listaIdExercicio.Location = new System.Drawing.Point(23, 104);
            this.listaIdExercicio.Name = "listaIdExercicio";
            this.listaIdExercicio.Size = new System.Drawing.Size(36, 173);
            this.listaIdExercicio.TabIndex = 6;
            // 
            // ListarExercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 373);
            this.Controls.Add(this.listaIdExercicio);
            this.Controls.Add(this.labelListaIdExercicio);
            this.Controls.Add(this.labelListaDescricaoExercicio);
            this.Controls.Add(this.labelListaNomeExercicio);
            this.Controls.Add(this.listaDescricaoExercicio);
            this.Controls.Add(this.listaNomeExercicio);
            this.Controls.Add(this.btnListarExercicios);
            this.Name = "ListarExercicios";
            this.Text = "Listar Exercicios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnListarExercicios;
        private System.Windows.Forms.ListBox listaNomeExercicio;
        private System.Windows.Forms.ListBox listaDescricaoExercicio;
        private MetroFramework.Controls.MetroLabel labelListaNomeExercicio;
        private MetroFramework.Controls.MetroLabel labelListaDescricaoExercicio;
        private MetroFramework.Controls.MetroLabel labelListaIdExercicio;
        private System.Windows.Forms.ListBox listaIdExercicio;
    }
}