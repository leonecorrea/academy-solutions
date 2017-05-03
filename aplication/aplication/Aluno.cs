using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution
{
    public class Aluno : Pessoa
    {
        private int Codigo {
            get => Codigo;
            set => Codigo = value;
        }

        public Aluno(string codigo, string nome, string cpf, string email, DateTime dataNasc) : base(codigo, nome, cpf, email, dataNasc) {}

        public override void Show()
        {
            //throw new NotImplementedException();
            //System.Windows.Forms.MessageBox("Name : " + codigo);
        }
    }
}
