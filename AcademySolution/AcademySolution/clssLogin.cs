using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AcademySolution
{
    public class Login
    {
        Instance instance = new Instance();

        public bool Status { get; set; }

        public String Username { get; set; }

        public String Password { get; set; }

        public String _error { get; set; }

        public int Codigo { get; set; }

        public bool _LogOut { get; set; }

        //Método usado para validar o login
        public void ValidaLogin(String username, String password)
        {
            //Se usuário e senha forem vazios
            if (username == "" || password == "")
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    //Mas se usuario for vazio e senha não
                    if (username == "" && password != "")
                    {
                            this._error = "Por favor, preencha o campo usuário!";
                    }
                    //Mas se usuario for preenchido e senha não
                    else if (username != "" && password == "")
                    {
                        this._error = "Por favor, preencha sua senha!";
                    }
                    else
                    {
                        this._error = "Por favor, preencha seus dados corretamente.";
                    }
                }
            }
            //Se tudo correto
            else
            {
                //SqlCommand command = new SqlCommand("select * from TblLogin where Username='"+username+"';", instance.NewInstance());
                
                String query = "select * from tblLogin where Username='"+username+"'";

               // command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;

                //Se usuário e senha estiverem corretos
                try
                {
                    instance.NovaConexao();
                    SqlDataReader leitura = instance.LerDados(query);
                    if (leitura.HasRows == false)
                    {
                        this._error = "Username and login were not found!";
                    }
                    else
                    {
                        leitura.Read();
                        this.Codigo = Convert.ToInt32(leitura["CodLogin"]);
                        this.Username = Convert.ToString(leitura["Username"]);
                        this.Password = Convert.ToString(leitura["Password"]);

                        //Começando a comparar a senha
                        GerarMD5 md5 = new GerarMD5();

                        var senhabanco = this.Password;
                        var Senha = password;

                        Boolean ComparaSenha = md5.CompararHash(Senha, senhabanco);

                        if (ComparaSenha)
                        {
                            Logar(Username, Password);
                        }
                        else
                        {
                            this._error = "Password failed!";
                        }
                    }
                }
                catch (Exception ex)
                {
                    this._error = ex.ToString();
                }
                finally
                {
                    instance.FechaConexao();
                }
            }
            /*if (username == this.Username || password == this.Password)
            {
                try
                {
                    //instance.connection();

                    using (AcademySolutionEntities academy = new AcademySolutionEntities())
                    {
                        var query = from o in academy.TblLogins
                                    where o.Username == username && o.Password == password
                                    select o;
                        if (query.SingleOrDefault() != null)
                        {
                            this.Logar(username, password);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    this._error = Convert.ToString(ex);
                }
            }*/
        }

        //Método usado para trocar status para logado
        public void Logar(string username,string password)
        {
            this.Status = true;
        }

        public void Deslogar()
        {
            this.Status = false;
            this._LogOut = true;
        }
        
        //Cadastra Logins
        public void CreateLogin()
        {

        }

        //Lê Logins
        public void ReadLogin()
        {

        }

        //Atualizar os Logins
        public void UpdateLogin()
        {

        }

        //Deleta Login
        public void DeleteLogin()
        {

        }

        public Login()
        {
            //this.Status = false;
            this.Codigo = 0;
            this.Username = null;
            this.Password = null;
            this._error = null;
            this._LogOut = false;
        }
    }
}
