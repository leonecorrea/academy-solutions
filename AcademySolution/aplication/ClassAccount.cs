using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution
{
    public class Account:Person
    {
        public Boolean Status { get; set; }
        public String Username { get; set; }
        public String Passoword { get; set; }
        
        public Account(/*string username, string password*/)
        {
            /*this.Username = username;
            this.Passoword = password;*/
        }

        public void Logar(bool status, string username, string password)
        {
            this.Status = true;
            this.Username = username;
            this.Passoword = password;
        }

        public override void Show()
        {
            throw new NotImplementedException();
        }
    }
}
