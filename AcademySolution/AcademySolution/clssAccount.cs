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
        
        public Account()
        {
            this.Codigo = Login.Codigo;
        }

        public void Logar(bool status, string username, string password)
        {

            this.Login.ValidaLogin(username, password);
        }
    }
}
