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
            this.SuspendLayout();
            // 
            // btnListarExercicios
            // 
            this.btnListarExercicios.Location = new System.Drawing.Point(23, 305);
            this.btnListarExercicios.Name = "btnListarExercicios";
            this.btnListarExercicios.Size = new System.Drawing.Size(683, 48);
            this.btnListarExercicios.TabIndex = 0;
            this.btnListarExercicios.Text = "Listar Exercicios";
            this.btnListarExercicios.UseSelectable = true;
            // 
            // listaNomeExercicio
            // 
            this.listaNomeExercicio.FormattingEnabled = true;
            this.listaNomeExercicio.Location = new System.Drawing.Point(23, 111);
            this.listaNomeExercicio.Name = "listaNomeExercicio";
            this.listaNomeExercicio.Size = new System.Drawing.Size(330, 173);
            this.listaNomeExercicio.TabIndex = 1;
            // 
            // listaDescricaoExercicio
            // 
            this.listaDescricaoExercicio.FormattingEnabled = true;
            this.listaDescricaoExercicio.Location = new System.Drawing.Point(376, 111);
            this.listaDescricaoExercicio.Name = "listaDescricaoExercicio";
            this.listaDescricaoExercicio.Size = new System.Drawing.Size(330, 173);
            this.listaDescricaoExercicio.TabIndex = 2;
            // 
            // labelListaNomeExercicio
            // 
            this.labelListaNomeExercicio.AutoSize = true;
            this.labelListaNomeExercicio.Location = new System.Drawing.Point(23, 79);
            this.labelListaNomeExercicio.Name = "labelListaNomeExercicio";
            this.labelListaNomeExercicio.Size = new System.Drawing.Size(46, 19);
            this.labelListaNomeExercicio.TabIndex = 3;
            this.labelListaNomeExercicio.Text = "Nome";
            // 
            // labelListaDescricaoExercicio
            // 
            this.labelListaDescricaoExercicio.AutoSize = true;
            this.labelListaDescricaoExercicio.Location = new System.Drawing.Point(376, 79);
            this.labelListaDescricaoExercicio.Name = "labelListaDescricaoExercicio";
            this.labelListaDescricaoExercicio.Size = new System.Drawing.Size(65, 19);
            this.labelListaDescricaoExercicio.TabIndex = 4;
            this.labelListaDescricaoExercicio.Text = "Descrição";
            // 
            // ListarExercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 376);
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
    }
}