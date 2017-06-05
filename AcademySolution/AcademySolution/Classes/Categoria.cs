using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution.Classes
{
	public class Categoria
	{
		private int id;

		public int GetId()
		{
			return id;
		}

		public void SetId(int value)
		{
			this.id = value;
		}

		private string nome;

		public string GetNome()
		{
			return nome;
		}

		public void SetNome(String value)
		{
			this.nome = value;
		}

		private String descricao;
		
		public String GetDescricao()
		{
				return descricao;
		}

		public void SetDescricao(String value)
		{
			this.descricao = value;
		}

        public Categoria(){
            this.nome = null;
            this.descricao = null;
        }
	}
}
