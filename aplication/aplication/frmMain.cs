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
        bool _logOut;

        public frmMain()
        {
            InitializeComponent();
        }

        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            _logOut = true;

            this.Close();

            frmLogin login = new frmLogin();
            login.Show();

            frmLogin.Instance.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Main Form Close
            if (!_logOut)
                Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Account account = new Account();
            //account.Codigo = ;
        }

        public void pedeLogin()
        {
            Application.Run(new frmLogin());
        }
    }
}