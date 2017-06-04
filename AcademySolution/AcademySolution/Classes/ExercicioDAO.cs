using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademySolution.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace AcademySolution.Classes
{
    class ExercicioDAO:IDAO<Exercicio>, IDisposable
    {
        private IConnection _connection;
        public ExercicioDAO(IConnection connection)
        {
            this._connection = connection;
        }

        public Exercicio atualizar(Exercicio model)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Exercicio inserir(Exercicio model)
        {
            try
            {
                String query = "insert into tb_exercises(Name, Description) values(@nomeExercicio, @descricaoExercicio);SELECT @@IDENTITY";
                SqlCommand comando = _connection.Buscar().CreateCommand();

                comando.CommandText = query;

                comando.Parameters.Add("@nomeExercicio", SqlDbType.Text).Value = model.getNomeExercicio();
                comando.Parameters.Add("@descricaoExercicio", SqlDbType.Text).Value = model.getDescricaoExercicio();

                model.setId(Convert.ToInt32(comando.ExecuteScalar()));
                
                return model;
            }catch(Exception ex)
            {
                model.Erro = ex.Message.ToString();
                Console.WriteLine(ex.Message);
                return model;
            }
        }

        public ICollection<Exercicio> ListarTudo()
        {
            throw new NotImplementedException();
        }

        public Exercicio localizarPorCodigo(params object [] keys)
        {
            throw new NotImplementedException();
        }

        public bool remover (Exercicio model)
        {
            throw new NotImplementedException();
        }
    }
}
