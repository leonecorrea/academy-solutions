using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution
{
    public class Student : Person
    {
        public String CodFixa;

        public Student(int codigo, String nome, String cpf, String email, DateTime datanasc)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.DataNasc = datanasc;
        }

        public override void Show()
        {
            
        }
    }
}
