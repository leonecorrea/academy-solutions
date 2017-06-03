using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution
{
    public class Categoria
    {
        private int id;

        public int GetId()
        {
            return id;
        }

        public void SetId(int value)
        {
            this.id = value;
        }

        private string nome;

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(String value)
        {
            this.nome = value;
        }

        private String descricao;
        
        public String GetDescricao()
        {
                return descricao;
        }

        public void SetDescricao(String value)
        {
            this.descricao = value;
        }

        public Instance instance = new Instance();

        public string Create(string tb)
        {
            try
            {
                String query = $"insert into {tb} values (@Codigo,@Nome,@Descricao)";

                SqlCommand comando = instance.NovoComando(query);

                comando.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = GetId();
                comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = GetNome();
                comando.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = GetDescricao();

                instance.NovoComando(query).ExecuteNonQuery();

                return "SLEAJDF";
            }
            catch(Exception ex)
            {
                return Convert.ToString(ex.Message);
            }
            finally
            {
                instance.FechaConexao();
            }
        }
    }
}
