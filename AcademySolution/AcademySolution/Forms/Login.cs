using AcademySolution;
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
using System.Security.Cryptography;

namespace AcademySolution
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public Instance server = new Instance();

        public Login login = new Login();

        public frmLogin()
        {
            if (login.LogOut == false)
            {
                Thread t = new Thread(new ThreadStart(Loading));
                //Inicializado
                t.Start();
                for (int i = 0; i <= 5; i++)
                {
                    Thread.Sleep(1000);
                }
                //Completo
                t.Abort();
                
                InitializeComponent();
                this.Show();

            }
            else if(login.LogOut == true)
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
            txbUsername.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            login.LogOut = true;
            Application.Exit();
        }

        private void txbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txbPassword.Focus();
        }

        private void txbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnEntrar.PerformClick();
        }
        
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Validação de login
            login.ValidaLogin(txbUsername.Text, txbPassword.Text);
            
            //Se logado
            if (login.Status == true)
            {
                login.Logar(txbUsername.Text,txbPassword.Text);

                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
            }
            //Se não logado
            else
            {
                MetroFramework.MetroMessageBox.Show(this, $"{login.Error}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbUsername.Focus();
            }
        }
        public static string GetCript(String input)
        {
            MD5 md5Hash = MD5.Create();
            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Cria-se um StringBuilder para recompôr a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}
