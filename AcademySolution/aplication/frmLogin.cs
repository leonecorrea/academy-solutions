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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        static frmLogin _instance;

        public static frmLogin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmLogin(false);
                return _instance;
            }
        }

        public frmLogin(bool _logOut)
        {
            if (_logOut == false)
            {
                Thread t = new Thread(new ThreadStart(Loading));
                //Inicializado
                t.Start();
                for (int i = 0; i <= 5; i++)
                {
                //Completo
                    Thread.Sleep(1000);
                }
                t.Abort();
                
                InitializeComponent();
                this.Show();

            }
            else if(_logOut == true)
            {
                InitializeComponent();
                this.Show();
            }
        }

        public void Loading()
        {
            frmSplashScreen frm = new frmSplashScreen();
            Application.Run(frm);
        }

        //BOTÕES
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbUsername.Clear();
            txbPassword.Clear();
            txbUsername.Focus();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _instance = this;
            txbUsername.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Validação de login
            Login login = new Login();
            login.ValidaLogin( txbUsername.Text, txbPassword.Text );

            //Se logado
            if(login.Status == true || login.Status != false)
            {
                login.Logar();

                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
            }
            //Se não logado
            else
            {
                MetroFramework.MetroMessageBox.Show(this, $"{login._error}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbUsername.Focus();
                return;
            }
            /*Account account = new Account(true);
                bool status = true;
                account.Logar(status, username, password);

                this.Hide();
                frmMain main = new frmMain();
                main.Show();
            }*/
        }
    }
}
