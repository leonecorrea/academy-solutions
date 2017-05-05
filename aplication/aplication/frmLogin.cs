using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                    _instance = new frmLogin();
                return _instance;
            }
        }

        public frmLogin()
        {
            InitializeComponent();
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

        //VALIDAÇÃO DE LOGIN
        private void btnEntrar_Click(object sender, EventArgs e)
        {
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
            else { 
            //MINHA PARTE
            String username = "admin";
            String password = "admin";
                if (txbUsername.Text == username || txbPassword.Text == password)
                {
                    /*Account account = new Account();
                    account.Logar();
                    account.Username = username;
                    account.Passoword = password;

                    frmMain f = new frmMain();
                    f.Show();*/

                    this.Hide();
                    frmMain frm = new frmMain();
                    frm.ShowDialog();
                }
            }

        }
    }
}
