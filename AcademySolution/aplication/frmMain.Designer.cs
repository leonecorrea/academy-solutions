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
            System.Windows.Forms.ToolStripMenuItem mniInfoUser;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
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
            this.instructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInfoUser = new MetroFramework.Controls.MetroLabel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.mnsInfoUser = new System.Windows.Forms.MenuStrip();
            mniInfoUser = new System.Windows.Forms.ToolStripMenuItem();
            this.Menus.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.mnsInfoUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // mniInfoUser
            // 
            mniInfoUser.Name = "mniInfoUser";
            mniInfoUser.Size = new System.Drawing.Size(66, 20);
            mniInfoUser.Text = "Info User";
            mniInfoUser.Click += new System.EventHandler(this.mniInfoUser_Click);
            // 
            // Menus
            // 
            this.Menus.BackColor = System.Drawing.Color.White;
            this.Menus.Dock = System.Windows.Forms.DockStyle.None;
            this.Menus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.Menus.Location = new System.Drawing.Point(1, 30);
            this.Menus.Name = "Menus";
            this.Menus.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menus.Size = new System.Drawing.Size(333, 24);
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
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.cadastrosToolStripMenuItem.Text = "Registration";
            // 
            // smiRegisterStudent
            // 
            this.smiRegisterStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniRegisterStudent,
            this.editarCadastroToolStripMenuItem});
            this.smiRegisterStudent.Name = "smiRegisterStudent";
            this.smiRegisterStudent.Size = new System.Drawing.Size(125, 22);
            this.smiRegisterStudent.Text = "Students";
            // 
            // mniRegisterStudent
            // 
            this.mniRegisterStudent.Name = "mniRegisterStudent";
            this.mniRegisterStudent.Size = new System.Drawing.Size(123, 22);
            this.mniRegisterStudent.Text = "Add New";
            this.mniRegisterStudent.Click += new System.EventHandler(this.mniRegisterStudent_Click);
            // 
            // editarCadastroToolStripMenuItem
            // 
            this.editarCadastroToolStripMenuItem.Name = "editarCadastroToolStripMenuItem";
            this.editarCadastroToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.editarCadastroToolStripMenuItem.Text = "Edition";
            // 
            // cadastroDeProfessorToolStripMenuItem
            // 
            this.cadastroDeProfessorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarNovoCadastroToolStripMenuItem1,
            this.editarCadastroToolStripMenuItem1});
            this.cadastroDeProfessorToolStripMenuItem.Name = "cadastroDeProfessorToolStripMenuItem";
            this.cadastroDeProfessorToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.cadastroDeProfessorToolStripMenuItem.Text = "Instructor";
            // 
            // criarNovoCadastroToolStripMenuItem1
            // 
            this.criarNovoCadastroToolStripMenuItem1.Name = "criarNovoCadastroToolStripMenuItem1";
            this.criarNovoCadastroToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.criarNovoCadastroToolStripMenuItem1.Text = "Add New";
            // 
            // editarCadastroToolStripMenuItem1
            // 
            this.editarCadastroToolStripMenuItem1.Name = "editarCadastroToolStripMenuItem1";
            this.editarCadastroToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.editarCadastroToolStripMenuItem1.Text = "Edition";
            // 
            // cadastroDeFichaToolStripMenuItem
            // 
            this.cadastroDeFichaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarNovaFichaToolStripMenuItem,
            this.editarFichaToolStripMenuItem});
            this.cadastroDeFichaToolStripMenuItem.Name = "cadastroDeFichaToolStripMenuItem";
            this.cadastroDeFichaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.cadastroDeFichaToolStripMenuItem.Text = "Record";
            this.cadastroDeFichaToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFichaToolStripMenuItem_Click);
            // 
            // criarNovaFichaToolStripMenuItem
            // 
            this.criarNovaFichaToolStripMenuItem.Name = "criarNovaFichaToolStripMenuItem";
            this.criarNovaFichaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.criarNovaFichaToolStripMenuItem.Text = "Add New";
            this.criarNovaFichaToolStripMenuItem.Click += new System.EventHandler(this.criarNovaFichaToolStripMenuItem_Click);
            // 
            // editarFichaToolStripMenuItem
            // 
            this.editarFichaToolStripMenuItem.Name = "editarFichaToolStripMenuItem";
            this.editarFichaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.editarFichaToolStripMenuItem.Text = "Edition";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarFichaToolStripMenuItem,
            this.instructorToolStripMenuItem,
            this.recordToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.consultaToolStripMenuItem.Text = "Search";
            // 
            // consultarFichaToolStripMenuItem
            // 
            this.consultarFichaToolStripMenuItem.Name = "consultarFichaToolStripMenuItem";
            this.consultarFichaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarFichaToolStripMenuItem.Text = "Student";
            // 
            // instructorToolStripMenuItem
            // 
            this.instructorToolStripMenuItem.Name = "instructorToolStripMenuItem";
            this.instructorToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.instructorToolStripMenuItem.Text = "Instructor";
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.recordToolStripMenuItem.Text = "Record";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // lblInfoUser
            // 
            this.lblInfoUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoUser.AutoSize = true;
            this.lblInfoUser.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInfoUser.Location = new System.Drawing.Point(719, 5);
            this.lblInfoUser.Name = "lblInfoUser";
            this.lblInfoUser.Size = new System.Drawing.Size(68, 19);
            this.lblInfoUser.TabIndex = 3;
            this.lblInfoUser.Text = "Username";
            this.lblInfoUser.Click += new System.EventHandler(this.lblInfoUser_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblInfoUser);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(978, 518);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(10, 30);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(978, 518);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // mnsInfoUser
            // 
            this.mnsInfoUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mnsInfoUser.Dock = System.Windows.Forms.DockStyle.None;
            this.mnsInfoUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            mniInfoUser});
            this.mnsInfoUser.Location = new System.Drawing.Point(914, 30);
            this.mnsInfoUser.Name = "mnsInfoUser";
            this.mnsInfoUser.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnsInfoUser.Size = new System.Drawing.Size(74, 24);
            this.mnsInfoUser.TabIndex = 4;
            this.mnsInfoUser.Text = "menuStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(998, 558);
            this.Controls.Add(this.Menus);
            this.Controls.Add(this.mnsInfoUser);
            this.Controls.Add(this.toolStripContainer1);
            this.DisplayHeader = false;
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menus;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(10, 30, 10, 10);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Academy Solution";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Menus.ResumeLayout(false);
            this.Menus.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.mnsInfoUser.ResumeLayout(false);
            this.mnsInfoUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ToolStripMenuItem instructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnsInfoUser;
    }
}