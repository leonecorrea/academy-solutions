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
        Instance Instancia();
        String Create(String q);
        String Read();
        String Update();
        String Delete(String q);
    }
}
