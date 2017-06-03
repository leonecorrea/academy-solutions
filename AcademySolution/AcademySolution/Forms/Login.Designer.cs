namespace AcademySolution
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnEntrar = new MetroFramework.Controls.MetroButton();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.txbUsername = new MetroFramework.Controls.MetroTextBox();
            this.txbPassword = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Location = new System.Drawing.Point(113, 501);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(310, 35);
            this.btnEntrar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "&Entrar";
            this.btnEntrar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnEntrar.UseSelectable = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(110, 365);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 19);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Usuário :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(110, 427);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(51, 19);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Senha :";
            // 
            // txbUsername
            // 
            // 
            // 
            // 
            this.txbUsername.CustomButton.Image = null;
            this.txbUsername.CustomButton.Location = new System.Drawing.Point(279, 1);
            this.txbUsername.CustomButton.Name = "";
            this.txbUsername.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txbUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbUsername.CustomButton.TabIndex = 1;
            this.txbUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbUsername.CustomButton.UseSelectable = true;
            this.txbUsername.CustomButton.Visible = false;
            this.txbUsername.Icon = ((System.Drawing.Image)(resources.GetObject("txbUsername.Icon")));
            this.txbUsername.Lines = new string[0];
            this.txbUsername.Location = new System.Drawing.Point(110, 389);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.txbUsername.MaxLength = 20;
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.PasswordChar = '\0';
            this.txbUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbUsername.SelectedText = "";
            this.txbUsername.SelectionLength = 0;
            this.txbUsername.SelectionStart = 0;
            this.txbUsername.ShortcutsEnabled = true;
            this.txbUsername.Size = new System.Drawing.Size(313, 35);
            this.txbUsername.TabIndex = 0;
            this.txbUsername.UseSelectable = true;
            this.txbUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbUsername.WaterMarkFont = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbUsername_KeyPress);
            // 
            // txbPassword
            // 
            // 
            // 
            // 
            this.txbPassword.CustomButton.Image = null;
            this.txbPassword.CustomButton.Location = new System.Drawing.Point(279, 1);
            this.txbPassword.CustomButton.Name = "";
            this.txbPassword.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbPassword.CustomButton.TabIndex = 1;
            this.txbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbPassword.CustomButton.UseSelectable = true;
            this.txbPassword.CustomButton.Visible = false;
            this.txbPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txbPassword.Icon")));
            this.txbPassword.Lines = new string[0];
            this.txbPassword.Location = new System.Drawing.Point(112, 451);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.txbPassword.MaxLength = 100;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbPassword.SelectedText = "";
            this.txbPassword.SelectionLength = 0;
            this.txbPassword.SelectionStart = 0;
            this.txbPassword.ShortcutsEnabled = true;
            this.txbPassword.Size = new System.Drawing.Size(313, 35);
            this.txbPassword.TabIndex = 1;
            this.txbPassword.UseSelectable = true;
            this.txbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbPassword.WaterMarkFont = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(206, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(556, 652);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnEntrar);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnEntrar;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroTextBox txbUsername;
        private MetroFramework.Controls.MetroTextBox txbPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}