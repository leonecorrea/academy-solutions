using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution.Classes
{
    class Exercicio
    {
        private int id;

        public int getId()
        {
            return id;
        }

        public void setId(int value)
        {
            this.id = Convert.ToInt32(value);
        }

        private string nomeExercicio;

        public string getNomeExercicio()
        {
            return nomeExercicio;
        }

        public void setNomeExercicio(string value)
        {
            this.nomeExercicio = value;
        }

        private string descricaoExercicio;

        public string getDescricaoExercicio()
        {
            return descricaoExercicio;
        }

        public void setDescricaoExercicio(string value)
        {
            this.descricaoExercicio = value;
        }

    }
}
