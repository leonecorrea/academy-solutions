using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AcademySolution
{
    public interface ICrud
    {
        //Criação
        String Create(String tb);
        //Leitura
        String Read(String tb);
        //Atualização
        String Update(String tb);
        //Deleção
        String Delete(String tb);
    }
}
