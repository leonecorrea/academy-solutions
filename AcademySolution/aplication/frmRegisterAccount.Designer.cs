namespace AcademySolution
{
    partial class frmRegisterAccount
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
            this.btnRegister = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txbLastName = new MetroFramework.Controls.MetroTextBox();
            this.txbFirstName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbbLevel = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(625, 197);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "First Name :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(385, 78);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = " Last Name:";
            // 
            // txbLastName
            // 
            // 
            // 
            // 
            this.txbLastName.CustomButton.Image = null;
            this.txbLastName.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.txbLastName.CustomButton.Name = "";
            this.txbLastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbLastName.CustomButton.TabIndex = 1;
            this.txbLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbLastName.CustomButton.UseSelectable = true;
            this.txbLastName.CustomButton.Visible = false;
            this.txbLastName.Lines = new string[0];
            this.txbLastName.Location = new System.Drawing.Point(109, 78);
            this.txbLastName.MaxLength = 32767;
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.PasswordChar = '\0';
            this.txbLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbLastName.SelectedText = "";
            this.txbLastName.SelectionLength = 0;
            this.txbLastName.SelectionStart = 0;
            this.txbLastName.ShortcutsEnabled = true;
            this.txbLastName.Size = new System.Drawing.Size(231, 23);
            this.txbLastName.TabIndex = 2;
            this.txbLastName.UseSelectable = true;
            this.txbLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbFirstName
            // 
            // 
            // 
            // 
            this.txbFirstName.CustomButton.Image = null;
            this.txbFirstName.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.txbFirstName.CustomButton.Name = "";
            this.txbFirstName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbFirstName.CustomButton.TabIndex = 1;
            this.txbFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbFirstName.CustomButton.UseSelectable = true;
            this.txbFirstName.CustomButton.Visible = false;
            this.txbFirstName.Lines = new string[0];
            this.txbFirstName.Location = new System.Drawing.Point(469, 78);
            this.txbFirstName.MaxLength = 32767;
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.PasswordChar = '\0';
            this.txbFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbFirstName.SelectedText = "";
            this.txbFirstName.SelectionLength = 0;
            this.txbFirstName.SelectionStart = 0;
            this.txbFirstName.ShortcutsEnabled = true;
            this.txbFirstName.Size = new System.Drawing.Size(231, 23);
            this.txbFirstName.TabIndex = 2;
            this.txbFirstName.UseSelectable = true;
            this.txbFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txbFirstName.Click += new System.EventHandler(this.txbFirstName_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(58, 123);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Level :";
            // 
            // cbbLevel
            // 
            this.cbbLevel.FormattingEnabled = true;
            this.cbbLevel.ItemHeight = 23;
            this.cbbLevel.Items.AddRange(new object[] {
            "Student",
            "Instructor"});
            this.cbbLevel.Location = new System.Drawing.Point(109, 123);
            this.cbbLevel.Name = "cbbLevel";
            this.cbbLevel.Size = new System.Drawing.Size(92, 29);
            this.cbbLevel.TabIndex = 4;
            this.cbbLevel.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(544, 197);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Cancel";
            this.metroButton1.UseSelectable = true;
            // 
            // frmRegisterAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 264);
            this.Controls.Add(this.cbbLevel);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txbFirstName);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnRegister);
            this.Name = "frmRegisterAccount";
            this.Text = "Register Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnRegister;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txbLastName;
        private MetroFramework.Controls.MetroTextBox txbFirstName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbbLevel;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}