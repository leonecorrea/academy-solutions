using System;
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
        public bool _logOut = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            this._logOut = true;
            
            this.Close();

            pedeLogin();

            //frmLogin.Instance.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Main Form Close
            if (!_logOut)
                Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Account account = new Account();
            //account.Codigo = ;
        }

        public void pedeLogin()
        {
            frmLogin frm = new frmLogin(true);
            frm.Show();
        }

        public void getUsernameAccount()
        {
            //Account a = new Account();
            //a.Codigo = codigo;
        }
    }
}