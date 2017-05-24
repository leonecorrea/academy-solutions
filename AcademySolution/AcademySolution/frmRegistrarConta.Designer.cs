﻿namespace AcademySolution
{
    partial class frmRegistrarConta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRegistrar = new MetroFramework.Controls.MetroButton();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.lblNivel = new MetroFramework.Controls.MetroLabel();
            this.cbbLevel = new MetroFramework.Controls.MetroComboBox();
            this.btnLimpar = new MetroFramework.Controls.MetroButton();
            this.lblNascimento = new MetroFramework.Controls.MetroLabel();
            this.lblRua = new MetroFramework.Controls.MetroLabel();
            this.txbStreet = new MetroFramework.Controls.MetroTextBox();
            this.lblNumero = new MetroFramework.Controls.MetroLabel();
            this.txbNumber = new MetroFramework.Controls.MetroTextBox();
            this.lblPais = new MetroFramework.Controls.MetroLabel();
            this.cbbPlace = new MetroFramework.Controls.MetroComboBox();
            this.lblEstado = new MetroFramework.Controls.MetroLabel();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.grdPrincipal = new MetroFramework.Controls.MetroGrid();
            this.txbFullName = new MetroFramework.Controls.MetroTextBox();
            this.lblTelefone = new MetroFramework.Controls.MetroLabel();
            this.tbxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new MetroFramework.Controls.MetroLabel();
            this.tbxCpf = new System.Windows.Forms.MaskedTextBox();
            this.cbbCountry = new MetroFramework.Controls.MetroComboBox();
            this.lblCidade = new MetroFramework.Controls.MetroLabel();
            this.txbComplemento = new MetroFramework.Controls.MetroTextBox();
            this.lblComplemento = new MetroFramework.Controls.MetroLabel();
            this.txbNascimento = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.cbbCidade = new MetroFramework.Controls.MetroComboBox();
            this.lblBairro = new MetroFramework.Controls.MetroLabel();
            this.txbBairro = new MetroFramework.Controls.MetroTextBox();
            this.txbEmail = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(597, 539);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(110, 23);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Criar";
            this.btnRegistrar.UseSelectable = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(43, 92);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 19);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome :";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(425, 221);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(45, 19);
            this.lblNivel.TabIndex = 3;
            this.lblNivel.Text = "Nível :";
            // 
            // cbbLevel
            // 
            this.cbbLevel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbbLevel.FormattingEnabled = true;
            this.cbbLevel.ItemHeight = 23;
            this.cbbLevel.Items.AddRange(new object[] {
            "Aluno",
            "Trainer"});
            this.cbbLevel.Location = new System.Drawing.Point(476, 221);
            this.cbbLevel.Name = "cbbLevel";
            this.cbbLevel.Size = new System.Drawing.Size(231, 29);
            this.cbbLevel.TabIndex = 5;
            this.cbbLevel.UseSelectable = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(476, 539);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(110, 23);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseSelectable = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(11, 134);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(85, 19);
            this.lblNascimento.TabIndex = 6;
            this.lblNascimento.Text = "Nascimento :";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(58, 346);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(38, 19);
            this.lblRua.TabIndex = 7;
            this.lblRua.Text = "Rua :";
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
            this.txbStreet.Location = new System.Drawing.Point(102, 346);
            this.txbStreet.MaxLength = 32767;
            this.txbStreet.Name = "txbStreet";
            this.txbStreet.PasswordChar = '\0';
            this.txbStreet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbStreet.SelectedText = "";
            this.txbStreet.SelectionLength = 0;
            this.txbStreet.SelectionStart = 0;
            this.txbStreet.ShortcutsEnabled = true;
            this.txbStreet.Size = new System.Drawing.Size(425, 23);
            this.txbStreet.TabIndex = 7;
            this.txbStreet.UseSelectable = true;
            this.txbStreet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbStreet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(560, 346);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(65, 19);
            this.lblNumero.TabIndex = 7;
            this.lblNumero.Text = "Numero :";
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
            this.txbNumber.Location = new System.Drawing.Point(631, 346);
            this.txbNumber.MaxLength = 32767;
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.PasswordChar = '\0';
            this.txbNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbNumber.SelectedText = "";
            this.txbNumber.SelectionLength = 0;
            this.txbNumber.SelectionStart = 0;
            this.txbNumber.ShortcutsEnabled = true;
            this.txbNumber.Size = new System.Drawing.Size(76, 23);
            this.txbNumber.TabIndex = 8;
            this.txbNumber.UseSelectable = true;
            this.txbNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(423, 465);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(38, 19);
            this.lblPais.TabIndex = 7;
            this.lblPais.Text = "País :";
            // 
            // cbbPlace
            // 
            this.cbbPlace.DisplayMember = "nome";
            this.cbbPlace.FormattingEnabled = true;
            this.cbbPlace.ItemHeight = 23;
            this.cbbPlace.Items.AddRange(new object[] {
            "Minas Gerais",
            "São Paulo",
            "Rio de Janeiro"});
            this.cbbPlace.Location = new System.Drawing.Point(467, 419);
            this.cbbPlace.Name = "cbbPlace";
            this.cbbPlace.Size = new System.Drawing.Size(231, 29);
            this.cbbPlace.TabIndex = 12;
            this.cbbPlace.UseSelectable = true;
            this.cbbPlace.ValueMember = "nome";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(406, 419);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 19);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estado :";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(349, 539);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grdPrincipal
            // 
            this.grdPrincipal.AllowUserToOrderColumns = true;
            this.grdPrincipal.AllowUserToResizeRows = false;
            this.grdPrincipal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPrincipal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdPrincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPrincipal.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPrincipal.EnableHeadersVisualStyles = false;
            this.grdPrincipal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdPrincipal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdPrincipal.Location = new System.Drawing.Point(20, 60);
            this.grdPrincipal.Name = "grdPrincipal";
            this.grdPrincipal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPrincipal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdPrincipal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPrincipal.Size = new System.Drawing.Size(728, 540);
            this.grdPrincipal.TabIndex = 9;
            this.grdPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPrincipal_CellContentClick);
            // 
            // txbFullName
            // 
            // 
            // 
            // 
            this.txbFullName.CustomButton.Image = null;
            this.txbFullName.CustomButton.Location = new System.Drawing.Point(583, 1);
            this.txbFullName.CustomButton.Name = "";
            this.txbFullName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbFullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbFullName.CustomButton.TabIndex = 1;
            this.txbFullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbFullName.CustomButton.UseSelectable = true;
            this.txbFullName.CustomButton.Visible = false;
            this.txbFullName.Lines = new string[0];
            this.txbFullName.Location = new System.Drawing.Point(102, 92);
            this.txbFullName.MaxLength = 32767;
            this.txbFullName.Name = "txbFullName";
            this.txbFullName.PasswordChar = '\0';
            this.txbFullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbFullName.SelectedText = "";
            this.txbFullName.SelectionLength = 0;
            this.txbFullName.SelectionStart = 0;
            this.txbFullName.ShortcutsEnabled = true;
            this.txbFullName.Size = new System.Drawing.Size(605, 23);
            this.txbFullName.TabIndex = 0;
            this.txbFullName.UseSelectable = true;
            this.txbFullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbFullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(28, 261);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(68, 19);
            this.lblTelefone.TabIndex = 39;
            this.lblTelefone.Text = "Telefone : ";
            // 
            // tbxTelefone
            // 
            this.tbxTelefone.Location = new System.Drawing.Point(102, 261);
            this.tbxTelefone.Mask = "(00)00000-9999";
            this.tbxTelefone.Name = "tbxTelefone";
            this.tbxTelefone.Size = new System.Drawing.Size(231, 20);
            this.tbxTelefone.TabIndex = 6;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(426, 133);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(44, 19);
            this.lblCpf.TabIndex = 41;
            this.lblCpf.Text = "CPF : ";
            // 
            // tbxCpf
            // 
            this.tbxCpf.Location = new System.Drawing.Point(476, 133);
            this.tbxCpf.Mask = "000,000,000-00";
            this.tbxCpf.Name = "tbxCpf";
            this.tbxCpf.Size = new System.Drawing.Size(231, 20);
            this.tbxCpf.TabIndex = 3;
            // 
            // cbbCountry
            // 
            this.cbbCountry.FormattingEnabled = true;
            this.cbbCountry.ItemHeight = 23;
            this.cbbCountry.Items.AddRange(new object[] {
            "Brazil"});
            this.cbbCountry.Location = new System.Drawing.Point(467, 465);
            this.cbbCountry.Name = "cbbCountry";
            this.cbbCountry.Size = new System.Drawing.Size(231, 29);
            this.cbbCountry.TabIndex = 13;
            this.cbbCountry.UseSelectable = true;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(38, 429);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(58, 19);
            this.lblCidade.TabIndex = 44;
            this.lblCidade.Text = "Cidade :";
            // 
            // txbComplemento
            // 
            // 
            // 
            // 
            this.txbComplemento.CustomButton.Image = null;
            this.txbComplemento.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txbComplemento.CustomButton.Name = "";
            this.txbComplemento.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbComplemento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbComplemento.CustomButton.TabIndex = 1;
            this.txbComplemento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbComplemento.CustomButton.UseSelectable = true;
            this.txbComplemento.CustomButton.Visible = false;
            this.txbComplemento.Lines = new string[0];
            this.txbComplemento.Location = new System.Drawing.Point(467, 385);
            this.txbComplemento.MaxLength = 32767;
            this.txbComplemento.Name = "txbComplemento";
            this.txbComplemento.PasswordChar = '\0';
            this.txbComplemento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbComplemento.SelectedText = "";
            this.txbComplemento.SelectionLength = 0;
            this.txbComplemento.SelectionStart = 0;
            this.txbComplemento.ShortcutsEnabled = true;
            this.txbComplemento.Size = new System.Drawing.Size(240, 23);
            this.txbComplemento.TabIndex = 10;
            this.txbComplemento.UseSelectable = true;
            this.txbComplemento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbComplemento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(360, 384);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(101, 19);
            this.lblComplemento.TabIndex = 46;
            this.lblComplemento.Text = "Complemento :";
            // 
            // txbNascimento
            // 
            this.txbNascimento.Location = new System.Drawing.Point(102, 134);
            this.txbNascimento.Mask = "00/00/0000";
            this.txbNascimento.Name = "txbNascimento";
            this.txbNascimento.Size = new System.Drawing.Size(231, 20);
            this.txbNascimento.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(48, 225);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 19);
            this.lblEmail.TabIndex = 48;
            this.lblEmail.Text = "Email :";
            // 
            // cbbCidade
            // 
            this.cbbCidade.DisplayMember = "nome";
            this.cbbCidade.FormattingEnabled = true;
            this.cbbCidade.ItemHeight = 23;
            this.cbbCidade.Items.AddRange(new object[] {
            "Betim",
            "Belo Horizonte",
            "Contagem",
            "Ibirité"});
            this.cbbCidade.Location = new System.Drawing.Point(102, 423);
            this.cbbCidade.Name = "cbbCidade";
            this.cbbCidade.Size = new System.Drawing.Size(231, 29);
            this.cbbCidade.TabIndex = 11;
            this.cbbCidade.UseSelectable = true;
            this.cbbCidade.ValueMember = "nome";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(43, 389);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(56, 19);
            this.lblBairro.TabIndex = 50;
            this.lblBairro.Text = "Bairro : ";
            // 
            // txbBairro
            // 
            // 
            // 
            // 
            this.txbBairro.CustomButton.Image = null;
            this.txbBairro.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.txbBairro.CustomButton.Name = "";
            this.txbBairro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbBairro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbBairro.CustomButton.TabIndex = 1;
            this.txbBairro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbBairro.CustomButton.UseSelectable = true;
            this.txbBairro.CustomButton.Visible = false;
            this.txbBairro.Lines = new string[0];
            this.txbBairro.Location = new System.Drawing.Point(102, 385);
            this.txbBairro.MaxLength = 32767;
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.PasswordChar = '\0';
            this.txbBairro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbBairro.SelectedText = "";
            this.txbBairro.SelectionLength = 0;
            this.txbBairro.SelectionStart = 0;
            this.txbBairro.ShortcutsEnabled = true;
            this.txbBairro.Size = new System.Drawing.Size(231, 23);
            this.txbBairro.TabIndex = 9;
            this.txbBairro.UseSelectable = true;
            this.txbBairro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbBairro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(102, 230);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(231, 20);
            this.txbEmail.TabIndex = 4;
            // 
            // frmRegistrarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 620);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txbNascimento);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.txbComplemento);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.tbxCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.tbxTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txbFullName);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.cbbCidade);
            this.Controls.Add(this.cbbPlace);
            this.Controls.Add(this.cbbCountry);
            this.Controls.Add(this.cbbLevel);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.txbNumber);
            this.Controls.Add(this.txbStreet);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.grdPrincipal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistrarConta";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Criar Conta";
            ((System.ComponentModel.ISupportInitialize)(this.grdPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnRegistrar;
        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroLabel lblNivel;
        private MetroFramework.Controls.MetroComboBox cbbLevel;
        private MetroFramework.Controls.MetroButton btnLimpar;
        private MetroFramework.Controls.MetroLabel lblNascimento;
        private MetroFramework.Controls.MetroLabel lblRua;
        private MetroFramework.Controls.MetroTextBox txbStreet;
        private MetroFramework.Controls.MetroLabel lblNumero;
        private MetroFramework.Controls.MetroTextBox txbNumber;
        private MetroFramework.Controls.MetroLabel lblPais;
        private MetroFramework.Controls.MetroComboBox cbbPlace;
        private MetroFramework.Controls.MetroLabel lblEstado;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroGrid grdPrincipal;
        private MetroFramework.Controls.MetroTextBox txbFullName;
        private MetroFramework.Controls.MetroLabel lblTelefone;
        private System.Windows.Forms.MaskedTextBox tbxTelefone;
        private MetroFramework.Controls.MetroLabel lblCpf;
        private System.Windows.Forms.MaskedTextBox tbxCpf;
        private MetroFramework.Controls.MetroComboBox cbbCountry;
        private MetroFramework.Controls.MetroLabel lblCidade;
        private MetroFramework.Controls.MetroTextBox txbComplemento;
        private MetroFramework.Controls.MetroLabel lblComplemento;
        private System.Windows.Forms.MaskedTextBox txbNascimento;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroComboBox cbbCidade;
        private MetroFramework.Controls.MetroLabel lblBairro;
        private MetroFramework.Controls.MetroTextBox txbBairro;
        private System.Windows.Forms.MaskedTextBox txbEmail;
    }
}