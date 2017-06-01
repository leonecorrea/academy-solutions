using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AcademySolution
{
    public interface IConnection:IDisposable
    {
        //Método para abrir a conexão
        SqlConnection Abrir();
        //Método para buscar
        SqlConnection Buscar();
        //Fechar a conexão
        void Fechar();
    }
}
