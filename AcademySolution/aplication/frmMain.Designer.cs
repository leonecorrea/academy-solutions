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
            this.Menus = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smiRegisterStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRegisterStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProfessorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarNovoCadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarNovaFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInfoUser = new MetroFramework.Controls.MetroLabel();
            this.Menus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkLogOut
            // 
            this.lnkLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkLogOut.Image = ((System.Drawing.Image)(resources.GetObject("lnkLogOut.Image")));
            this.lnkLogOut.ImageSize = 36;
            this.lnkLogOut.Location = new System.Drawing.Point(10, 504);
            this.lnkLogOut.Name = "lnkLogOut";
            this.lnkLogOut.Size = new System.Drawing.Size(36, 44);
            this.lnkLogOut.TabIndex = 0;
            this.lnkLogOut.UseSelectable = true;
            this.lnkLogOut.Click += new System.EventHandler(this.lnkLogOut_Click);
            // 
            // Menus
            // 
            this.Menus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.Menus.Location = new System.Drawing.Point(10, 30);
            this.Menus.Name = "Menus";
            this.Menus.Size = new System.Drawing.Size(978, 24);
            this.Menus.TabIndex = 1;
            this.Menus.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiRegisterStudent,
            this.cadastroDeProfessorToolStripMenuItem,
            this.cadastroDeFichaToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // smiRegisterStudent
            // 
            this.smiRegisterStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniRegisterStudent,
            this.editarCadastroToolStripMenuItem});
            this.smiRegisterStudent.Name = "smiRegisterStudent";
            this.smiRegisterStudent.Size = new System.Drawing.Size(189, 22);
            this.smiRegisterStudent.Text = "Cadastro de Alunos";
            // 
            // mniRegisterStudent
            // 
            this.mniRegisterStudent.Name = "mniRegisterStudent";
            this.mniRegisterStudent.Size = new System.Drawing.Size(181, 22);
            this.mniRegisterStudent.Text = "Criar Novo Cadastro";
            this.mniRegisterStudent.Click += new System.EventHandler(this.mniRegisterStudent_Click);
            // 
            // editarCadastroToolStripMenuItem
            // 
            this.editarCadastroToolStripMenuItem.Name = "editarCadastroToolStripMenuItem";
            this.editarCadastroToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.editarCadastroToolStripMenuItem.Text = "Editar Cadastro";
            // 
            // cadastroDeProfessorToolStripMenuItem
            // 
            this.cadastroDeProfessorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarNovoCadastroToolStripMenuItem1,
            this.editarCadastroToolStripMenuItem1});
            this.cadastroDeProfessorToolStripMenuItem.Name = "cadastroDeProfessorToolStripMenuItem";
            this.cadastroDeProfessorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cadastroDeProfessorToolStripMenuItem.Text = "Cadastro de Professor";
            // 
            // criarNovoCadastroToolStripMenuItem1
            // 
            this.criarNovoCadastroToolStripMenuItem1.Name = "criarNovoCadastroToolStripMenuItem1";
            this.criarNovoCadastroToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.criarNovoCadastroToolStripMenuItem1.Text = "Criar Novo Cadastro";
            // 
            // editarCadastroToolStripMenuItem1
            // 
            this.editarCadastroToolStripMenuItem1.Name = "editarCadastroToolStripMenuItem1";
            this.editarCadastroToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.editarCadastroToolStripMenuItem1.Text = "Editar Cadastro";
            // 
            // cadastroDeFichaToolStripMenuItem
            // 
            this.cadastroDeFichaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarNovaFichaToolStripMenuItem,
            this.editarFichaToolStripMenuItem});
            this.cadastroDeFichaToolStripMenuItem.Name = "cadastroDeFichaToolStripMenuItem";
            this.cadastroDeFichaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cadastroDeFichaToolStripMenuItem.Text = "Cadastro de Ficha";
            this.cadastroDeFichaToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFichaToolStripMenuItem_Click);
            // 
            // criarNovaFichaToolStripMenuItem
            // 
            this.criarNovaFichaToolStripMenuItem.Name = "criarNovaFichaToolStripMenuItem";
            this.criarNovaFichaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.criarNovaFichaToolStripMenuItem.Text = "Criar nova ficha";
            // 
            // editarFichaToolStripMenuItem
            // 
            this.editarFichaToolStripMenuItem.Name = "editarFichaToolStripMenuItem";
            this.editarFichaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.editarFichaToolStripMenuItem.Text = "Editar Ficha";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarFichaToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // consultarFichaToolStripMenuItem
            // 
            this.consultarFichaToolStripMenuItem.Name = "consultarFichaToolStripMenuItem";
            this.consultarFichaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.consultarFichaToolStripMenuItem.Text = "Consultar Fichas";
            // 
            // lblInfoUser
            // 
            this.lblInfoUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoUser.AutoSize = true;
            this.lblInfoUser.Location = new System.Drawing.Point(894, 35);
            this.lblInfoUser.Name = "lblInfoUser";
            this.lblInfoUser.Size = new System.Drawing.Size(68, 19);
            this.lblInfoUser.TabIndex = 3;
            this.lblInfoUser.Text = "Username";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(998, 558);
            this.Controls.Add(this.lblInfoUser);
            this.Controls.Add(this.lnkLogOut);
            this.Controls.Add(this.Menus);
            this.DisplayHeader = false;
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menus;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(10, 30, 10, 10);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Menus.ResumeLayout(false);
            this.Menus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnkLogOut;
        private System.Windows.Forms.MenuStrip Menus;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smiRegisterStudent;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProfessorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarFichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniRegisterStudent;
        private System.Windows.Forms.ToolStripMenuItem editarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarNovoCadastroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarCadastroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem criarNovaFichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarFichaToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel lblInfoUser;
    }
}