using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AcademySolution
{
    class Aluno : IPessoa
    {
        public Instance instance = new Instance();
        public String _error;
        public String Codigo { get; private set; }
        public String Nome { get; private set; }
        public String Cpf { get; private set; }
        public String Email { get; private set; }
        public String Nascimento { get; private set; }
        public String Categoria { get; private set; }
        public String Numero { get; private set; }
        public String Rua { get; private set; }
        public String Complemento { get; private set; }
        public String Bairro { get; private set; }
        public String Cidade { get; private set; }
        public String Estado { get; private set; }
        public String Pais { get; private set; }
        public String Telefone { get; private set; }

        public Aluno(String codigo, String nome, String rua, String email, String bairro, String nascimento, String categoria,
            String numero, String complemento, String cidade, String estado, String pais, String cpf, String telefone)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.Nascimento = nascimento;
            this.Categoria = categoria;
            this.Numero = numero;
            this.Rua = rua;
            this.Complemento = complemento;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Pais = pais;
            this.Telefone = telefone;
        }

        public void Create()
        {
            //if (
            //    Nome == "" || Email == "" || Bairro == "" /*|| Nascimento == null || Categoria != "Aluno" ||
            //    Numero == "" || Rua == "" || Complemento == "" || Bairro == "" || Cidade == "" || Estado == ""*/
            //    )
            //{
            //    _error = "Por favor, preencha os campos corretamente!";
            //}
            //else
            //{
                try
                {
                    String query = "insert into tb_contas(Nome, DataNasc, DataRegistro, Categoria, Email, Rua, Numero, " +
                        "Complemento, Bairro, Cidade, Estado, Pais, Cpf, Telefone,DataUpdate) " +
                        "values(@Nome, @DateBirth, @DateRegister, @Categoria, @Email, @Rua, @Numero, @Complemento, @Bairro, " +
                        "@Cidade, @Estado, @Country, @Cpf, @Telefone,@DataUpdate)";

                    SqlCommand command = instance.NovoComando(query);

                    command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Nome;
                    command.Parameters.Add("@DateBirth", SqlDbType.Date).Value = Convert.ToDateTime(Nascimento.Replace("/", "-"));
                    command.Parameters.Add("@DateRegister", SqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@DataUpdate", SqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email.ToString();
                    command.Parameters.Add("@Categoria", SqlDbType.Int).Value = 1;
                    command.Parameters.Add("@Rua", SqlDbType.Int).Value = Convert.ToInt32(Rua);
                    command.Parameters.Add("@Numero", SqlDbType.Int).Value = Convert.ToInt32(Numero);
                    command.Parameters.Add("@Complemento", SqlDbType.VarChar).Value = Complemento;
                    command.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = Bairro.ToString();
                    command.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = Cidade.ToString();
                    command.Parameters.Add("@Estado", SqlDbType.VarChar).Value = Estado.ToString();
                    command.Parameters.Add("@Country", SqlDbType.VarChar).Value = Pais.ToString();
                    command.Parameters.Add("@Cpf", SqlDbType.VarChar).Value = Cpf;
                    command.Parameters.Add("@Telefone", SqlDbType.Float).Value = Convert.ToDouble(Telefone.Replace("-", "").Replace("(", "").Replace(")", ""));

                    instance.NovaConexao();
                    command.ExecuteNonQuery();

                    this._error = "Registro Concluido Com Exito! ";

                    instance.FechaConexao();
                }
                catch (Exception ex)
                {
                    this._error = ex.Message.ToString();
                }
                finally
                {
                    //instance.FechaConexao();
                    this._error = "Finalizado!"; 
                }
            //}
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
