using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AcademySolution.Classes
{
    public class TreinnerDAO : IDAO<Treinner>, IDisposable
    {
        //Conexão com o banco
        private IConnection _connection;
        public TreinnerDAO(IConnection Connection)
        {
            this._connection = Connection;
        }

        public Treinner inserir(Treinner model)
        {
            using (SqlCommand comando = _connection.Buscar().CreateCommand())
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "insert into treinners values @Nome,@DataDeNascimento,@Categoria,@Email,@Endereco,@Cpf,@Telefone;Select @@Identity";

                comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = model.GetNome();
                comando.Parameters.Add("@DataDeNascimento", SqlDbType.Date).Value = Convert.ToDateTime(model.GetDataNascimento().Replace("/", "-"));
                comando.Parameters.Add("@Categoria", SqlDbType.Int).Value = Convert.ToInt32(model.GetCategoria());
                comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = model.GetEmail().ToString();
                comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = model.GetEndereco().ToString();
                comando.Parameters.Add("@Cpf", SqlDbType.VarChar).Value = model.GetCpf();
                comando.Parameters.Add("@Telefone", SqlDbType.Float).Value = Convert.ToDouble(model.GetTelefone().Replace("-", "").Replace("(", "").Replace(")", ""));

                model.SetId(int.Parse(comando.ExecuteScalar().ToString()));
            }
            return model;
        }

        public Treinner atualizar(Treinner model)
        {
            using (SqlCommand comando = _connection.Buscar().CreateCommand())
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "update treinner set nome=@Nome,dataDeNascimento=@DataDeNascimento," +
                    "categoria=@Categoria,email=@Email,endereco=@Endereco,cpf=@Cpf,telefone=@Telefone where id=@Id;";

                comando.Parameters.Add("@Nome", SqlDbType.Text).Value = model.GetNome();
                comando.Parameters.Add("@DataDeNascimento", SqlDbType.Date).Value = Convert.ToDateTime(model.GetDataNascimento().Replace("/", "-"));
                comando.Parameters.Add("@Categoria", SqlDbType.Int).Value = Convert.ToInt32(model.GetCategoria());
                comando.Parameters.Add("@Email", SqlDbType.Text).Value = model.GetEmail().ToString();
                comando.Parameters.Add("@Endereco", SqlDbType.Text).Value = model.GetEndereco().ToString();
                comando.Parameters.Add("@Cpf", SqlDbType.Text).Value = model.GetCpf();
                comando.Parameters.Add("@Telefone", SqlDbType.Float).Value = Convert.ToDouble(model.GetTelefone().Replace("-", "").Replace("(", "").Replace(")", ""));
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = model.GetId();


                comando.ExecuteNonQuery();
            }
            return model;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ICollection<Treinner> ListarTudo()
        {
            throw new NotImplementedException();
        }

        public Treinner localizarPorCodigo(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public bool remover(Treinner model)
        {
            throw new NotImplementedException();
        }
    }
}
