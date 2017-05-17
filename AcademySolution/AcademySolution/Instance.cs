using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AcademySolution
{
    public class Instance : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlCon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AcademySolution;Data Source=DESKTOP-3NL4KDR\\SQLEXPRESS");
        
        public void connection()
        {
            try
            {
                sqlCon.Open();
                //MetroFramework.MetroMessageBox.Show(this, "Conexão feita com sucesso!");
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this,ex.Message);
            }
            /*finally
            {
                sqlCon.Close();
                MetroFramework.MetroMessageBox.Show(this,"Conexão finalizada!");

            }*/
        }
    }
}
