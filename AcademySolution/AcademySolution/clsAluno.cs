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
        private String _error;
        private String _codigo;
        private String _nome;
        private String _cpf;
        private String _email;
        private String _nascimento;
        private String _categoria;
        private String _numero;
        private String _rua;
        private String _complemento;
        private String _bairro;
        private String _cidade;
        private String _estado;
        private String _pais;
        private String _telefone;

        public String Codigo { get { return _codigo; } set { _codigo = value; } }
        public String Nome { get { return _nome; } set { _nome = value; } } 
        public String Cpf { get { return _cpf; } set { _cpf = value; } }
        public String Email { get { return _email; } set { _email = value; } }
        public String Categoria { get { return _categoria; } set { _categoria = value; } }
        public String Numero { get { return _numero; } set { _numero = value; } }
        public String Rua { get { return _rua; } set { _rua = value; } }
        public String Complemento { get { return _complemento; } set { _complemento = value; } }
        public String Bairro { get { return _bairro; } set { _bairro = value; } }
        public String Cidade { get { return _cidade; } set { _cidade = value; } }
        public String Estado { get { return _estado; } set { _estado = value; } }
        public String Pais { get { return _pais; } set { _pais = value; } }
        public String Telefone { get { return _telefone; } set { _telefone = value; } }
        public String Nascimento { get { return _nascimento; } set { _nascimento = value; } }
        public string Error { get { return _error; } set { _error = value; } }
        
        public String Create()
        {
            try
            {
                String query = "insert into tb_contas(Nome, DataNasc, DataRegistro, Categoria, Email, Rua, Numero, " +
                    "Complemento, Bairro, Cidade, Estado, Pais, Cpf, Telefone) " +
                    "values(@Nome, @DataDeNascimento, SYSDATETIME(), @Categoria, @Email, @Rua, @Numero, @Complemento, @Bairro, " +
                    "@Cidade, @Estado, @Pais, @Cpf, @Telefone)";

                SqlCommand command = instance.NovoComando(query);

                command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Nome;
                command.Parameters.Add("@DataDeNascimento", SqlDbType.Date).Value = Convert.ToDateTime(Nascimento.Replace("/", "-"));
                command.Parameters.Add("@Categoria", SqlDbType.Int).Value = Convert.ToInt32(1);
                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email.ToString();
                command.Parameters.Add("@Rua", SqlDbType.VarChar).Value = Rua.ToString();
                command.Parameters.Add("@Numero", SqlDbType.Int).Value = Convert.ToInt32(Numero);
                command.Parameters.Add("@Complemento", SqlDbType.VarChar).Value = Complemento;
                command.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = Bairro;
                command.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = Cidade.ToString();
                command.Parameters.Add("@Estado", SqlDbType.VarChar).Value = Estado.ToString();
                command.Parameters.Add("@Pais", SqlDbType.VarChar).Value = Pais.ToString();
                command.Parameters.Add("@Cpf", SqlDbType.VarChar).Value = Cpf;
                command.Parameters.Add("@Telefone", SqlDbType.Float).Value = Convert.ToDouble(Telefone.Replace("-", "").Replace("(", "").Replace(")", ""));
                
                command.ExecuteNonQuery();

                return "CSPAD1";
            }
            catch (Exception ex)
            {
                Error = ex.Message.ToString();
                return Error;
            }
        }

        public String Delete()
        {
            try
            {
                instance.NovaConexao();

                String query = "delete from tb_contas where Codigo = @Codigo";

                SqlCommand comando = instance.NovoComando(query);

                return "";
            }
            catch (Exception ex)
            {
                _error = ex.Message;

                return "";
            }
            finally
            {
                instance.FechaConexao();
            }
        }

        public String Read()
        {
            return "";
        }

        public string Update()
        {
            return "";
        }
    }
}
