using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution

    // interface IPessoa que contem os metodos de Criação, leitura, Alteração e Exclusão.
{
    public interface IPessoa
    {
        //Criação
        String Create();

        //Leitura
        String Read();

        //Atualização
        String Update();

        //Deleção
        String Delete(string p);
    }
}
