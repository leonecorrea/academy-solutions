using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution
{
    public abstract class Pessoa : ICrud
    {
        private string nome;

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string value)
        {
            nome = value;
        }

        private string id;

        public string GetId()
        {
            return id;
        }

        public void SetId(string value)
        {
            id = value;
        }

        private string dataNasc;

        public string GetDataNasc()
        {
            return dataNasc;
        }

        public void SetDataNasc(string value)
        {
            dataNasc = value;
        }

        private string dataRegistro;

        public string GetDataRegistro()
        {
            return dataRegistro;
        }

        public void SetDataRegistro(string value)
        {
            dataRegistro = value;
        }

        private string email;

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string value)
        {
            email = value;
        }

        private Categoria categoria = new Categoria();

        private string endereco;

        public string GetEndereco()
        {
            return endereco;
        }

        public void SetEndereco(string r,String n,String b, String c, String e, String p)
        {
            endereco = "Rua: " + r + ", Número: " + n + ", Bairro: " + b + "Cidade: " + c + ", Estado: " + e + ", Pais: " + p;
        }

        private string cpf;

        public string GetCpf()
        {
            return cpf;
        }

        public void SetCpf(string value)
        {
            cpf = value;
        }

        private string telefone;

        public string GetTelefone()
        {
            return telefone;
        }

        public void SetTelefone(string value)
        {
            telefone = value;
        }

        private DateTime dataUpdate;

        public DateTime GetDataUpdate()
        {
            return dataUpdate;
        }

        public void SetDataUpdate(DateTime value)
        {
            dataUpdate = value;
        }

        public Categoria GetCategoria()
        {
            return categoria;
        }

        public void SetCategoria(Categoria value)
        {
            categoria = value;
        }

        private String erro;

        public string GetErro()
        {
            return erro;
        }

        public void SetErro(string value)
        {
            erro = value;
        }

        public abstract Instance Instancia();

        public string Create(String q)
        {
            Instancia().NovaConexao();
            try
            {
                String query = q;
                SqlCommand comando = Instancia().NovoComando(q);
                Instancia().NovaConexao();

                comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = GetNome();
                comando.Parameters.Add("@DataDeNascimento", SqlDbType.Date).Value = Convert.ToDateTime(GetDataNasc().Replace("/", "-"));
                comando.Parameters.Add("@Categoria", SqlDbType.Int).Value = Convert.ToInt32(GetCategoria());
                comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = GetEmail().ToString();
                comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = GetEndereco().ToString();
                comando.Parameters.Add("@Cpf", SqlDbType.VarChar).Value = GetCpf();
                comando.Parameters.Add("@Telefone", SqlDbType.Float).Value = Convert.ToDouble(GetTelefone().Replace("-", "").Replace("(", "").Replace(")", ""));

                comando.ExecuteNonQuery();
                return "CSPAD1";
            }
            catch (Exception ex)
            {
                return Convert.ToString(ex.Message);
            }
            finally
            {
                Instancia().FechaConexao();
            }
        }

        public string Read()
        {
            throw new NotImplementedException();
        }

        public string Update()
        {
            throw new NotImplementedException();
        }

        public string Delete(String q)
        {
            try
            {
                Instancia().NovaConexao();//Cria nova conexão
                String query = q;//Determina a query a ser executada
                SqlCommand comando = Instancia().NovoComando(query);//Abre novo comando na basa de dados

                comando.ExecuteNonQuery();//Executa o comando
                return "CSPAD1";//Retorna valor aleatório para falar que deu certo
            }
            catch (Exception ex)
            {
                erro = Convert.ToString(ex);
                return GetErro();//Retorna o valor da Exception de erro em string
            }
            finally
            {
                Instancia().FechaConexao();//Fecha a conexão
            }
        }
    }
}
