using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AcademySolution.Interfaces{
	public interface ICrud{
		//Criação
		String Create(String var);
		//Leitura
		String Read(String var);
		//Atualização
		String Update(String var);
		//Deleção
		String Delete(String var);
	}
}
