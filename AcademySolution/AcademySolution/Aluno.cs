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
    class Aluno : IPessoa
    {
        public Instance instance = new Instance();
        private String _error;
        private String _codigo;
        private String _nome;
        private String _cpf;
        private String _email;
        private String _nascimento;
        private String _categoria;
        private String _numero;
        private String _rua;
        private String _complemento;
        private String _bairro;
        private String _cidade;
        private String _estado;
        private String _pais;
        private String _telefone;
        
        public String Codigo{get => _codigo; set => _codigo = value; }
        public String Nome { get => _nome; set => _nome = value; }
        public String Cpf { get => _cpf; set => _cpf = value; }
        public String Email { get => _email; set => _email = value; }
        public String Categoria { get => _categoria; set => _categoria = value; }
        public String Numero { get => _numero; set => _numero = value; }
        public String Rua { get => _rua; set => _rua = value; }
        public String Complemento { get => _complemento; set => _complemento = value; }
        public String Bairro { get => _bairro; set => _bairro = value; }
        public String Cidade { get => _cidade; set => _cidade = value; }
        public String Estado { get => _estado; set => _estado = value; }
        public String Pais { get => _pais; set => _pais = value; }
        public String Telefone { get => _telefone; set => _telefone = value; }
        public String Nascimento { get => _nascimento; set => _nascimento = value; }
        public string Error { get => _error; set => _error = value; }

        public Aluno()
        {

        }

        /*public void PegaDados(String codigo, String nome, String rua, String email, String bairro, String nascimento, String categoria,
            String numero, String complemento, String cidade, String estado, String pais, String cpf, String telefone)
        {
            Codigo = codigo;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Nascimento = nascimento;
            Categoria = categoria;
            Numero = numero;
            Rua = rua;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
            Telefone = telefone;
        }*/

        public String Create()
        {
            try
            {
                String query = "insert into tb_contas(Nome, DataNasc, DataRegistro, Categoria, Email, Rua, Numero, " +
                    "Complemento, Bairro, Cidade, Estado, Pais, Cpf, Telefone) " +
                    "values(@Nome, @DataDeNascimento, SYSDATETIME(), @Categoria, @Email, @Rua, @Numero, @Complemento, @Bairro, " +
                    "@Cidade, @Estado, @Pais, @Cpf, @Telefone)";

                SqlCommand command = instance.NovoComando(query);

                command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Nome;
                command.Parameters.Add("@DataDeNascimento", SqlDbType.Date).Value = Convert.ToDateTime(Nascimento.Replace("/", "-"));
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

                instance.NovaConexao();
                command.ExecuteNonQuery();

                return "CSPAD1";
            }
            catch (Exception ex)
            {
                Error = ex.Message.ToString();
                return Error;
            }
        }

        public String Delete()
        {
            try
            {
                instance.NovaConexao();

                String query = "delete from tb_contas where Codigo = @Codigo";

                SqlCommand comando = instance.NovoComando(query);

                return "";
            }
            catch (Exception ex)
            {
                _error = ex.Message;

                return "";
            }
            finally
            {
                instance.FechaConexao();
            }
        }

        public String Read()
        {
            instance.NovaConexao();

            return "";
            /*try
            {
                String parametro = "";
                String campo = txbParametro.Text;
                String query = "SELECT * FROM v_alunos WHERE ";

                switch (cbbItemFiltragem.Text)
                {
                    case "Codigo":
                        parametro = "Codigo";
                        query = query + parametro + " = " + campo + ";";
                        break;
                    case "Nome":
                        parametro = "Nome";
                        campo = "'%" + campo + "%'";
                        query = query + parametro + " LIKE " + campo + ";";
                        break;
                    case "Cpf":
                        parametro = "Cpf";
                        query = query + parametro + " = " + campo + ";";
                        break;
                    default:
                        query = "select * from v_alunos;";
                        break;
                }

                instance.NovaConexao();

                //instance.NovoComando(query).Parameters.Add("@Codigo", SqlDbType.Int).Value = Convert.ToInt32(txbParametro.Text);

                SqlDataReader leituras = instance.LerDados(query);

                if (leituras.HasRows == false)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Código do aluno não foi encontrado!", "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    LimparDados();
                }
                else
                {
                    leituras.Read();

                    txbCodigo.Text = Convert.ToString(leituras["Codigo"]);
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
        }

        public string Update()
        {
            instance.NovaConexao();

            return "";
        }
    }
}
