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
        void Create();

        //Leitura
        void Read();

        //Atualização
        void Update();

        //Deleção
        void Delete();
    }
}
