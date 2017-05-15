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
            this.btnLimpar = new MetroFramework.Controls.MetroButton();
            this.pcbCadeado = new System.Windows.Forms.PictureBox();
            this.lblBoasVindas = new MetroFramework.Controls.MetroLabel();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCadeado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Location = new System.Drawing.Point(527, 242);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(123, 23);
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
            this.lblUsername.Location = new System.Drawing.Point(220, 150);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(56, 19);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Usuário:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(220, 188);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(47, 19);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Senha:";
            // 
            // txbUsername
            // 
            // 
            // 
            // 
            this.txbUsername.CustomButton.Image = null;
            this.txbUsername.CustomButton.Location = new System.Drawing.Point(354, 1);
            this.txbUsername.CustomButton.Name = "";
            this.txbUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbUsername.CustomButton.TabIndex = 1;
            this.txbUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbUsername.CustomButton.UseSelectable = true;
            this.txbUsername.CustomButton.Visible = false;
            this.txbUsername.Lines = new string[0];
            this.txbUsername.Location = new System.Drawing.Point(274, 150);
            this.txbUsername.MaxLength = 32767;
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.PasswordChar = '\0';
            this.txbUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbUsername.SelectedText = "";
            this.txbUsername.SelectionLength = 0;
            this.txbUsername.SelectionStart = 0;
            this.txbUsername.ShortcutsEnabled = true;
            this.txbUsername.Size = new System.Drawing.Size(376, 23);
            this.txbUsername.TabIndex = 0;
            this.txbUsername.UseSelectable = true;
            this.txbUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txbUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbUsername_KeyPress);
            // 
            // txbPassword
            // 
            // 
            // 
            // 
            this.txbPassword.CustomButton.Image = null;
            this.txbPassword.CustomButton.Location = new System.Drawing.Point(354, 1);
            this.txbPassword.CustomButton.Name = "";
            this.txbPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbPassword.CustomButton.TabIndex = 1;
            this.txbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbPassword.CustomButton.UseSelectable = true;
            this.txbPassword.CustomButton.Visible = false;
            this.txbPassword.Lines = new string[0];
            this.txbPassword.Location = new System.Drawing.Point(274, 184);
            this.txbPassword.MaxLength = 32767;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbPassword.SelectedText = "";
            this.txbPassword.SelectionLength = 0;
            this.txbPassword.SelectionStart = 0;
            this.txbPassword.ShortcutsEnabled = true;
            this.txbPassword.Size = new System.Drawing.Size(376, 23);
            this.txbPassword.TabIndex = 1;
            this.txbPassword.UseSelectable = true;
            this.txbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(400, 242);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(123, 23);
            this.btnLimpar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnLimpar.UseSelectable = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pcbCadeado
            // 
            this.pcbCadeado.Image = ((System.Drawing.Image)(resources.GetObject("pcbCadeado.Image")));
            this.pcbCadeado.Location = new System.Drawing.Point(62, 137);
            this.pcbCadeado.Name = "pcbCadeado";
            this.pcbCadeado.Size = new System.Drawing.Size(128, 128);
            this.pcbCadeado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbCadeado.TabIndex = 9;
            this.pcbCadeado.TabStop = false;
            // 
            // lblBoasVindas
            // 
            this.lblBoasVindas.AutoSize = true;
            this.lblBoasVindas.Location = new System.Drawing.Point(220, 80);
            this.lblBoasVindas.Name = "lblBoasVindas";
            this.lblBoasVindas.Size = new System.Drawing.Size(430, 19);
            this.lblBoasVindas.TabIndex = 10;
            this.lblBoasVindas.Text = "Bem Vindo! Preencha os campos abaixo corretamente com seus dados.";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(271, 242);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(712, 366);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblBoasVindas);
            this.Controls.Add(this.pcbCadeado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnEntrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmLogin";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCadeado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnEntrar;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroTextBox txbUsername;
        private MetroFramework.Controls.MetroTextBox txbPassword;
        private MetroFramework.Controls.MetroButton btnLimpar;
        private System.Windows.Forms.PictureBox pcbCadeado;
        private MetroFramework.Controls.MetroLabel lblBoasVindas;
        private MetroFramework.Controls.MetroButton btnCancelar;
    }
}