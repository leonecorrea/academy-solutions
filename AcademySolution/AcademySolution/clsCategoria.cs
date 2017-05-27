using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution
{
    public class Categoria
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        
        public Categoria(int codigo, string nome, string descricao)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Descricao = descricao;
        }
    }
}
