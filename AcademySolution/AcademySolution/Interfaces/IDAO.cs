using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution
{
    //Estou criando uma interface tipada, ou seja posso utilizar qualquer
    //entidade nela, não especificamente uma: Aluno, Fixa, Treinner
    interface IDAO<T>:IDisposable
        where T: class, new()
    {
        //Método para inserir
        T inserir(T model);
        //Método para atualizar
        T atualizar(T model);
        //Método para remover
        bool remover(T model);
        //Método para procurar um registro específico
        T localizarPorCodigo(params Object[] keys);
        //Método para localizar todos
        ICollection<T> ListarTudo();
    }
}
