﻿namespace AcademySolution.Forms
{
    partial class frmBuscarAluno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdBusca = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txbParametro = new MetroFramework.Controls.MetroTextBox();
            this.cbbItemFiltragem = new MetroFramework.Controls.MetroComboBox();
            this.btnPesquisar = new MetroFramework.Controls.MetroButton();
            this.btnLimpar = new MetroFramework.Controls.MetroButton();
            this.txbEmail = new System.Windows.Forms.MaskedTextBox();
            this.lblBairro = new MetroFramework.Controls.MetroLabel();
            this.txbNascimento = new System.Windows.Forms.MaskedTextBox();
            this.lblComplemento = new MetroFramework.Controls.MetroLabel();
            this.lblCidade = new MetroFramework.Controls.MetroLabel();
            this.txbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new MetroFramework.Controls.MetroLabel();
            this.txbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new MetroFramework.Controls.MetroLabel();
            this.lblNumero = new MetroFramework.Controls.MetroLabel();
            this.lblPais = new MetroFramework.Controls.MetroLabel();
            this.lblEstado = new MetroFramework.Controls.MetroLabel();
            this.lblRua = new MetroFramework.Controls.MetroLabel();
            this.lblNascimento = new MetroFramework.Controls.MetroLabel();
            this.grdPrincipal = new MetroFramework.Controls.MetroGrid();
            this.txbRua = new System.Windows.Forms.MaskedTextBox();
            this.txbBairro = new System.Windows.Forms.MaskedTextBox();
            this.txbCidade = new System.Windows.Forms.MaskedTextBox();
            this.txbComplemento = new System.Windows.Forms.MaskedTextBox();
            this.txbEstado = new System.Windows.Forms.MaskedTextBox();
            this.txbPais = new System.Windows.Forms.MaskedTextBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.btnAtualizar = new MetroFramework.Controls.MetroButton();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.txbCodigo = new MetroFramework.Controls.MetroTextBox();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.txbNome = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.txbNumero = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBusca
            // 
            this.grdBusca.AllowUserToOrderColumns = true;
            this.grdBusca.AllowUserToResizeRows = false;
            this.grdBusca.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdBusca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdBusca.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdBusca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle61.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle61.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle61.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle61.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBusca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle61;
            this.grdBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle62.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle62.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBusca.DefaultCellStyle = dataGridViewCellStyle62;
            this.grdBusca.EnableHeadersVisualStyles = false;
            this.grdBusca.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdBusca.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdBusca.Location = new System.Drawing.Point(20, 83);
            this.grdBusca.Name = "grdBusca";
            this.grdBusca.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle63.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBusca.RowHeadersDefaultCellStyle = dataGridViewCellStyle63;
            this.grdBusca.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdBusca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBusca.Size = new System.Drawing.Size(853, 76);
            this.grdBusca.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(46, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(152, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Parâmetro de Pesquisa :";
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
            this.txbParametro.Location = new System.Drawing.Point(316, 110);
            this.txbParametro.MaxLength = 32767;
            this.txbParametro.Name = "txbParametro";
            this.txbParametro.PasswordChar = '\0';
            this.txbParametro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbParametro.SelectedText = "";
            this.txbParametro.SelectionLength = 0;
            this.txbParametro.SelectionStart = 0;
            this.txbParametro.ShortcutsEnabled = true;
            this.txbParametro.Size = new System.Drawing.Size(312, 23);
            this.txbParametro.TabIndex = 1;
            this.txbParametro.UseSelectable = true;
            this.txbParametro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbParametro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.cbbItemFiltragem.Location = new System.Drawing.Point(46, 104);
            this.cbbItemFiltragem.Name = "cbbItemFiltragem";
            this.cbbItemFiltragem.Size = new System.Drawing.Size(264, 29);
            this.cbbItemFiltragem.TabIndex = 0;
            this.cbbItemFiltragem.UseSelectable = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPesquisar.Location = new System.Drawing.Point(664, 110);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(87, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseSelectable = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLimpar.Location = new System.Drawing.Point(757, 110);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseSelectable = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txbEmail
            // 
            this.txbEmail.Enabled = false;
            this.txbEmail.Location = new System.Drawing.Point(174, 340);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(231, 20);
            this.txbEmail.TabIndex = 58;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(115, 468);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(56, 19);
            this.lblBairro.TabIndex = 78;
            this.lblBairro.Text = "Bairro : ";
            // 
            // txbNascimento
            // 
            this.txbNascimento.Enabled = false;
            this.txbNascimento.Location = new System.Drawing.Point(174, 244);
            this.txbNascimento.Mask = "00/00/0000";
            this.txbNascimento.Name = "txbNascimento";
            this.txbNascimento.Size = new System.Drawing.Size(231, 20);
            this.txbNascimento.TabIndex = 55;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(432, 463);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(101, 19);
            this.lblComplemento.TabIndex = 76;
            this.lblComplemento.Text = "Complemento :";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(110, 508);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(58, 19);
            this.lblCidade.TabIndex = 75;
            this.lblCidade.Text = "Cidade :";
            // 
            // txbCpf
            // 
            this.txbCpf.Enabled = false;
            this.txbCpf.Location = new System.Drawing.Point(548, 243);
            this.txbCpf.Mask = "000,000,000-00";
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(231, 20);
            this.txbCpf.TabIndex = 57;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(498, 243);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(44, 19);
            this.lblCpf.TabIndex = 74;
            this.lblCpf.Text = "CPF : ";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Enabled = false;
            this.txbTelefone.Location = new System.Drawing.Point(548, 340);
            this.txbTelefone.Mask = "(00)00000-9999";
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(231, 20);
            this.txbTelefone.TabIndex = 61;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(474, 340);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(70, 19);
            this.lblTelefone.TabIndex = 73;
            this.lblTelefone.Text = "Telefone : ";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(468, 424);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(65, 19);
            this.lblNumero.TabIndex = 65;
            this.lblNumero.Text = "Numero :";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(495, 555);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(39, 19);
            this.lblPais.TabIndex = 66;
            this.lblPais.Text = "País :";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(478, 508);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 19);
            this.lblEstado.TabIndex = 64;
            this.lblEstado.Text = "Estado :";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(130, 425);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(38, 19);
            this.lblRua.TabIndex = 63;
            this.lblRua.Text = "Rua :";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(83, 244);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(85, 19);
            this.lblNascimento.TabIndex = 60;
            this.lblNascimento.Text = "Nascimento :";
            // 
            // grdPrincipal
            // 
            this.grdPrincipal.AllowUserToOrderColumns = true;
            this.grdPrincipal.AllowUserToResizeRows = false;
            this.grdPrincipal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPrincipal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdPrincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle64.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle64.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle64.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle64.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle64.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle64;
            this.grdPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle65.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle65.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle65.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle65.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle65.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle65.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPrincipal.DefaultCellStyle = dataGridViewCellStyle65;
            this.grdPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPrincipal.EnableHeadersVisualStyles = false;
            this.grdPrincipal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdPrincipal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdPrincipal.Location = new System.Drawing.Point(20, 60);
            this.grdPrincipal.Name = "grdPrincipal";
            this.grdPrincipal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle66.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle66.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle66.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle66.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle66.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle66.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle66.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPrincipal.RowHeadersDefaultCellStyle = dataGridViewCellStyle66;
            this.grdPrincipal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPrincipal.Size = new System.Drawing.Size(853, 617);
            this.grdPrincipal.TabIndex = 79;
            // 
            // txbRua
            // 
            this.txbRua.Enabled = false;
            this.txbRua.Location = new System.Drawing.Point(174, 424);
            this.txbRua.Name = "txbRua";
            this.txbRua.Size = new System.Drawing.Size(231, 20);
            this.txbRua.TabIndex = 58;
            // 
            // txbBairro
            // 
            this.txbBairro.Enabled = false;
            this.txbBairro.Location = new System.Drawing.Point(174, 468);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(231, 20);
            this.txbBairro.TabIndex = 58;
            // 
            // txbCidade
            // 
            this.txbCidade.Enabled = false;
            this.txbCidade.Location = new System.Drawing.Point(174, 508);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(231, 20);
            this.txbCidade.TabIndex = 58;
            // 
            // txbComplemento
            // 
            this.txbComplemento.Enabled = false;
            this.txbComplemento.Location = new System.Drawing.Point(539, 463);
            this.txbComplemento.Name = "txbComplemento";
            this.txbComplemento.Size = new System.Drawing.Size(231, 20);
            this.txbComplemento.TabIndex = 58;
            // 
            // txbEstado
            // 
            this.txbEstado.Enabled = false;
            this.txbEstado.Location = new System.Drawing.Point(539, 507);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.Size = new System.Drawing.Size(231, 20);
            this.txbEstado.TabIndex = 58;
            // 
            // txbPais
            // 
            this.txbPais.Enabled = false;
            this.txbPais.Location = new System.Drawing.Point(539, 555);
            this.txbPais.Name = "txbPais";
            this.txbPais.Size = new System.Drawing.Size(231, 20);
            this.txbPais.TabIndex = 58;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle67.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle67.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle67.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle67.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle67.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle67.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle67.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle67;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle68.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle68.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle68.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle68.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle68.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle68.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle68.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle68;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(20, 83);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle69.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle69.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle69.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle69.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle69.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle69.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle69.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle69;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(853, 76);
            this.metroGrid1.TabIndex = 80;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Location = new System.Drawing.Point(377, 635);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(156, 23);
            this.btnAtualizar.TabIndex = 81;
            this.btnAtualizar.Text = "Alterar Dados";
            this.btnAtualizar.UseSelectable = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.White;
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle70.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle70.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle70.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle70.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle70.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle70.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle70;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle71.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle71.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle71.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle71.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle71.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle71.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle71;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(24, 182);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle72.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle72.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle72.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle72.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle72.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle72.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle72.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle72;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(849, 420);
            this.metroGrid2.TabIndex = 82;
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
            this.txbCodigo.Location = new System.Drawing.Point(45, 203);
            this.txbCodigo.MaxLength = 32767;
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.PasswordChar = '\0';
            this.txbCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbCodigo.SelectedText = "";
            this.txbCodigo.SelectionLength = 0;
            this.txbCodigo.SelectionStart = 0;
            this.txbCodigo.ShortcutsEnabled = true;
            this.txbCodigo.Size = new System.Drawing.Size(32, 23);
            this.txbCodigo.TabIndex = 83;
            this.txbCodigo.UseSelectable = true;
            this.txbCodigo.Visible = false;
            this.txbCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(83, 203);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(112, 19);
            this.lblNome.TabIndex = 52;
            this.lblNome.Text = "Nome Completo:";
            // 
            // txbNome
            // 
            this.txbNome.Enabled = false;
            this.txbNome.Location = new System.Drawing.Point(201, 203);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(578, 20);
            this.txbNome.TabIndex = 58;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(120, 335);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 19);
            this.lblEmail.TabIndex = 77;
            this.lblEmail.Text = "Email :";
            // 
            // txbNumero
            // 
            this.txbNumero.Enabled = false;
            this.txbNumero.Location = new System.Drawing.Point(539, 423);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(76, 20);
            this.txbNumero.TabIndex = 58;
            // 
            // frmBuscarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 697);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.txbPais);
            this.Controls.Add(this.txbEstado);
            this.Controls.Add(this.txbComplemento);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.txbBairro);
            this.Controls.Add(this.txbRua);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txbNascimento);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.cbbItemFiltragem);
            this.Controls.Add(this.txbParametro);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.grdBusca);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroGrid2);
            this.Controls.Add(this.grdPrincipal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarAluno";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Buscar Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.grdBusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid grdBusca;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txbParametro;
        private MetroFramework.Controls.MetroComboBox cbbItemFiltragem;
        private MetroFramework.Controls.MetroButton btnPesquisar;
        private MetroFramework.Controls.MetroButton btnLimpar;
        private System.Windows.Forms.MaskedTextBox txbEmail;
        private MetroFramework.Controls.MetroLabel lblBairro;
        private System.Windows.Forms.MaskedTextBox txbNascimento;
        private MetroFramework.Controls.MetroLabel lblComplemento;
        private MetroFramework.Controls.MetroLabel lblCidade;
        private System.Windows.Forms.MaskedTextBox txbCpf;
        private MetroFramework.Controls.MetroLabel lblCpf;
        private System.Windows.Forms.MaskedTextBox txbTelefone;
        private MetroFramework.Controls.MetroLabel lblTelefone;
        private MetroFramework.Controls.MetroLabel lblNumero;
        private MetroFramework.Controls.MetroLabel lblPais;
        private MetroFramework.Controls.MetroLabel lblEstado;
        private MetroFramework.Controls.MetroLabel lblRua;
        private MetroFramework.Controls.MetroLabel lblNascimento;
        private MetroFramework.Controls.MetroGrid grdPrincipal;
        private System.Windows.Forms.MaskedTextBox txbRua;
        private System.Windows.Forms.MaskedTextBox txbBairro;
        private System.Windows.Forms.MaskedTextBox txbCidade;
        private System.Windows.Forms.MaskedTextBox txbComplemento;
        private System.Windows.Forms.MaskedTextBox txbEstado;
        private System.Windows.Forms.MaskedTextBox txbPais;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroButton btnAtualizar;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private MetroFramework.Controls.MetroTextBox txbCodigo;
        private MetroFramework.Controls.MetroLabel lblNome;
        private System.Windows.Forms.MaskedTextBox txbNome;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private System.Windows.Forms.MaskedTextBox txbNumero;
    }
}