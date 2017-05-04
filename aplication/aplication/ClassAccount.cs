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
        
        public Account()//String username, String password
        {
            //this.Username = username;
            //this.Passoword = password;
        }

        public void Logar()
        {
            this.Status = true;
        }

        public override void Show()
        {
            throw new NotImplementedException();
        }
    }
}
