using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AcademySolution.Classes
{
    public class TreinnerDAO : IDAO<Treinner>, IDisposable
    {
        //Conexão com o banco
        private IConnection _connection;
        public TreinnerDAO(IConnection Connection)
        {
            //this._connection = Connection;
            _connection = Connection;
        }

        public Treinner atualizar(Treinner model)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Treinner inserir(Treinner model)
        {
            using (SqlCommand comando = _connection.Buscar().CreateCommand() )
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "insert into tb_treinner";

                comando.Parameters.Add();
            }
            return model;
        }

        public ICollection<Treinner> ListarTudo()
        {
            throw new NotImplementedException();
        }

        public Treinner localizarPorCodigo(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public bool remover(Treinner model)
        {
            throw new NotImplementedException();
        }
    }
}
