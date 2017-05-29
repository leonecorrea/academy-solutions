using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution
{
    public class Categoria
    {
        private string codigo;
        private string nome;
        private string descricao;

        public string Codigo {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }

        public string Nome {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public string Descricao {
            get
            {
                return descricao;
            }
            set
            {
                descricao = value;
            }
        }
    }
}
