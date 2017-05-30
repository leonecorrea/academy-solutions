using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution
{
    public abstract class Pessoa : ICrud
    {
        public abstract String GetNome();

        public abstract String GetId();
        
        public abstract String GetDataRegistro();

        public abstract String GetDataNascimento();

        public abstract String GetEmail();

        public abstract Categoria GetCategoria();

        public abstract String GetEndereco();

        public abstract String GetCpf();

        public abstract String GetTelefone();

        public abstract DateTime GetDataUpdate();

        public abstract String GetErro();

        public Instance instancia;

        public abstract string Create();

        public abstract string Read();

        public abstract string Update();

        public abstract string Delete();
    }
}
