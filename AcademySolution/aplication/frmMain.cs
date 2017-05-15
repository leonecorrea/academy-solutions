﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademySolution
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public Login login = new Login();

        public frmMain()
        {
            InitializeComponent();
        }

        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            login.Deslogar();
            login._LogOut = true;
            this.Close();
            pedeLogin();

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Main Form Close
            if (!login._LogOut)
                Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.lblInfoUser.Text = login.Username;
        }

        public void pedeLogin()
        {
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        public void getUsernameAccount()
        {
            
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void cadastroDeFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mniRegisterStudent_Click(object sender, EventArgs e)
        {
            

        }

        public void showRegister()
        {
            frmRegisterAccount register = new frmRegisterAccount();
            register.Show();
        }

        private void criarNovaFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mniInfoUser_Click(object sender, EventArgs e)
        {

        }

        private void smiAddNew_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(showRegister));
            showRegister();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(showInfoUser));
            showInfoUser();
        }

        public void showInfoUser()
        {
            infoUser user = new infoUser();
            user.Show();
        }

        private void addNewFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(showRegisterFicha));
            showRegisterFicha();
        }

        public void showRegisterFicha()
        {
            frmRegisterRecord registerFicha = new frmRegisterRecord();
            registerFicha.Show();
        }

        private void fichasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchFicha registerFicha = new frmSearchFicha();
            registerFicha.Show();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}