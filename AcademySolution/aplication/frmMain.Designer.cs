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
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            this.mniRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.smiAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.mniView = new System.Windows.Forms.ToolStripMenuItem();
            this.mniViewStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.mniViewTrainers = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mniProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInfoUser = new MetroFramework.Controls.MetroLabel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.lblLogo = new MetroFramework.Controls.MetroLabel();
            this.pcbIcon = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mnPrincipal.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnPrincipal
            // 
            this.mnPrincipal.BackColor = System.Drawing.Color.White;
            this.mnPrincipal.Dock = System.Windows.Forms.DockStyle.None;
            this.mnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniRegistration,
            this.mniView,
            this.mniSearch,
            this.mniProfile,
            this.mniHelp});
            this.mnPrincipal.Location = new System.Drawing.Point(10, 40);
            this.mnPrincipal.Name = "mnPrincipal";
            this.mnPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnPrincipal.Size = new System.Drawing.Size(285, 24);
            this.mnPrincipal.TabIndex = 1;
            this.mnPrincipal.Text = "menuStrip1";
            // 
            // mniRegistration
            // 
            this.mniRegistration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiAddNew});
            this.mniRegistration.Name = "mniRegistration";
            this.mniRegistration.Size = new System.Drawing.Size(82, 20);
            this.mniRegistration.Text = "Registration";
            // 
            // smiAddNew
            // 
            this.smiAddNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniAccount,
            this.mniRecord});
            this.smiAddNew.Name = "smiAddNew";
            this.smiAddNew.Size = new System.Drawing.Size(152, 22);
            this.smiAddNew.Text = "Add New";
            this.smiAddNew.Click += new System.EventHandler(this.smiAddNew_Click);
            // 
            // mniAccount
            // 
            this.mniAccount.Name = "mniAccount";
            this.mniAccount.Size = new System.Drawing.Size(152, 22);
            this.mniAccount.Text = "Account";
            this.mniAccount.Click += new System.EventHandler(this.mniAccount_Click);
            // 
            // mniRecord
            // 
            this.mniRecord.Name = "mniRecord";
            this.mniRecord.Size = new System.Drawing.Size(152, 22);
            this.mniRecord.Text = "Record";
            this.mniRecord.Click += new System.EventHandler(this.mniRecord_Click);
            // 
            // mniView
            // 
            this.mniView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniViewStudents,
            this.mniViewTrainers});
            this.mniView.Name = "mniView";
            this.mniView.Size = new System.Drawing.Size(44, 20);
            this.mniView.Text = "View";
            // 
            // mniViewStudents
            // 
            this.mniViewStudents.Name = "mniViewStudents";
            this.mniViewStudents.Size = new System.Drawing.Size(152, 22);
            this.mniViewStudents.Text = "Students";
            // 
            // mniViewTrainers
            // 
            this.mniViewTrainers.Name = "mniViewTrainers";
            this.mniViewTrainers.Size = new System.Drawing.Size(152, 22);
            this.mniViewTrainers.Text = "Trainers";
            // 
            // mniSearch
            // 
            this.mniSearch.Name = "mniSearch";
            this.mniSearch.Size = new System.Drawing.Size(54, 20);
            this.mniSearch.Text = "Search";
            // 
            // mniProfile
            // 
            this.mniProfile.Name = "mniProfile";
            this.mniProfile.Size = new System.Drawing.Size(53, 20);
            this.mniProfile.Text = "Profile";
            // 
            // mniHelp
            // 
            this.mniHelp.Name = "mniHelp";
            this.mniHelp.Size = new System.Drawing.Size(44, 20);
            this.mniHelp.Text = "Help";
            // 
            // lblInfoUser
            // 
            this.lblInfoUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoUser.AutoSize = true;
            this.lblInfoUser.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInfoUser.Location = new System.Drawing.Point(897, 15);
            this.lblInfoUser.Name = "lblInfoUser";
            this.lblInfoUser.Size = new System.Drawing.Size(68, 19);
            this.lblInfoUser.TabIndex = 3;
            this.lblInfoUser.Text = "Username";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.flowLayoutPanel1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblInfoUser);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(978, 518);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(10, 30);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(978, 518);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(41, 8);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(140, 19);
            this.lblLogo.TabIndex = 5;
            this.lblLogo.Text = "ACADEMY SOLUTION";
            // 
            // pcbIcon
            // 
            this.pcbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pcbIcon.Image")));
            this.pcbIcon.Location = new System.Drawing.Point(10, 3);
            this.pcbIcon.Name = "pcbIcon";
            this.pcbIcon.Size = new System.Drawing.Size(25, 24);
            this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIcon.TabIndex = 6;
            this.pcbIcon.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.splitContainer1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 37);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(978, 481);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(150, 0);
            this.splitContainer1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(998, 558);
            this.Controls.Add(this.pcbIcon);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.mnPrincipal);
            this.Controls.Add(this.toolStripContainer1);
            this.DisplayHeader = false;
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnPrincipal;
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
            this.mnPrincipal.ResumeLayout(false);
            this.mnPrincipal.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mniRegistration;
        private System.Windows.Forms.ToolStripMenuItem smiAddNew;
        private System.Windows.Forms.ToolStripMenuItem mniSearch;
        private MetroFramework.Controls.MetroLabel lblInfoUser;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem mniProfile;
        private System.Windows.Forms.ToolStripMenuItem mniHelp;
        private MetroFramework.Controls.MetroLabel lblLogo;
        private System.Windows.Forms.PictureBox pcbIcon;
        private System.Windows.Forms.ToolStripMenuItem mniAccount;
        private System.Windows.Forms.ToolStripMenuItem mniRecord;
        private System.Windows.Forms.ToolStripMenuItem mniView;
        private System.Windows.Forms.ToolStripMenuItem mniViewStudents;
        private System.Windows.Forms.ToolStripMenuItem mniViewTrainers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}