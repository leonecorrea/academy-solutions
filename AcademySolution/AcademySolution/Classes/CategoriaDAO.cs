using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution
{
    public class CategoriaDAO:IDAO<Categoria>,IDisposable
    {
        public CategoriaDAO()
        {

        }

        public Categoria atualizar(Categoria model)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Categoria inserir(Categoria model)
        {
            /*try
            {
                String query = $"insert into {tb} values (@Codigo,@Nome,@Descricao)";

                SqlCommand comando = instance.NovoComando(query);

                comando.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = GetId();
                comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = GetNome();
                comando.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = GetDescricao();

                instance.NovoComando(query).ExecuteNonQuery();

                return "SLEAJDF";
            }
            catch (Exception ex)
            {
                return Convert.ToString(ex.Message);
            }
            finally
            {
                instance.FechaConexao();
            }*/
            return model;
        }

        public ICollection<Categoria> ListarTudo()
        {
            throw new NotImplementedException();
        }

        public Categoria localizarPorCodigo(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public bool remover(Categoria model)
        {
            throw new NotImplementedException();
        }
    }
}
