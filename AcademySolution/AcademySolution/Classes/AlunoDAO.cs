using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution
{
    public class AlunoDAO:IDAO<Aluno>,IDisposable
    {
        private IConnection _connection;
        public AlunoDAO(IConnection Connection)
        {
            this._connection = Connection;
        }

        public Aluno atualizar(Aluno model)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Aluno inserir(Aluno model)
        {
            throw new NotImplementedException();
        }

        public ICollection<Aluno> ListarTudo()
        {
            throw new NotImplementedException();
        }

        public Aluno localizarPorCodigo(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public bool remover(Aluno model)
        {
            throw new NotImplementedException();
        }
    }
}
