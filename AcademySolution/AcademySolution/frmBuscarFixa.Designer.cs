namespace AcademySolution
{
    partial class frmSearchFicha
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDescricao = new MetroFramework.Controls.MetroLabel();
            this.grdBusca = new MetroFramework.Controls.MetroGrid();
            this.cbbParametro = new MetroFramework.Controls.MetroComboBox();
            this.btnFiltrar = new MetroFramework.Controls.MetroButton();
            this.btnLimpar = new MetroFramework.Controls.MetroButton();
            this.txbEntrada = new MetroFramework.Controls.MetroTextBox();
            this.listaExercicios = new System.Windows.Forms.ListBox();
            this.listaSeries = new System.Windows.Forms.ListBox();
            this.listaRepeticoes = new System.Windows.Forms.ListBox();
            this.txbNomeAlunoProcuraFicha = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txbNomeTrainerProcuraFicha = new MetroFramework.Controls.MetroTextBox();
            this.txbBuscaFichaDataInicio = new MetroFramework.Controls.MetroTextBox();
            this.txbBuscaFichaDataTroca = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(50, 75);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(75, 19);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Filtrar Por :";
            // 
            // grdBusca
            // 
            this.grdBusca.AllowUserToOrderColumns = true;
            this.grdBusca.AllowUserToResizeRows = false;
            this.grdBusca.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdBusca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdBusca.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdBusca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBusca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBusca.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdBusca.EnableHeadersVisualStyles = false;
            this.grdBusca.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdBusca.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdBusca.Location = new System.Drawing.Point(23, 86);
            this.grdBusca.Name = "grdBusca";
            this.grdBusca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdBusca.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBusca.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdBusca.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdBusca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBusca.Size = new System.Drawing.Size(960, 90);
            this.grdBusca.TabIndex = 13;
            // 
            // cbbParametro
            // 
            this.cbbParametro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbbParametro.FormattingEnabled = true;
            this.cbbParametro.ItemHeight = 23;
            this.cbbParametro.Items.AddRange(new object[] {
            "Codigo Ficha"});
            this.cbbParametro.Location = new System.Drawing.Point(53, 110);
            this.cbbParametro.Name = "cbbParametro";
            this.cbbParametro.Size = new System.Drawing.Size(261, 29);
            this.cbbParametro.TabIndex = 14;
            this.cbbParametro.UseSelectable = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(810, 116);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 15;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseSelectable = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(891, 116);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseSelectable = true;
            // 
            // txbEntrada
            // 
            // 
            // 
            // 
            this.txbEntrada.CustomButton.Image = null;
            this.txbEntrada.CustomButton.Location = new System.Drawing.Point(383, 1);
            this.txbEntrada.CustomButton.Name = "";
            this.txbEntrada.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbEntrada.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbEntrada.CustomButton.TabIndex = 1;
            this.txbEntrada.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbEntrada.CustomButton.UseSelectable = true;
            this.txbEntrada.CustomButton.Visible = false;
            this.txbEntrada.Lines = new string[0];
            this.txbEntrada.Location = new System.Drawing.Point(338, 116);
            this.txbEntrada.MaxLength = 32767;
            this.txbEntrada.Name = "txbEntrada";
            this.txbEntrada.PasswordChar = '\0';
            this.txbEntrada.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbEntrada.SelectedText = "";
            this.txbEntrada.SelectionLength = 0;
            this.txbEntrada.SelectionStart = 0;
            this.txbEntrada.ShortcutsEnabled = true;
            this.txbEntrada.Size = new System.Drawing.Size(405, 23);
            this.txbEntrada.TabIndex = 16;
            this.txbEntrada.UseSelectable = true;
            this.txbEntrada.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbEntrada.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // listaExercicios
            // 
            this.listaExercicios.Enabled = false;
            this.listaExercicios.FormattingEnabled = true;
            this.listaExercicios.Location = new System.Drawing.Point(174, 356);
            this.listaExercicios.Name = "listaExercicios";
            this.listaExercicios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listaExercicios.Size = new System.Drawing.Size(203, 160);
            this.listaExercicios.TabIndex = 17;
            // 
            // listaSeries
            // 
            this.listaSeries.Enabled = false;
            this.listaSeries.FormattingEnabled = true;
            this.listaSeries.Location = new System.Drawing.Point(383, 356);
            this.listaSeries.Name = "listaSeries";
            this.listaSeries.Size = new System.Drawing.Size(203, 160);
            this.listaSeries.TabIndex = 18;
            // 
            // listaRepeticoes
            // 
            this.listaRepeticoes.Enabled = false;
            this.listaRepeticoes.FormattingEnabled = true;
            this.listaRepeticoes.Location = new System.Drawing.Point(592, 356);
            this.listaRepeticoes.Name = "listaRepeticoes";
            this.listaRepeticoes.Size = new System.Drawing.Size(203, 160);
            this.listaRepeticoes.TabIndex = 19;
            // 
            // txbNomeAlunoProcuraFicha
            // 
            // 
            // 
            // 
            this.txbNomeAlunoProcuraFicha.CustomButton.Image = null;
            this.txbNomeAlunoProcuraFicha.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txbNomeAlunoProcuraFicha.CustomButton.Name = "";
            this.txbNomeAlunoProcuraFicha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbNomeAlunoProcuraFicha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbNomeAlunoProcuraFicha.CustomButton.TabIndex = 1;
            this.txbNomeAlunoProcuraFicha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbNomeAlunoProcuraFicha.CustomButton.UseSelectable = true;
            this.txbNomeAlunoProcuraFicha.CustomButton.Visible = false;
            this.txbNomeAlunoProcuraFicha.Enabled = false;
            this.txbNomeAlunoProcuraFicha.Lines = new string[0];
            this.txbNomeAlunoProcuraFicha.Location = new System.Drawing.Point(174, 205);
            this.txbNomeAlunoProcuraFicha.MaxLength = 32767;
            this.txbNomeAlunoProcuraFicha.Name = "txbNomeAlunoProcuraFicha";
            this.txbNomeAlunoProcuraFicha.PasswordChar = '\0';
            this.txbNomeAlunoProcuraFicha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbNomeAlunoProcuraFicha.SelectedText = "";
            this.txbNomeAlunoProcuraFicha.SelectionLength = 0;
            this.txbNomeAlunoProcuraFicha.SelectionStart = 0;
            this.txbNomeAlunoProcuraFicha.ShortcutsEnabled = true;
            this.txbNomeAlunoProcuraFicha.Size = new System.Drawing.Size(261, 23);
            this.txbNomeAlunoProcuraFicha.TabIndex = 20;
            this.txbNomeAlunoProcuraFicha.UseSelectable = true;
            this.txbNomeAlunoProcuraFicha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbNomeAlunoProcuraFicha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(53, 209);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "Nome Aluno : ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(53, 259);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 19);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "Nome Trainer : ";
            // 
            // txbNomeTrainerProcuraFicha
            // 
            // 
            // 
            // 
            this.txbNomeTrainerProcuraFicha.CustomButton.Image = null;
            this.txbNomeTrainerProcuraFicha.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txbNomeTrainerProcuraFicha.CustomButton.Name = "";
            this.txbNomeTrainerProcuraFicha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbNomeTrainerProcuraFicha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbNomeTrainerProcuraFicha.CustomButton.TabIndex = 1;
            this.txbNomeTrainerProcuraFicha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbNomeTrainerProcuraFicha.CustomButton.UseSelectable = true;
            this.txbNomeTrainerProcuraFicha.CustomButton.Visible = false;
            this.txbNomeTrainerProcuraFicha.Enabled = false;
            this.txbNomeTrainerProcuraFicha.Lines = new string[0];
            this.txbNomeTrainerProcuraFicha.Location = new System.Drawing.Point(174, 255);
            this.txbNomeTrainerProcuraFicha.MaxLength = 32767;
            this.txbNomeTrainerProcuraFicha.Name = "txbNomeTrainerProcuraFicha";
            this.txbNomeTrainerProcuraFicha.PasswordChar = '\0';
            this.txbNomeTrainerProcuraFicha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbNomeTrainerProcuraFicha.SelectedText = "";
            this.txbNomeTrainerProcuraFicha.SelectionLength = 0;
            this.txbNomeTrainerProcuraFicha.SelectionStart = 0;
            this.txbNomeTrainerProcuraFicha.ShortcutsEnabled = true;
            this.txbNomeTrainerProcuraFicha.Size = new System.Drawing.Size(261, 23);
            this.txbNomeTrainerProcuraFicha.TabIndex = 23;
            this.txbNomeTrainerProcuraFicha.UseSelectable = true;
            this.txbNomeTrainerProcuraFicha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbNomeTrainerProcuraFicha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbBuscaFichaDataInicio
            // 
            // 
            // 
            // 
            this.txbBuscaFichaDataInicio.CustomButton.Image = null;
            this.txbBuscaFichaDataInicio.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txbBuscaFichaDataInicio.CustomButton.Name = "";
            this.txbBuscaFichaDataInicio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbBuscaFichaDataInicio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbBuscaFichaDataInicio.CustomButton.TabIndex = 1;
            this.txbBuscaFichaDataInicio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbBuscaFichaDataInicio.CustomButton.UseSelectable = true;
            this.txbBuscaFichaDataInicio.CustomButton.Visible = false;
            this.txbBuscaFichaDataInicio.Enabled = false;
            this.txbBuscaFichaDataInicio.Lines = new string[0];
            this.txbBuscaFichaDataInicio.Location = new System.Drawing.Point(810, 205);
            this.txbBuscaFichaDataInicio.MaxLength = 32767;
            this.txbBuscaFichaDataInicio.Name = "txbBuscaFichaDataInicio";
            this.txbBuscaFichaDataInicio.PasswordChar = '\0';
            this.txbBuscaFichaDataInicio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbBuscaFichaDataInicio.SelectedText = "";
            this.txbBuscaFichaDataInicio.SelectionLength = 0;
            this.txbBuscaFichaDataInicio.SelectionStart = 0;
            this.txbBuscaFichaDataInicio.ShortcutsEnabled = true;
            this.txbBuscaFichaDataInicio.Size = new System.Drawing.Size(173, 23);
            this.txbBuscaFichaDataInicio.TabIndex = 24;
            this.txbBuscaFichaDataInicio.UseSelectable = true;
            this.txbBuscaFichaDataInicio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbBuscaFichaDataInicio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbBuscaFichaDataTroca
            // 
            // 
            // 
            // 
            this.txbBuscaFichaDataTroca.CustomButton.Image = null;
            this.txbBuscaFichaDataTroca.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txbBuscaFichaDataTroca.CustomButton.Name = "";
            this.txbBuscaFichaDataTroca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbBuscaFichaDataTroca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbBuscaFichaDataTroca.CustomButton.TabIndex = 1;
            this.txbBuscaFichaDataTroca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbBuscaFichaDataTroca.CustomButton.UseSelectable = true;
            this.txbBuscaFichaDataTroca.CustomButton.Visible = false;
            this.txbBuscaFichaDataTroca.Enabled = false;
            this.txbBuscaFichaDataTroca.Lines = new string[0];
            this.txbBuscaFichaDataTroca.Location = new System.Drawing.Point(810, 255);
            this.txbBuscaFichaDataTroca.MaxLength = 32767;
            this.txbBuscaFichaDataTroca.Name = "txbBuscaFichaDataTroca";
            this.txbBuscaFichaDataTroca.PasswordChar = '\0';
            this.txbBuscaFichaDataTroca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbBuscaFichaDataTroca.SelectedText = "";
            this.txbBuscaFichaDataTroca.SelectionLength = 0;
            this.txbBuscaFichaDataTroca.SelectionStart = 0;
            this.txbBuscaFichaDataTroca.ShortcutsEnabled = true;
            this.txbBuscaFichaDataTroca.Size = new System.Drawing.Size(173, 23);
            this.txbBuscaFichaDataTroca.TabIndex = 25;
            this.txbBuscaFichaDataTroca.UseSelectable = true;
            this.txbBuscaFichaDataTroca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbBuscaFichaDataTroca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(662, 209);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(81, 19);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Data Inicio : ";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(662, 259);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(84, 19);
            this.metroLabel4.TabIndex = 27;
            this.metroLabel4.Text = "Data Troca : ";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(174, 314);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(101, 19);
            this.metroLabel5.TabIndex = 28;
            this.metroLabel5.Text = "Nome Exercicio";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(383, 313);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(115, 19);
            this.metroLabel6.TabIndex = 29;
            this.metroLabel6.Text = "Número de Séries";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(592, 314);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(144, 19);
            this.metroLabel7.TabIndex = 30;
            this.metroLabel7.Text = "Número de Repetições";
            // 
            // frmSearchFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1006, 539);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txbBuscaFichaDataTroca);
            this.Controls.Add(this.txbBuscaFichaDataInicio);
            this.Controls.Add(this.txbNomeTrainerProcuraFicha);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txbNomeAlunoProcuraFicha);
            this.Controls.Add(this.listaRepeticoes);
            this.Controls.Add(this.listaSeries);
            this.Controls.Add(this.listaExercicios);
            this.Controls.Add(this.txbEntrada);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cbbParametro);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.grdBusca);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchFicha";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Procurar Ficha";
            this.Load += new System.EventHandler(this.frmSearchFicha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblDescricao;
        private MetroFramework.Controls.MetroGrid grdBusca;
        private MetroFramework.Controls.MetroComboBox cbbParametro;
        private MetroFramework.Controls.MetroButton btnFiltrar;
        private MetroFramework.Controls.MetroButton btnLimpar;
        private MetroFramework.Controls.MetroTextBox txbEntrada;
        private System.Windows.Forms.ListBox listaExercicios;
        private System.Windows.Forms.ListBox listaSeries;
        private System.Windows.Forms.ListBox listaRepeticoes;
        private MetroFramework.Controls.MetroTextBox txbNomeAlunoProcuraFicha;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txbNomeTrainerProcuraFicha;
        private MetroFramework.Controls.MetroTextBox txbBuscaFichaDataInicio;
        private MetroFramework.Controls.MetroTextBox txbBuscaFichaDataTroca;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}