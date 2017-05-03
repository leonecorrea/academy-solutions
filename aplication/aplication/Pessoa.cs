using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution
{
    public abstract class Pessoa
    {
        protected String codigo;

        protected String nome;

        protected String cpf;

        protected String email;

        protected DateTime dataNasc;

        public Pessoa(string codigo, string nome, string cpf, string email, DateTime dataNasc)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.dataNasc = dataNasc;
        }

        public abstract void Show();
    }
}
