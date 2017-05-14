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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRegister = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txbLastName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbbLevel = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txbDateBirth = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txbStreet = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txbNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cbbPlace = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.txbFirstName = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.tbxCellphone = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.tbxCPF = new System.Windows.Forms.MaskedTextBox();
            this.txbCidade = new MetroFramework.Controls.MetroTextBox();
            this.cbbCountry = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txbComplemento = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(597, 469);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(110, 23);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Criar";
            this.btnRegister.UseSelectable = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(101, 107);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Nome :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(385, 107);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Sobrenome :";
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
            this.txbLastName.Location = new System.Drawing.Point(476, 107);
            this.txbLastName.MaxLength = 32767;
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.PasswordChar = '\0';
            this.txbLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbLastName.SelectedText = "";
            this.txbLastName.SelectionLength = 0;
            this.txbLastName.SelectionStart = 0;
            this.txbLastName.ShortcutsEnabled = true;
            this.txbLastName.Size = new System.Drawing.Size(231, 23);
            this.txbLastName.TabIndex = 1;
            this.txbLastName.UseSelectable = true;
            this.txbLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txbLastName.Click += new System.EventHandler(this.txbFirstName_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(425, 146);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Nível :";
            // 
            // cbbLevel
            // 
            this.cbbLevel.FormattingEnabled = true;
            this.cbbLevel.ItemHeight = 23;
            this.cbbLevel.Items.AddRange(new object[] {
            "Aluno",
            "Instrutor"});
            this.cbbLevel.Location = new System.Drawing.Point(476, 146);
            this.cbbLevel.Name = "cbbLevel";
            this.cbbLevel.Size = new System.Drawing.Size(231, 29);
            this.cbbLevel.TabIndex = 3;
            this.cbbLevel.UseSelectable = true;
            this.cbbLevel.SelectedIndexChanged += new System.EventHandler(this.cbbLevel_SelectedIndexChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(476, 469);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(110, 23);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "Limpar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(19, 146);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(135, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Data de Nascimento :";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // txbDateBirth
            // 
            // 
            // 
            // 
            this.txbDateBirth.CustomButton.Image = null;
            this.txbDateBirth.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txbDateBirth.CustomButton.Name = "";
            this.txbDateBirth.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbDateBirth.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbDateBirth.CustomButton.TabIndex = 1;
            this.txbDateBirth.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbDateBirth.CustomButton.UseSelectable = true;
            this.txbDateBirth.CustomButton.Visible = false;
            this.txbDateBirth.Lines = new string[0];
            this.txbDateBirth.Location = new System.Drawing.Point(160, 146);
            this.txbDateBirth.MaxLength = 32767;
            this.txbDateBirth.Name = "txbDateBirth";
            this.txbDateBirth.PasswordChar = '\0';
            this.txbDateBirth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbDateBirth.SelectedText = "";
            this.txbDateBirth.SelectionLength = 0;
            this.txbDateBirth.SelectionStart = 0;
            this.txbDateBirth.ShortcutsEnabled = true;
            this.txbDateBirth.Size = new System.Drawing.Size(221, 23);
            this.txbDateBirth.TabIndex = 2;
            this.txbDateBirth.UseSelectable = true;
            this.txbDateBirth.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbDateBirth.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txbDateBirth.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(69, 247);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(38, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Rua :";
            // 
            // txbStreet
            // 
            // 
            // 
            // 
            this.txbStreet.CustomButton.Image = null;
            this.txbStreet.CustomButton.Location = new System.Drawing.Point(403, 1);
            this.txbStreet.CustomButton.Name = "";
            this.txbStreet.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbStreet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbStreet.CustomButton.TabIndex = 1;
            this.txbStreet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbStreet.CustomButton.UseSelectable = true;
            this.txbStreet.CustomButton.Visible = false;
            this.txbStreet.Lines = new string[0];
            this.txbStreet.Location = new System.Drawing.Point(113, 247);
            this.txbStreet.MaxLength = 32767;
            this.txbStreet.Name = "txbStreet";
            this.txbStreet.PasswordChar = '\0';
            this.txbStreet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbStreet.SelectedText = "";
            this.txbStreet.SelectionLength = 0;
            this.txbStreet.SelectionStart = 0;
            this.txbStreet.ShortcutsEnabled = true;
            this.txbStreet.Size = new System.Drawing.Size(425, 23);
            this.txbStreet.TabIndex = 4;
            this.txbStreet.UseSelectable = true;
            this.txbStreet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbStreet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txbStreet.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(560, 247);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(65, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Numero :";
            // 
            // txbNumber
            // 
            // 
            // 
            // 
            this.txbNumber.CustomButton.Image = null;
            this.txbNumber.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.txbNumber.CustomButton.Name = "";
            this.txbNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbNumber.CustomButton.TabIndex = 1;
            this.txbNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbNumber.CustomButton.UseSelectable = true;
            this.txbNumber.CustomButton.Visible = false;
            this.txbNumber.Lines = new string[0];
            this.txbNumber.Location = new System.Drawing.Point(631, 247);
            this.txbNumber.MaxLength = 32767;
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.PasswordChar = '\0';
            this.txbNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbNumber.SelectedText = "";
            this.txbNumber.SelectionLength = 0;
            this.txbNumber.SelectionStart = 0;
            this.txbNumber.ShortcutsEnabled = true;
            this.txbNumber.Size = new System.Drawing.Size(76, 23);
            this.txbNumber.TabIndex = 5;
            this.txbNumber.UseSelectable = true;
            this.txbNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txbNumber.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(411, 325);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(39, 19);
            this.metroLabel7.TabIndex = 7;
            this.metroLabel7.Text = "País :";
            // 
            // cbbPlace
            // 
            this.cbbPlace.FormattingEnabled = true;
            this.cbbPlace.ItemHeight = 23;
            this.cbbPlace.Items.AddRange(new object[] {
            "Brazil",
            "Estados Unidos"});
            this.cbbPlace.Location = new System.Drawing.Point(113, 325);
            this.cbbPlace.Name = "cbbPlace";
            this.cbbPlace.Size = new System.Drawing.Size(217, 29);
            this.cbbPlace.TabIndex = 6;
            this.cbbPlace.UseSelectable = true;
            this.cbbPlace.SelectedIndexChanged += new System.EventHandler(this.cbbPlace_SelectedIndexChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(52, 325);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(55, 19);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Estado :";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(349, 469);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToOrderColumns = true;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle11;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(20, 60);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(728, 448);
            this.metroGrid1.TabIndex = 9;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // txbFirstName
            // 
            // 
            // 
            // 
            this.txbFirstName.CustomButton.Image = null;
            this.txbFirstName.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txbFirstName.CustomButton.Name = "";
            this.txbFirstName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbFirstName.CustomButton.TabIndex = 1;
            this.txbFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbFirstName.CustomButton.UseSelectable = true;
            this.txbFirstName.CustomButton.Visible = false;
            this.txbFirstName.Lines = new string[0];
            this.txbFirstName.Location = new System.Drawing.Point(158, 107);
            this.txbFirstName.MaxLength = 32767;
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.PasswordChar = '\0';
            this.txbFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbFirstName.SelectedText = "";
            this.txbFirstName.SelectionLength = 0;
            this.txbFirstName.SelectionStart = 0;
            this.txbFirstName.ShortcutsEnabled = true;
            this.txbFirstName.Size = new System.Drawing.Size(221, 23);
            this.txbFirstName.TabIndex = 0;
            this.txbFirstName.UseSelectable = true;
            this.txbFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txbFirstName.Click += new System.EventHandler(this.txbFirstName_Click_1);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(25, 57);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(708, 10);
            this.metroTile1.TabIndex = 38;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(380, 370);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(70, 19);
            this.metroLabel9.TabIndex = 39;
            this.metroLabel9.Text = "Telefone : ";
            // 
            // tbxCellphone
            // 
            this.tbxCellphone.Location = new System.Drawing.Point(456, 370);
            this.tbxCellphone.Mask = "00000-9999";
            this.tbxCellphone.Name = "tbxCellphone";
            this.tbxCellphone.Size = new System.Drawing.Size(75, 20);
            this.tbxCellphone.TabIndex = 40;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(63, 371);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(44, 19);
            this.metroLabel10.TabIndex = 41;
            this.metroLabel10.Text = "CPF : ";
            // 
            // tbxCPF
            // 
            this.tbxCPF.Location = new System.Drawing.Point(113, 372);
            this.tbxCPF.Mask = "000,000,000-00";
            this.tbxCPF.Name = "tbxCPF";
            this.tbxCPF.Size = new System.Drawing.Size(217, 20);
            this.tbxCPF.TabIndex = 42;
            // 
            // txbCidade
            // 
            // 
            // 
            // 
            this.txbCidade.CustomButton.Image = null;
            this.txbCidade.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.txbCidade.CustomButton.Name = "";
            this.txbCidade.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbCidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbCidade.CustomButton.TabIndex = 1;
            this.txbCidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbCidade.CustomButton.UseSelectable = true;
            this.txbCidade.CustomButton.Visible = false;
            this.txbCidade.Lines = new string[0];
            this.txbCidade.Location = new System.Drawing.Point(113, 285);
            this.txbCidade.MaxLength = 32767;
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.PasswordChar = '\0';
            this.txbCidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbCidade.SelectedText = "";
            this.txbCidade.SelectionLength = 0;
            this.txbCidade.SelectionStart = 0;
            this.txbCidade.ShortcutsEnabled = true;
            this.txbCidade.Size = new System.Drawing.Size(217, 23);
            this.txbCidade.TabIndex = 43;
            this.txbCidade.UseSelectable = true;
            this.txbCidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbCidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbbCountry
            // 
            this.cbbCountry.FormattingEnabled = true;
            this.cbbCountry.ItemHeight = 23;
            this.cbbCountry.Items.AddRange(new object[] {
            "Brazil",
            "Estados Unidos"});
            this.cbbCountry.Location = new System.Drawing.Point(456, 325);
            this.cbbCountry.Name = "cbbCountry";
            this.cbbCountry.Size = new System.Drawing.Size(251, 29);
            this.cbbCountry.TabIndex = 7;
            this.cbbCountry.UseSelectable = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(49, 285);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(58, 19);
            this.metroLabel11.TabIndex = 44;
            this.metroLabel11.Text = "Cidade :";
            // 
            // txbComplemento
            // 
            // 
            // 
            // 
            this.txbComplemento.CustomButton.Image = null;
            this.txbComplemento.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.txbComplemento.CustomButton.Name = "";
            this.txbComplemento.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbComplemento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbComplemento.CustomButton.TabIndex = 1;
            this.txbComplemento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbComplemento.CustomButton.UseSelectable = true;
            this.txbComplemento.CustomButton.Visible = false;
            this.txbComplemento.Lines = new string[0];
            this.txbComplemento.Location = new System.Drawing.Point(532, 285);
            this.txbComplemento.MaxLength = 32767;
            this.txbComplemento.Name = "txbComplemento";
            this.txbComplemento.PasswordChar = '\0';
            this.txbComplemento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbComplemento.SelectedText = "";
            this.txbComplemento.SelectionLength = 0;
            this.txbComplemento.SelectionStart = 0;
            this.txbComplemento.ShortcutsEnabled = true;
            this.txbComplemento.Size = new System.Drawing.Size(175, 23);
            this.txbComplemento.TabIndex = 45;
            this.txbComplemento.UseSelectable = true;
            this.txbComplemento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbComplemento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(425, 285);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(101, 19);
            this.metroLabel12.TabIndex = 46;
            this.metroLabel12.Text = "Complemento :";
            // 
            // frmRegisterAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 528);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.txbComplemento);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.tbxCPF);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.tbxCellphone);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.txbFirstName);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cbbPlace);
            this.Controls.Add(this.cbbCountry);
            this.Controls.Add(this.cbbLevel);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.txbNumber);
            this.Controls.Add(this.txbStreet);
            this.Controls.Add(this.txbDateBirth);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.metroGrid1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmRegisterAccount";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Criar Conta";
            this.Load += new System.EventHandler(this.frmRegisterAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnRegister;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txbLastName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbbLevel;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txbDateBirth;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txbStreet;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txbNumber;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cbbPlace;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTextBox txbFirstName;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.MaskedTextBox tbxCellphone;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.MaskedTextBox tbxCPF;
        private MetroFramework.Controls.MetroTextBox txbCidade;
        private MetroFramework.Controls.MetroComboBox cbbCountry;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txbComplemento;
        private MetroFramework.Controls.MetroLabel metroLabel12;
    }
}