using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution
{
    public class CategoriaDAO:IDAO<Categoria>,IDisposable
    {
        public CategoriaDAO()
        {

        }

        public Categoria atualizar(Categoria model)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Categoria inserir(Categoria model)
        {
            throw new NotImplementedException();
        }

        public ICollection<Categoria> ListarTudo()
        {
            throw new NotImplementedException();
        }

        public Categoria localizarPorCodigo(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public bool remover(Categoria model)
        {
            throw new NotImplementedException();
        }
    }
}
