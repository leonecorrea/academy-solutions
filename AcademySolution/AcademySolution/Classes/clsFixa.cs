using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution
{
    class Fixa
    {
        private String id;
        private String nome;
        private String idAluno;
        private String idTreiner;

        public Instance instance = new Instance();

        public string Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string IdAluno { get { return idAluno; } set { idAluno = value; } }
        public string IdTreiner { get { return idTreiner; } set { idTreiner = value; } }
        public string Error { get; set; }

        public string CreateFicha()
        {
            return "";
        }

        public string ExcluirFicha(string parametro)
        {
            try
            {
                instance.NovaConexao();

                

                string query = "delete from tb_record where IdRecord ="+parametro+"";

                SqlCommand comando = instance.NovoComando(query);

                comando.ExecuteNonQuery();

                return "ok";
            }

            catch
            {
                Error = "Erro";
                return Error;
            }
            finally
            {
                instance.FechaConexao();
            }
         
        }

    }
}
