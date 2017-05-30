using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution
{
    public class Treiner : Pessoa
    {
        private String id;

        public override String GetId()
        {
            return id;
        }

        public void SetId(String value)
        {
            id = value;
        }

        private String nome;
        
        public override string GetNome()
        {
            return nome;
        }

        public void SetNome(String value)
        {
            nome = value;
        }

        private String dataNascimento;

        public override String GetDataNascimento()
        {
            return dataNascimento;
        }

        public void SetDataNascimento(String value)
        {
            dataNascimento = value;
        }

        private String dataRegistro;

        public override String GetDataRegistro()
        {
            return dataRegistro;
        }

        public void SetDataRegistro(String value)
        {
            dataRegistro = value;
        }

        private String email;

        public override String GetEmail()
        {
            return dataRegistro;
        }

        public void SetEmail(String value)
        {
            email = value;
        }

        private Categoria categoria;

        public override Categoria GetCategoria()
        {
            return categoria;
        }

        public void SetCategoria(Categoria value)
        {
            categoria = value;
        }

        private String endereco;

        public override String GetEndereco()
        {
            return endereco;
        }

        public void SetEndereco(string r, String n, String b, String c, String e, String p)
        {
            endereco = "Rua: " + r + ", Número: " + n + ", Bairro: " + b + "Cidade: " + c + ", Estado: " + e + ", Pais: " + p;
        }

        private String cpf;

        public override String GetCpf()
        {
            return cpf;
        }

        public void SetCpf(string value)
        {
            cpf = value;
        }

        private String telefone;

        public override String GetTelefone()
        {
            return telefone;
        }

        public void SetTelefone(string value)
        {
            telefone = value;
        }

        private DateTime dateUpdate;

        public override DateTime GetDataUpdate()
        {
            return dateUpdate;
        }

        public void SetDateUpdate(DateTime value)
        {
            dateUpdate = value;
        }

        private String erro;

        public override String GetErro()
        {
            return erro;
        }

        public void SetErro(String value)
        {
            erro = value;
        }

        public override string Create()
        {
            instancia.NovaConexao();
            try
            {
                String query = "";
                SqlCommand comando = instancia.NovoComando(query);
                instancia.NovaConexao();

                comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = GetNome();
                comando.Parameters.Add("@DataDeNascimento", SqlDbType.Date).Value = Convert.ToDateTime(GetDataNascimento().Replace("/", "-"));
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
                instancia.FechaConexao();
            }
        }

        public override string Delete()
        {
            try
            {
                instancia.NovaConexao();//Cria nova conexão
                String query = "";//Determina a query a ser executada
                SqlCommand comando = instancia.NovoComando(query);//Abre novo comando na basa de dados

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
                instancia.FechaConexao();//Fecha a conexão
            }
        }
    }
}