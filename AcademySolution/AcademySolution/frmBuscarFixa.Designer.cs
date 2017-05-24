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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDescricao = new MetroFramework.Controls.MetroLabel();
            this.grdBusca = new MetroFramework.Controls.MetroGrid();
            this.cbbParametro = new MetroFramework.Controls.MetroComboBox();
            this.btnFiltrar = new MetroFramework.Controls.MetroButton();
            this.btnLimpar = new MetroFramework.Controls.MetroButton();
            this.txbEntrada = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(50, 75);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(74, 19);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBusca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBusca.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdBusca.EnableHeadersVisualStyles = false;
            this.grdBusca.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdBusca.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdBusca.Location = new System.Drawing.Point(23, 86);
            this.grdBusca.Name = "grdBusca";
            this.grdBusca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdBusca.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBusca.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            // frmSearchFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1006, 539);
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
    }
}