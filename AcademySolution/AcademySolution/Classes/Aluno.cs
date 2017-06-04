using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AcademySolution.Classes{
	// classe aluno que herda da interface IPessoa

	public class Aluno : Pessoa	{
		public Instance instance = new Instance();
		public string Codigo { get; set; }
		public string Nome { get; set; }
		public string Cpf { get; set; }
		public string Email { get; set; }
		//public string Categoria { get; set; }
		public string Numero { get; set; }
		public string Rua { get; set; }
		public string Complemento { get; set; }
		public string Bairro { get; set; }
		public string Cidade { get; set; }
		public string Estado { get; set; }
		public string Pais { get; set; }
		public string Telefone { get; set; }
		public string Nascimento { get; set; }
		public string Error { get; set; }

		//metodo  create que é herdado e IPessoa que implementa o cadastro de novos usuarios no sistema

		public string Create()
		{
			try
			{
				string query = "insert into tb_contas (Nome, DataNasc, DataRegistro, Categoria, Email, Rua, Numero, " +
					"Complemento, Bairro, Cidade, Estado, Pais, Cpf, Telefone) " +
					"values(@Nome, @DataDeNascimento, SYSDATETIME(), @Categoria, @Email, @Rua, @Numero, @Complemento, @Bairro, " +
					"@Cidade, @Estado, @Pais, @Cpf, @Telefone)";

				SqlCommand command = instance.NovoComando(query);

				instance.NovaConexao();

				command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Nome;
				command.Parameters.Add("@DataDeNascimento", SqlDbType.Date).Value = Nascimento;
				command.Parameters.Add("@Categoria", SqlDbType.Int).Value = Convert.ToInt32(1);
				command.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email.ToString();
				command.Parameters.Add("@Rua", SqlDbType.VarChar).Value = Rua.ToString();
				command.Parameters.Add("@Numero", SqlDbType.Int).Value = Convert.ToInt32(Numero);
				command.Parameters.Add("@Complemento", SqlDbType.VarChar).Value = Complemento;
				command.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = Bairro;
				command.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = Cidade.ToString();
				command.Parameters.Add("@Estado", SqlDbType.VarChar).Value = Estado.ToString();
				command.Parameters.Add("@Pais", SqlDbType.VarChar).Value = Pais.ToString();
				command.Parameters.Add("@Cpf", SqlDbType.VarChar).Value = Cpf;
				command.Parameters.Add("@Telefone", SqlDbType.Float).Value = Convert.ToDouble(Telefone.Replace("-", "").Replace("(", "").Replace(")", ""));
				
				command.ExecuteNonQuery();

				return "CSPAD1";
			}
			catch (Exception ex)
			{
				Error = ex.Message.ToString();
				return Error;
			}
		}

		//metodo  delete que é herdado e Pessoa que implementa a exclusão de usuarios no sistema
		public string Delete(string parametro){
			try{
				instance.NovaConexao();

				string query = "delete from tb_contas where Id ="+parametro+" ";
				
				SqlCommand comando = instance.NovoComando(query);

				comando.ExecuteNonQuery();
				return "ok";
			}catch (Exception ex){
				Error = ex.Message;

				return "";
			}finally{
				instance.FechaConexao();
			}
		}

		//metodo  read que é herdado e IPessoa que implementa a leitura usuarios no sistema
		public string Read(string var){
			/*try{
				instance.NovaConexao();

				SqlDataReader leituras = instance.LerDados(var);

				if (leituras.HasRows == false){
					return "Código do aluno não foi encontrado!";
				}else{
					leituras.Read();

					SetCodigo(Convert.Tostring(leituras["Codigo"]));
					txbNome.Text = Convert.Tostring(leituras["Nome"]);
					txbNascimento.Text = Convert.Tostring(leituras["DataDeNascimento"]);
					txbCpf.Text = Convert.Tostring(leituras["Cpf"]);
					txbEmail.Text = Convert.Tostring(leituras["Email"]);
					txbEstado.Text = Convert.Tostring(leituras["Estado"]);
					txbTelefone.Text = Convert.Tostring(leituras["Telefone"]);
					txbRua.Text = Convert.Tostring(leituras["Rua"]);
					txbNumero.Text = Convert.Tostring(leituras["Numero"]);
					txbComplemento.Text = Convert.Tostring(leituras["Complemento"]);
					txbCidade.Text = Convert.Tostring(leituras["Cidade"]);
					txbBairro.Text = Convert.Tostring(leituras["Bairro"]);
					txbPais.Text = Convert.Tostring(leituras["Pais"]);

					txbNome.Enabled = false;
					txbNascimento.Enabled = false;
					txbCpf.Enabled = false;
					txbEmail.Enabled = false;
					txbEstado.Enabled = false;
					txbTelefone.Enabled = false;
					txbRua.Enabled = false;
					txbNumero.Enabled = false;
					txbComplemento.Enabled = false;
					txbCidade.Enabled = false;
					txbBairro.Enabled = false;
					txbPais.Enabled = false;

					btnAtualizar.Enabled = true;

				}
			}
			catch (Exception ex){
				MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
			}
			finally{
				instance.FechaConexao();
			}*/
			return "";
		}

		//metodo  update que é herdado e IPessoa que implementa a modificacao de cadastros de 
		//usuarios no sistema

		public string Update()
		{
			return "";
		}
	}
}
