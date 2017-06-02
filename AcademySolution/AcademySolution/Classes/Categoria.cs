using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution
{
    public class Categoria:ICrud
    {
        private string codigo;

        public string Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }

        private string nome;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        private string descricao;
        
        public string Descricao {
            get
            {
                return descricao;
            }
            set
            {
                descricao = value;
            }
        }

        public Instance instance = new Instance();

        public string Create(string tb)
        {
            try
            {
                String query = $"insert into {tb} values (@Codigo,@Nome,@Descricao)";

                SqlCommand comando = instance.NovoComando(query);

                comando.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = Codigo;
                comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Nome;
                comando.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = Descricao;

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

        public string Delete(string tb)
        {
            throw new NotImplementedException();
        }

        public string Read(string tb)
        {
            throw new NotImplementedException();
        }

        public string Update(string tb)
        {
            throw new NotImplementedException();
        }
    }
}
