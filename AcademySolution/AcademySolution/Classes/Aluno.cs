using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AcademySolution
{
    // classe aluno que herda da interface IPessoa

    public class Aluno : Pessoa
    {
        public Instance instance = new Instance();
        public String Codigo { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String Email { get; set; }
        public String Categoria { get; set; }
        public String Numero { get; set; }
        public String Rua { get; set; }
        public String Complemento { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public String Pais { get; set; }
        public String Telefone { get; set; }
        public String Nascimento { get; set; }
        public string Error { get; set; }

        //metodo  create que é herdado e IPessoa que implementa o cadastro de novos usuarios no sistema

        public String Create()
        {
            try
            {
                String query = "insert into tb_contas(Nome, DataNasc, DataRegistro, Categoria, Email, Rua, Numero, " +
                    "Complemento, Bairro, Cidade, Estado, Pais, Cpf, Telefone) " +
                    "values(@Nome, @DataDeNascimento, SYSDATETIME(), @Categoria, @Email, @Rua, @Numero, @Complemento, @Bairro, " +
                    "@Cidade, @Estado, @Pais, @Cpf, @Telefone)";

                SqlCommand command = instance.NovoComando(query);

                instance.NovaConexao();

                command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Nome;
                command.Parameters.Add("@DataDeNascimento", SqlDbType.Date).Value = GetDataNascimento();
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

        public String Delete(string parametro)
        {
            try
            {
                instance.NovaConexao();

                String query = "delete from tb_contas where Id ="+parametro+" ";

                
                SqlCommand comando = instance.NovoComando(query);

                comando.ExecuteNonQuery();
                return "ok";
            }
            catch (Exception ex)
            {
                Error = ex.Message;

                return "";
            }
            finally
            {
                instance.FechaConexao();
            }
        }

        //metodo  read que é herdado e IPessoa que implementa a leitura usuarios no sistema

        public String Read(String var)
        {
            /*try
            {
                instance.NovaConexao();

                SqlDataReader leituras = instance.LerDados(var);

                if (leituras.HasRows == false)
                {
                    return "Código do aluno não foi encontrado!";
                }
                else
                {
                    leituras.Read();

                    SetCodigo(Convert.ToString(leituras["Codigo"]));
                    txbNome.Text = Convert.ToString(leituras["Nome"]);
                    txbNascimento.Text = Convert.ToString(leituras["DataDeNascimento"]);
                    txbCpf.Text = Convert.ToString(leituras["Cpf"]);
                    txbEmail.Text = Convert.ToString(leituras["Email"]);
                    txbEstado.Text = Convert.ToString(leituras["Estado"]);
                    txbTelefone.Text = Convert.ToString(leituras["Telefone"]);
                    txbRua.Text = Convert.ToString(leituras["Rua"]);
                    txbNumero.Text = Convert.ToString(leituras["Numero"]);
                    txbComplemento.Text = Convert.ToString(leituras["Complemento"]);
                    txbCidade.Text = Convert.ToString(leituras["Cidade"]);
                    txbBairro.Text = Convert.ToString(leituras["Bairro"]);
                    txbPais.Text = Convert.ToString(leituras["Pais"]);

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
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
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
