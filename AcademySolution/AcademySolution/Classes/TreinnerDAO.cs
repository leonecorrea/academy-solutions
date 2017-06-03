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
                comando.CommandText = "insert into treinners values @Nome, @Nascimento, SYSDATETIME(), @Categoria, " +
                    "@Email, @Rua, @Numero, @Complemento, @Bairro, @Cidade, @Estado, @Pais, @Cpf, @Telefone;" +
                    "Select @@Identity";

                try
                {
                    comando.Parameters.Add("@Nome", SqlDbType.Text).Value = model.GetNome();
                    comando.Parameters.Add("@Nascimento", SqlDbType.Date).Value = model.GetDataNascimento();
                    comando.Parameters.Add("@Categoria", SqlDbType.Int).Value = model.Categoria.GetId();
                    comando.Parameters.Add("@Email", SqlDbType.Text).Value = model.GetEmail();
                    //comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = model.GetEndereco();
                    comando.Parameters.Add("@Rua", SqlDbType.Text).Value = model.GetRua();
                    comando.Parameters.Add("@Numero", SqlDbType.Text).Value = model.GetNumero();
                    comando.Parameters.Add("@Complemento", SqlDbType.Text).Value = model.GetComplemento();
                    comando.Parameters.Add("@Bairro", SqlDbType.Text).Value = model.GetBairro();
                    comando.Parameters.Add("@Cidade", SqlDbType.Text).Value = model.GetCidade();
                    comando.Parameters.Add("@Estado", SqlDbType.Text).Value = model.GetEstado();
                    comando.Parameters.Add("@Pais", SqlDbType.Text).Value = model.GetPais();
                    comando.Parameters.Add("@Cpf", SqlDbType.Text).Value = model.GetCpf();
                    comando.Parameters.Add("@Telefone", SqlDbType.Text).Value = model.GetTelefone();

                    //model.SetId(int.Parse(comando.ExecuteScalar().ToString()));
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                }
            }
            return model;
        }

        public Treinner atualizar(Treinner model)
        {
            using (SqlCommand comando = _connection.Buscar().CreateCommand())
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "update tb_contas set nome=@Nome,dataDeNascimento=@DataDeNascimento," +
                    "categoria=@Categoria,email=@Email,endereco=@Endereco,cpf=@Cpf,telefone=@Telefone,dateUpdate=SYSDATETIME() where id=@Id;";

                comando.Parameters.Add("@Nome", SqlDbType.Text).Value = model.GetNome();
                comando.Parameters.Add("@Nascimento", SqlDbType.Date).Value = model.GetDataNascimento();
                comando.Parameters.Add("@Categoria", SqlDbType.Int).Value = model.Categoria.GetId();
                comando.Parameters.Add("@Email", SqlDbType.Text).Value = model.GetEmail().ToString();
                //comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = model.GetEndereco();
                comando.Parameters.Add("@Rua", SqlDbType.Text).Value = model.GetRua();
                comando.Parameters.Add("@Numero", SqlDbType.Text).Value = model.GetNumero();
                comando.Parameters.Add("@Complemento", SqlDbType.Text).Value = model.GetComplemento();
                comando.Parameters.Add("@Bairro", SqlDbType.Text).Value = model.GetBairro();
                comando.Parameters.Add("@Cidade", SqlDbType.Text).Value = model.GetCidade();
                comando.Parameters.Add("@Estado", SqlDbType.Text).Value = model.GetEstado();
                comando.Parameters.Add("@Pais", SqlDbType.Text).Value = model.GetPais();
                comando.Parameters.Add("@Cpf", SqlDbType.Text).Value = model.GetCpf();
                comando.Parameters.Add("@Telefone", SqlDbType.Text).Value = model.GetTelefone();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = model.GetId();


                comando.ExecuteNonQuery();
            }
            return model;
        }
        
        public bool remover(Treinner model)
        {
            bool retornar = false;
            using (SqlCommand comando = _connection.Buscar().CreateCommand())
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "delete from tb_contas where id=@id";
                comando.Parameters.Add("@id",SqlDbType.Int).Value = model.GetId();

                if (comando.ExecuteNonQuery()>0)
                {
                    retornar = true;
                }
            }
            return retornar;
        }

        public Treinner localizarPorCodigo(params object[] keys)
        {
            Treinner treinner = null;
            using (SqlCommand comando = _connection.Buscar().CreateCommand())
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select * from tb_contas where id=@id";
                comando.Parameters.Add("@id", SqlDbType.Int).Value = keys[0];

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        treinner = new Treinner();
                        reader.Read();

                        treinner.SetId(reader.GetInt32(0));
                        treinner.SetNome(reader.GetString(1));
                        treinner.SetDataNascimento(reader.GetString(2));
                        treinner.Categoria.SetId(reader.GetInt32(3));
                        treinner.SetEmail(reader.GetString(4));
                        //treinner.SetEndereco(reader.GetString(5));
                        treinner.SetRua(reader.GetString(5));
                        treinner.SetNumero(reader.GetString(6));
                        treinner.SetComplemento(reader.GetString(7));
                        treinner.SetBairro(reader.GetString(8));
                        treinner.SetCidade(reader.GetString(9));
                        treinner.SetEstado(reader.GetString(10));
                        treinner.SetPais(reader.GetString(11));
                        treinner.SetCpf(reader.GetString(12));
                        treinner.SetTelefone(reader.GetString(13));
                    }
                }
            }
            return treinner;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ICollection<Treinner> ListarTudo()
        {
            throw new NotImplementedException();
        }
    }
}
