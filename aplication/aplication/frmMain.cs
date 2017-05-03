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
            Thread t = new Thread(new ThreadStart(Loading));
            t.Start();//Inicializado
            InitializeComponent();
            int j = 0;
            for (int i = 0; i <= 600; i++)
            {
                Thread.Sleep(10);//Completo
                j++;
            }
            t.Abort();
            //this.Opacity = 100;
            //this.pedeLogin();
        }
        
        public void Loading()
        {
            frmSplashScreen frm = new frmSplashScreen();
            Application.Run(frm);
        }

        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            _logOut = true;
            this.Close();
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
            Thread l = new Thread(new ThreadStart(pedeLogin));
            l.Start();
            this.Hide();
        }

        public void pedeLogin()
        {
            Application.Run(new frmLogin());
        }
    }
}