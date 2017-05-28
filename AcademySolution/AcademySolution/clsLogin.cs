using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace AcademySolution
{
    public class Login
    {
        Instance instance = new Instance();
        
        public bool Status { get; set; }

        public String Username { get; set;}

        public String Password { get; set; }

        public String Error { get; set; }

        public int Codigo { get; set; }

        public bool LogOut { get; set; }

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
                            this.Error = "Por favor, preencha o campo usuário!";
                    }
                    //Mas se usuario for preenchido e senha não
                    else if (username != "" && password == "")
                    {
                        this.Error = "Por favor, preencha sua senha!";
                    }
                    else
                    {
                        this.Error = "Por favor, preencha seus dados corretamente.";
                    }
                }
            }
            //Se tudo correto
            else
            {
                //SqlCommand command = new SqlCommand("select * from TblLogin where Username='"+username+"';", instance.NewInstance());
                
                String query = "select * from tb_logins where Username='"+username+"';";
                
                //Se usuário e senha estiverem corretos
                try
                {
                    instance.NovaConexao();
                    //instance.NovoComando(query).Parameters.Add("@username", SqlDbType.VarChar).Value = username;

                    SqlDataReader leitura = instance.LerDados(query);
                    if (leitura.HasRows == false)
                    {
                        this.Error = "Login e senha não foram encontrados!";
                    }
                    else
                    {
                        leitura.Read();
                        this.Codigo = Convert.ToInt32(leitura["Id"]);
                        this.Username = Convert.ToString(leitura["Username"]);
                        this.Password = Convert.ToString(leitura["Password"]);
                        Stream Arquivo;
                        String nomeArquivo = "Id.txt";
                        if(File.Exists(nomeArquivo) == true)
                        {
                            File.Delete(nomeArquivo);
                            Arquivo = File.Create("Id.txt");
                        }
                        else
                        {
                            Arquivo = File.Create("Id.txt");
                        }

                        StreamWriter escrever = new StreamWriter(Arquivo);
                        escrever.Write(Convert.ToInt32(leitura["Id"]));

                        escrever.Close();
                        Arquivo.Close();
                        
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
                            this.Error = "Password failed!";
                        }
                    }
                }
                catch (Exception ex)
                {
                    this.Error = ex.ToString();
                }
                finally
                {
                    instance.FechaConexao();
                }
            }
        }
        

        //Método usado para trocar status para logado
        public void Logar(string username,string password)
        {
            this.Status = true;            
        }

        public void Deslogar()
        {
            this.Status = false;
            this.LogOut = true;
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
            this.Error = null;
            this.LogOut = false;
        }
    }
}
