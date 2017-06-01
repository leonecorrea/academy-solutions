using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution
{
    public interface ILogavel
    {
        string codLogin
        {
            get;
            set;
        }

        string username
        {
            get;
            set;
        }

        string password
        {
            get;
            set;
        }

        void Logar();

        void Deslogar();
    }
}
