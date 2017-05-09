using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution
{
    public class Account : Person
    {
        public Boolean Status { get; set; }
        public String Username { get; set; }
        public String Passoword { get; set; }
        public int Nivel { get; set; }
        public Login Login = new Login();
        
        public Account(int codigo, string nome, string idade, string cpf)
        {
            this.Codigo = codigo;
            this.Cpf = cpf;
            this.Nome = nome;
        }

        public void Logar(bool status, string username, string password)
        {

            this.Login.ValidaLogin(username, password);
        }

        public override void Show()
        {
            throw new NotImplementedException();
        }
    }
}
