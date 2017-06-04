using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademySolution.Interfaces;

namespace AcademySolution.Classes
{
	class Connection : IConnection, IDisposable
	{
		//Instanciar a classe de conexão
		private SqlConnection _connection;
		public Connection()
		{
			//_connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AcademySolution;Data Source=BRRLI0204");
			//_connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AcademySolution;Data Source=DESKTOP-3NL4KDR\\SQLEXPRESS");
            _connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AcademySolution;Data Source=PC-PC\\INSTANCIA_SQL");
        }
		public SqlConnection Abrir()
		{
			if (_connection.State == ConnectionState.Closed)
			{
				_connection.Open();
			}
			return _connection;
		}

		public SqlConnection Buscar()
		{
			return this.Abrir();
		}

        public SqlCommand NovoComando(string q)
        {
            SqlCommand comando = new SqlCommand(q,_connection);
            return comando;
        }

		public void Fechar()
		{
			if (_connection.State == ConnectionState.Open)
			{
				_connection.Close();
			}
		}

		public void Dispose()
		{
			this.Fechar();
			GC.SuppressFinalize(this);
		}
	}
}
//http://padraodao.blogspot.com.br/2014/05/como-criar-uma-aplicacao-com-padrao-dao.html