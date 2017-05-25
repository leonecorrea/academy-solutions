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
        public String _error;
        public String Codigo { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String Email { get; set; }
        public String Nascimento { get; set; }
        public String Categoria { get; set; }
        public String Numero { get; set; }
        public String Rua { get; set; }
        public String Complemento { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public String Pais { get; set; }
        public String Telefone { get; set; }

        public Aluno()
        {
            this.Codigo = null;
            this.Nome = null;
            this.Cpf = null;
            this.Email = null;
            this.Nascimento = null;
            this.Categoria = null;
            this.Numero = null;
            this.Rua = null;
            this.Complemento = null;
            this.Bairro = null;
            this.Cidade = null;
            this.Estado = null;
            this.Pais = null;
            this.Telefone = null;
        }

        public void PegaDados(String codigo, String nome, String rua, String email, String bairro, String nascimento, String categoria,
            String numero, String complemento, String cidade, String estado, String pais, String cpf, String telefone)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.Nascimento = nascimento;
            this.Categoria = categoria;
            this.Numero = numero;
            this.Rua = rua;
            this.Complemento = complemento;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Pais = pais;
            this.Telefone = telefone;
        }

        public void ValidaDados()
        {
                if (Nome != "" && Cpf != "" && Email != "" && Nascimento != "" && Categoria != "" &&
                    Numero != "" && Rua != "" && Complemento != "" && Bairro != "" && Cidade != "" && Cidade != "" &&
                    Estado != "" && Pais != "" && Telefone != "")
                {
                    _error = "0000";
                }
                else if(Nome == "" || Cpf == "" || Email == "" || Nascimento == "" || Categoria == "" ||
                    Numero == "" || Rua == "" || Complemento == "" || Bairro == "" || Cidade == "" || Cidade == "" ||
                    Estado == "" || Pais == "" || Telefone == "")
                {
                    _error = "0001";
                }
                else
                {
                    _error = "0002";
                }
        }

        public void Create()
        {
            try
            {
                String query = "insert into tb_contas(Nome, DataNasc, DataRegistro, Categoria, Email, Rua, Numero, " +
                    "Complemento, Bairro, Cidade, Estado, Pais, Cpf, Telefone,DataUpdate) " +
                    "values(@Nome, @DateBirth, SYSDATETIME(), @Categoria, @Email, @Rua, @Numero, @Complemento, @Bairro, " +
                    "@Cidade, @Estado, @Country, @Cpf, @Telefone,SYSDATETIME())";

                SqlCommand command = instance.NovoComando(query);

                command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Nome;
                command.Parameters.Add("@DateBirth", SqlDbType.Date).Value = Nascimento.Replace("/", "-");
                //command.Parameters.Add("@DateRegister", SqlDbType.DateTime).Value = DateTime.Now;
                //command.Parameters.Add("@DataUpdate", SqlDbType.DateTime).Value = DateTime.Now;
                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = Email.ToString();
                command.Parameters.Add("@Categoria", SqlDbType.Int).Value = 1;
                command.Parameters.Add("@Rua", SqlDbType.Int).Value = Convert.ToInt32(Rua);
                command.Parameters.Add("@Numero", SqlDbType.Int).Value = Convert.ToInt32(Numero);
                command.Parameters.Add("@Complemento", SqlDbType.VarChar).Value = Complemento;
                command.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = Bairro.ToString();
                command.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = Cidade.ToString();
                command.Parameters.Add("@Estado", SqlDbType.VarChar).Value = Estado.ToString();
                command.Parameters.Add("@Country", SqlDbType.VarChar).Value = Pais.ToString();
                command.Parameters.Add("@Cpf", SqlDbType.VarChar).Value = Cpf;
                command.Parameters.Add("@Telefone", SqlDbType.Float).Value = Convert.ToDouble(Telefone.Replace("-", "").Replace("(", "").Replace(")", ""));

                instance.NovaConexao();
                command.ExecuteNonQuery();

                this._error = "0010";
            }
            catch (Exception ex)
            {
                this._error = "0011";
                this._error = ex.Message.ToString();
            }
            finally
            {
                instance.FechaConexao();
            }
        }

        public void Delete()
        {
            try
            {
                instance.NovaConexao();

                String query = "delete from tb_contas where Codigo = @Codigo";

                SqlCommand comando = instance.NovoComando(query);
            }
            catch (Exception ex)
            {
                _error = ex.Message;
            }
            finally
            {
                instance.FechaConexao();
            }
        }

        public void Read()
        {
            instance.NovaConexao();

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

        public void Update()
        {
            instance.NovaConexao();
        }
    }
}
