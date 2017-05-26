using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution
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
        String Delete();
    }
}
