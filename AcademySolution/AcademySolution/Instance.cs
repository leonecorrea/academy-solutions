﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AcademySolution
{
    public class Instance
    {
        //Leone Notebook
        //SqlConnection sqlCon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AcademySolution;Data Source=DESKTOP-3NL4KDR\\SQLEXPRESS");

        //Una Lab
        //SqlConnection sqlCon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AcademySolution;Data Source=BRRLI0213");

        //Robert PC
        //SqlConnection sqlCon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AcademySolution;Data Source=ROBERT-PC\\SQLEXPRESS");

        //Gladson PC
        SqlConnection sqlCon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AcademySolution;Data Source=PC-PC\\INSTANCIA_SQL");
        
        public SqlConnection NovaInstancea()
        {
            return sqlCon;
        }
    }
}
