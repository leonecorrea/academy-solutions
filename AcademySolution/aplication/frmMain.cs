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
    }
}