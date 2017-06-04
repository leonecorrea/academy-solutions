namespace AcademySolution.Forms
{
    partial class frmBuscarTreiner
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
            MetroFramework.Controls.MetroGrid grdBusca;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbbItemFiltragem = new MetroFramework.Controls.MetroComboBox();
            this.txbParametro = new MetroFramework.Controls.MetroTextBox();
            this.btnPesquisar = new MetroFramework.Controls.MetroButton();
            this.btnLimpar = new MetroFramework.Controls.MetroButton();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.txbCodigo = new MetroFramework.Controls.MetroTextBox();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.txbNome = new System.Windows.Forms.MaskedTextBox();
            this.lblNascimento = new MetroFramework.Controls.MetroLabel();
            this.txbNascimento = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new MetroFramework.Controls.MetroLabel();
            this.txbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.txbEmail = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new MetroFramework.Controls.MetroLabel();
            this.txbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblRua = new MetroFramework.Controls.MetroLabel();
            this.txbRua = new System.Windows.Forms.MaskedTextBox();
            this.lblNumero = new MetroFramework.Controls.MetroLabel();
            this.txbNumero = new System.Windows.Forms.MaskedTextBox();
            this.lblBairro = new MetroFramework.Controls.MetroLabel();
            this.txbBairro = new System.Windows.Forms.MaskedTextBox();
            this.lblComplemento = new MetroFramework.Controls.MetroLabel();
            this.txbComplemento = new System.Windows.Forms.MaskedTextBox();
            this.lblCidade = new MetroFramework.Controls.MetroLabel();
            this.txbCidade = new System.Windows.Forms.MaskedTextBox();
            this.lblEstado = new MetroFramework.Controls.MetroLabel();
            this.txbEstado = new System.Windows.Forms.MaskedTextBox();
            this.lblPais = new MetroFramework.Controls.MetroLabel();
            this.txbPais = new System.Windows.Forms.MaskedTextBox();
            this.btnAtualizar = new MetroFramework.Controls.MetroButton();
            grdBusca = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(grdBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBusca
            // 
            grdBusca.AllowUserToOrderColumns = true;
            grdBusca.AllowUserToResizeRows = false;
            grdBusca.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            grdBusca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            grdBusca.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            grdBusca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            grdBusca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            grdBusca.DefaultCellStyle = dataGridViewCellStyle2;
            grdBusca.EnableHeadersVisualStyles = false;
            grdBusca.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            grdBusca.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            grdBusca.Location = new System.Drawing.Point(19, 73);
            grdBusca.Name = "grdBusca";
            grdBusca.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            grdBusca.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            grdBusca.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grdBusca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grdBusca.Size = new System.Drawing.Size(853, 76);
            grdBusca.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(42, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(150, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Parâmetro de Pesquisa :";
            // 
            // cbbItemFiltragem
            // 
            this.cbbItemFiltragem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbItemFiltragem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbbItemFiltragem.FormattingEnabled = true;
            this.cbbItemFiltragem.ItemHeight = 23;
            this.cbbItemFiltragem.Items.AddRange(new object[] {
            "Codigo",
            "Nome",
            "Cpf"});
            this.cbbItemFiltragem.Location = new System.Drawing.Point(42, 96);
            this.cbbItemFiltragem.Name = "cbbItemFiltragem";
            this.cbbItemFiltragem.Size = new System.Drawing.Size(264, 29);
            this.cbbItemFiltragem.TabIndex = 4;
            this.cbbItemFiltragem.UseSelectable = true;
            // 
            // txbParametro
            // 
            this.txbParametro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txbParametro.CustomButton.Image = null;
            this.txbParametro.CustomButton.Location = new System.Drawing.Point(290, 1);
            this.txbParametro.CustomButton.Name = "";
            this.txbParametro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbParametro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbParametro.CustomButton.TabIndex = 1;
            this.txbParametro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbParametro.CustomButton.UseSelectable = true;
            this.txbParametro.CustomButton.Visible = false;
            this.txbParametro.Lines = new string[0];
            this.txbParametro.Location = new System.Drawing.Point(321, 96);
            this.txbParametro.MaxLength = 32767;
            this.txbParametro.Name = "txbParametro";
            this.txbParametro.PasswordChar = '\0';
            this.txbParametro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbParametro.SelectedText = "";
            this.txbParametro.SelectionLength = 0;
            this.txbParametro.SelectionStart = 0;
            this.txbParametro.ShortcutsEnabled = true;
            this.txbParametro.Size = new System.Drawing.Size(312, 23);
            this.txbParametro.TabIndex = 5;
            this.txbParametro.UseSelectable = true;
            this.txbParametro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbParametro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPesquisar.Location = new System.Drawing.Point(654, 96);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(87, 23);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseSelectable = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLimpar.Location = new System.Drawing.Point(766, 96);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseSelectable = true;
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.White;
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(19, 177);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(849, 420);
            this.metroGrid2.TabIndex = 83;
            // 
            // txbCodigo
            // 
            // 
            // 
            // 
            this.txbCodigo.CustomButton.Image = null;
            this.txbCodigo.CustomButton.Location = new System.Drawing.Point(10, 1);
            this.txbCodigo.CustomButton.Name = "";
            this.txbCodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbCodigo.CustomButton.TabIndex = 1;
            this.txbCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbCodigo.CustomButton.UseSelectable = true;
            this.txbCodigo.CustomButton.Visible = false;
            this.txbCodigo.Lines = new string[0];
            this.txbCodigo.Location = new System.Drawing.Point(42, 201);
            this.txbCodigo.MaxLength = 32767;
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.PasswordChar = '\0';
            this.txbCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbCodigo.SelectedText = "";
            this.txbCodigo.SelectionLength = 0;
            this.txbCodigo.SelectionStart = 0;
            this.txbCodigo.ShortcutsEnabled = true;
            this.txbCodigo.Size = new System.Drawing.Size(32, 23);
            this.txbCodigo.TabIndex = 84;
            this.txbCodigo.UseSelectable = true;
            this.txbCodigo.Visible = false;
            this.txbCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(95, 201);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(112, 19);
            this.lblNome.TabIndex = 85;
            this.lblNome.Text = "Nome Completo:";
            // 
            // txbNome
            // 
            this.txbNome.Enabled = false;
            this.txbNome.Location = new System.Drawing.Point(213, 201);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(578, 20);
            this.txbNome.TabIndex = 86;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(122, 240);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(85, 19);
            this.lblNascimento.TabIndex = 87;
            this.lblNascimento.Text = "Nascimento :";
            // 
            // txbNascimento
            // 
            this.txbNascimento.Enabled = false;
            this.txbNascimento.Location = new System.Drawing.Point(213, 239);
            this.txbNascimento.Mask = "00/00/0000";
            this.txbNascimento.Name = "txbNascimento";
            this.txbNascimento.Size = new System.Drawing.Size(231, 20);
            this.txbNascimento.TabIndex = 88;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(510, 239);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(44, 19);
            this.lblCpf.TabIndex = 89;
            this.lblCpf.Text = "CPF : ";
            // 
            // txbCpf
            // 
            this.txbCpf.Enabled = false;
            this.txbCpf.Location = new System.Drawing.Point(560, 239);
            this.txbCpf.Mask = "000,000,000-00";
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(231, 20);
            this.txbCpf.TabIndex = 90;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(159, 317);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 19);
            this.lblEmail.TabIndex = 91;
            this.lblEmail.Text = "Email :";
            // 
            // txbEmail
            // 
            this.txbEmail.Enabled = false;
            this.txbEmail.Location = new System.Drawing.Point(213, 317);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(231, 20);
            this.txbEmail.TabIndex = 92;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(484, 317);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(68, 19);
            this.lblTelefone.TabIndex = 93;
            this.lblTelefone.Text = "Telefone : ";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Enabled = false;
            this.txbTelefone.Location = new System.Drawing.Point(560, 317);
            this.txbTelefone.Mask = "(00)00000-9999";
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(231, 20);
            this.txbTelefone.TabIndex = 94;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(169, 370);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(38, 19);
            this.lblRua.TabIndex = 95;
            this.lblRua.Text = "Rua :";
            // 
            // txbRua
            // 
            this.txbRua.Enabled = false;
            this.txbRua.Location = new System.Drawing.Point(213, 370);
            this.txbRua.Name = "txbRua";
            this.txbRua.Size = new System.Drawing.Size(231, 20);
            this.txbRua.TabIndex = 96;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(489, 370);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(65, 19);
            this.lblNumero.TabIndex = 97;
            this.lblNumero.Text = "Numero :";
            // 
            // txbNumero
            // 
            this.txbNumero.Enabled = false;
            this.txbNumero.Location = new System.Drawing.Point(560, 369);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(76, 20);
            this.txbNumero.TabIndex = 98;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(155, 409);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(52, 19);
            this.lblBairro.TabIndex = 99;
            this.lblBairro.Text = "Bairro :";
            // 
            // txbBairro
            // 
            this.txbBairro.Enabled = false;
            this.txbBairro.Location = new System.Drawing.Point(213, 409);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(231, 20);
            this.txbBairro.TabIndex = 100;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(453, 409);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(101, 19);
            this.lblComplemento.TabIndex = 101;
            this.lblComplemento.Text = "Complemento :";
            // 
            // txbComplemento
            // 
            this.txbComplemento.Enabled = false;
            this.txbComplemento.Location = new System.Drawing.Point(560, 408);
            this.txbComplemento.Name = "txbComplemento";
            this.txbComplemento.Size = new System.Drawing.Size(231, 20);
            this.txbComplemento.TabIndex = 102;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(149, 447);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(58, 19);
            this.lblCidade.TabIndex = 103;
            this.lblCidade.Text = "Cidade :";
            // 
            // txbCidade
            // 
            this.txbCidade.Enabled = false;
            this.txbCidade.Location = new System.Drawing.Point(213, 447);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(231, 20);
            this.txbCidade.TabIndex = 104;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(499, 448);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 19);
            this.lblEstado.TabIndex = 105;
            this.lblEstado.Text = "Estado :";
            // 
            // txbEstado
            // 
            this.txbEstado.Enabled = false;
            this.txbEstado.Location = new System.Drawing.Point(560, 448);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.Size = new System.Drawing.Size(231, 20);
            this.txbEstado.TabIndex = 106;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(515, 487);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(38, 19);
            this.lblPais.TabIndex = 107;
            this.lblPais.Text = "País :";
            // 
            // txbPais
            // 
            this.txbPais.Enabled = false;
            this.txbPais.Location = new System.Drawing.Point(560, 487);
            this.txbPais.Name = "txbPais";
            this.txbPais.Size = new System.Drawing.Size(231, 20);
            this.txbPais.TabIndex = 108;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Location = new System.Drawing.Point(376, 622);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(156, 23);
            this.btnAtualizar.TabIndex = 109;
            this.btnAtualizar.Text = "Alterar Dados";
            this.btnAtualizar.UseSelectable = true;
            // 
            // frmBuscarTreiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 677);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txbPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.txbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txbComplemento);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.txbBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txbRua);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txbNascimento);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.metroGrid2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txbParametro);
            this.Controls.Add(this.cbbItemFiltragem);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(grdBusca);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmBuscarTreiner";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Buscar Trainer";
            this.Load += new System.EventHandler(this.frmBuscarTreiner_Load);
            ((System.ComponentModel.ISupportInitialize)(grdBusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbbItemFiltragem;
        private MetroFramework.Controls.MetroTextBox txbParametro;
        private MetroFramework.Controls.MetroButton btnPesquisar;
        private MetroFramework.Controls.MetroButton btnLimpar;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private MetroFramework.Controls.MetroTextBox txbCodigo;
        private MetroFramework.Controls.MetroLabel lblNome;
        private System.Windows.Forms.MaskedTextBox txbNome;
        private MetroFramework.Controls.MetroLabel lblNascimento;
        private System.Windows.Forms.MaskedTextBox txbNascimento;
        private MetroFramework.Controls.MetroLabel lblCpf;
        private System.Windows.Forms.MaskedTextBox txbCpf;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private System.Windows.Forms.MaskedTextBox txbEmail;
        private MetroFramework.Controls.MetroLabel lblTelefone;
        private System.Windows.Forms.MaskedTextBox txbTelefone;
        private MetroFramework.Controls.MetroLabel lblRua;
        private System.Windows.Forms.MaskedTextBox txbRua;
        private MetroFramework.Controls.MetroLabel lblNumero;
        private System.Windows.Forms.MaskedTextBox txbNumero;
        private MetroFramework.Controls.MetroLabel lblBairro;
        private System.Windows.Forms.MaskedTextBox txbBairro;
        private MetroFramework.Controls.MetroLabel lblComplemento;
        private System.Windows.Forms.MaskedTextBox txbComplemento;
        private MetroFramework.Controls.MetroLabel lblCidade;
        private System.Windows.Forms.MaskedTextBox txbCidade;
        private MetroFramework.Controls.MetroLabel lblEstado;
        private System.Windows.Forms.MaskedTextBox txbEstado;
        private MetroFramework.Controls.MetroLabel lblPais;
        private System.Windows.Forms.MaskedTextBox txbPais;
        private MetroFramework.Controls.MetroButton btnAtualizar;
    }
}