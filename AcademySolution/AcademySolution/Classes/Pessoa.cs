using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySolution.Classes{
	public abstract class Pessoa{

        private int id;

		public int GetId(){
			return id;
		}

		public void SetId(int value){
			Convert.ToInt32(value); 
			this.id = value;
		}

		private String nome;

		public string GetNome(){
			return nome;
		}

		public void SetNome(String value){
			Convert.ToString(value);
			this.nome = value;
		}

		private String nascimento;

		public String GetNascimento(){
			return nascimento;
		}

		public void SetNascimento(String value){
			Convert.ToString(value);
			this.nascimento = value;
		}

		private String dataRegistro;

		public String GetDataRegistro(){
			return dataRegistro;
		}

		public void SetDataRegistro(String value){
			Convert.ToString(value);
			this.dataRegistro = value;
		}

		private String email;

		public String GetEmail(){
			return email;
		}

		public void SetEmail(String value){
			Convert.ToString(value);
			this.email = value;
		}

		private String cpf;

		public String GetCpf(){
			return cpf;
		}

		public void SetCpf(string value){
			Convert.ToString(value);
			this.cpf = value;
		}

		private String telefone;

		public String GetTelefone(){
			return telefone;
		}

		public void SetTelefone(string value){
			Convert.ToString(value);
			this.telefone = value;
		}

		private DateTime dateUpdate;

		public DateTime GetDataUpdate(){
			return dateUpdate;
		}

		public void SetDateUpdate(DateTime value){
			Convert.ToDateTime(value);
			this.dateUpdate = value;
		}

		private String erro;
		
		public String GetErro(){
			return erro;
		}

		public void SetErro(String value){
			this.erro = value;
        }

        public Categoria Categoria = new Categoria();

        public Endereco Endereco = new Endereco();

        public String Erro { get; set; }

		/*public String GetEndereco()
		{
			return endereco;
		}

		public void SetEndereco(String r, String n, String c, String b, String ci, String e, String p)
		{
			endereco = "Rua: " + r + ", Número: " + n + "Complemento: " + c + ", Bairro: " + b + "Cidade: " + ci + ", Estado: " + e + ", Pais: " + p;
		}*/

        /*public Instance instancia;

		public String Create(String tbname)
		{
			instancia.NovaConexao();
			try
			{
				String query = $"insert into {tbname} values @Nome,@DataDeNascimento,@Categoria,@Email,@Endereco,@Cpf,@Telefone;";
				SqlCommand comando = instancia.NovoComando(query);
				instancia.NovaConexao();

				comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = GetNome();
				comando.Parameters.Add("@DataDeNascimento", SqlDbType.Date).Value = Convert.ToDateTime(GetDataNascimento().Replace("/", "-"));
				comando.Parameters.Add("@Categoria", SqlDbType.Int).Value = Convert.ToInt32(GetCategoria());
				comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = GetEmail().ToString();
				comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = GetEndereco().ToString();
				comando.Parameters.Add("@Cpf", SqlDbType.VarChar).Value = GetCpf();
				comando.Parameters.Add("@Telefone", SqlDbType.Float).Value = Convert.ToDouble(GetTelefone().Replace("-", "").Replace("(", "").Replace(")", ""));

				comando.ExecuteNonQuery();
				return "CSPAD1";
			}
			catch (Exception ex)
			{
				return Convert.ToString(ex.Message);
			}
			finally
			{
				instancia.FechaConexao();
			}
		}
		
		public String Read(String tb)
		{
			return "";
		}

		public String Update(String var)
		{
			try
			{
				instancia.NovaConexao();

				SqlDataReader leituras = instancia.LerDados(var);

				if (leituras.HasRows == false)
				{
					return "Código do aluno não foi encontrado!";
				}
				else
				{
					leituras.Read();

					SetId(Convert.ToString(leituras["Codigo"]));
					SetNome(Convert.ToString(leituras["Nome"]));
					SetDataNascimento(Convert.ToString(leituras["DataDeNascimento"]));
					SetCpf(Convert.ToString(leituras["Cpf"]));
					SetEmail(Convert.ToString(leituras["Email"]));
					//SetEstado(Convert.ToString(leituras["Estado"]);
					SetTelefone(Convert.ToString(leituras["Telefone"]));
					//SetEndereco(Convert.ToString(leituras["Rua"]),Convert.ToString(leituras["Numero"]),Convert.ToString(leituras["Rua"]),Convert.ToString(leituras["Rua"]),Convert.ToString(leituras["Rua"]),Convert.ToString(leituras["Rua"]));
					//SetRua(Convert.ToString(leituras["Rua"]));
					//SetNumero(Convert.ToString(leituras["Numero"]));
					//SetComplemento(Convert.ToString(leituras["Complemento"]));
					//SetCidade(Convert.ToString(leituras["Cidade"]));
					//txbBairro.Text = Convert.ToString(leituras["Bairro"]);
					//txbPais.Text = Convert.ToString(leituras["Pais"]);

					return "ADFADFA";
				}
			}
			catch (Exception ex)
			{
				return Convert.ToString(ex.Message);
			}
			finally
			{
				instancia.FechaConexao();
			}
		}

		public String Delete(String var)
		{
			try
			{
				instancia.NovaConexao();//Cria nova conexão
				String query = $"delete into {var} where ;";//Determina a query a ser executada
				SqlCommand comando = instancia.NovoComando(query);//Abre novo comando na basa de dados

				comando.ExecuteNonQuery();//Executa o comando
				return "CSPAD1";//Retorna valor aleatório para falar que deu certo
			}
			catch (Exception ex)
			{
				SetErro(Convert.ToString(ex));
				return GetErro();//Retorna o valor da Exception de erro em string
			}
			finally
			{
				instancia.FechaConexao();//Fecha a conexão
			}
		}*/
    }
}
