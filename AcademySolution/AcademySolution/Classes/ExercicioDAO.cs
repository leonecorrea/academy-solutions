using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademySolution.Interfaces;

namespace AcademySolution.Classes
{
    class ExercicioDAO:IDAO<Exercicio>, IDisposable
    {
        private IConnection _connection;
        public ExercicioDAO(IConnection connection)
        {
            this._connection = connection;
        }

        public Exercicio atualizar(Exercicio model)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Exercicio inserir(Exercicio model)
        {
            throw new NotImplementedException();
        }

        public ICollection<Exercicio> ListarTudo()
        {
            throw new NotImplementedException();
        }

        public Exercicio localizarPorCodigo(params object [] keys)
        {
            throw new NotImplementedException();
        }

        public bool remover (Exercicio model)
        {
            throw new NotImplementedException();
        }
    }
}
