using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution
{
    public abstract class Person
    {
        public int Codigo;

        public String Nome;

        public String Cpf;

        public String Email;

        public DateTime DataNasc;

        public Person() { }

        public abstract void Show();
    }
}
