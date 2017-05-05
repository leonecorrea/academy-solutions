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
        bool _logOut = false;

        public static frmLogin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmLogin();
                return _instance;
            }
        }

        public frmLogin()
        {
            if (_logOut == false)
            {
                Thread t = new Thread(new ThreadStart(Loading));
                t.Start();//Inicializado
                InitializeComponent();
                int j = 0;
                for (int i = 0; i <= 5; i++)
                {
                    Thread.Sleep(1000);//Completo
                    j++;
                }
                t.Abort();
            }
            else
            {
                _logOut = true;
                InitializeComponent();
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
            //VALIDAÇÃO DE LOGIN
            String username = "admin";
            String password = "admin";

            //Console.WriteLine(txbPassword.Text);
            //Console.WriteLine(txbUsername.Text);
            if (txbUsername.Text == "" || txbPassword.Text == "")
            {
                if (string.IsNullOrEmpty(txbUsername.Text) || string.IsNullOrEmpty(txbPassword.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this,"Por favor, preencha seus dados corretamente.","Mensagem",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txbUsername.Focus();
                    return;
                }
                /*try
                {
                    using (AcademiaSolutionsEntities1 db = new AcademiaSolutionsEntities1())
                    {
                        var query = from a in db.Accounts
                                    where a.UserName == txbUsername.Text && a.Password == txbPassword.Text
                                    select a;
                        if (query.SingleOrDefault() != null)
                        {
                            this.Hide();
                            frmMain frm = new frmMain();
                            frm.ShowDialog();
                        }
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Seu nome de usuário ou senha estão incorretos!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro",MessageBoxButtons.RetryCancel);
                }*/
            }
            else if (txbUsername.Text == username && txbPassword.Text == password)//Se usuário e senha estiverem certos, criaremos nova classe
            {
                Account account = new Account();
                bool status = true;
                account.Logar(status,username,password);
                
                this.Hide();
                frmMain main = new frmMain();
                main.Show();
            }
            else if (txbUsername.Text != username || txbPassword.Text != password)
            {
                MetroFramework.MetroMessageBox.Show(this, "Seus dados não estão cadastrados no sistema!","Mensagem",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
        }
    }
}
