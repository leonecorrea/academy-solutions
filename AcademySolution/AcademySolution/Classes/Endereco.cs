using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution.Classes
{
	public class Endereco
	{
		private String numero;

		public String GetNumero()
		{
			return numero;
		}

		public void SetNumero(string value)
		{
			this.numero = value;
		}

		private String rua;

		public String GetRua()
		{
			return rua;
		}

		public void SetRua(string value)
		{
			this.rua = value;
		}
		private String bairro;

		public String GetBairro()
		{
			return bairro;
		}

		public void SetBairro(string value)
		{
			this.bairro = value;
		}

		private String estado;

		public String GetEstado()
		{
			return estado;
		}

		public void SetEstado(String value)
		{
			this.estado = value;
		}

		private String cidade;

		public String GetCidade()
		{
			return cidade;
		}

		public void SetCidade(String value)
		{
			this.cidade = value;
		}

		private String pais;

		public String GetPais()
		{
			return pais;
		}

		public void SetPais(String value)
		{
			this.pais = value;
		}

		private String complemento;

		public String GetComplemento()
		{
			return complemento;
		}

		public void SetComplemento(String value)
		{
			this.complemento = value;
		}
	}
}