using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution
{
    public class Login
    {
        public bool Status { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String _error { get; set; }
        public int Codigo { get; set; }
        
        public Login()
        {
            this.Codigo = 1;
            this.Username = "admin";
            this.Password = "admin";
        }

        //Método usado para trocar status para logado
        public void Logar()
        {
            this.Status = true;
            return;
        }

        //Método usado para validar o login
        public void ValidaLogin(String username, String password)
        {
            //Se usuário e senha forem vazios
            if ( username == "" || password == "" )
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    this._error = "Por favor, preencha seus dados corretamente.";
                    return;
                }
                //Mas se usuario for vazio e senha não
                else if ( username == "" && password != "" )
                {
                    this._error = "Por favor, preencha o campo usuário!";
                }
                //Mas se usuario for preenchido e senha não
                else if ( username != "" && password == "" )
                {
                    this._error = "Por favor, preencha sua senha!";
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
            //Mas se usuário ou senha forem diferentes dos definidos pela classe 
            else if ( username != this.Username || password != this.Password )
            {
                this._error = "Seus dados estão incorretos! Refaça a operação.";
                return;
            }
            //Se usuário e senha estiverem corretos
            else if (username == this.Username || password == this.Password)
            {
                this.Logar();
                return;
            }
        }

        public void Deslogar()
        {
            this.Codigo = 0;
            this.Username = null;
            this.Password = null;
        }

        public void AtualizaLogin()
        {

        }

        public void RemoveLogin()
        {

        }

        public void CadastraLogin()
        {

        }
    }
}
