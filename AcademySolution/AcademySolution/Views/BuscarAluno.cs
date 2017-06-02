using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AcademySolution
{
    public partial class frmBuscarAluno : MetroFramework.Forms.MetroForm
    {
        // nova instancia criada da classe Instance

        Instance instance = new Instance();
        bool att = false;

        public frmBuscarAluno()
        {
            InitializeComponent();
        }

        // botao que faz a busca de cadastros no banco de dados

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // tratamento de buscas de cadastro no banco de dados

            try
            {
                String parametro = "";
                String campo = txbParametro.Text;
                String query = "SELECT * FROM v_alunos WHERE ";

                switch (cbbItemFiltragem.Text)
                {
                    case "Codigo":
                        parametro = "Codigo";
                        query = query + parametro + " = "+campo+";";
                        break;
                    case "Nome":
                        parametro = "Nome";
                        campo = "'%"+campo+"%'";
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
                    MetroFramework.MetroMessageBox.Show(this,"Código do aluno não foi encontrado!","Erro",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
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
                MetroFramework.MetroMessageBox.Show(this,ex.Message,"Erro",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            finally
            {
                instance.FechaConexao();
            }
        }

        // botao que limpa os campos

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        // botao que faz a atualização dos dados do usuario
        
        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            if(att == false)
            {
                att = true;
                txbNome.Enabled = true;
                txbNascimento.Enabled = true;
                txbCpf.Enabled = true;
                txbEmail.Enabled = true;
                txbEstado.Enabled = true;
                txbTelefone.Enabled = true;
                txbRua.Enabled = true;
                txbNumero.Enabled = true;
                txbComplemento.Enabled = true;
                txbCidade.Enabled = true;
                txbBairro.Enabled = true;
                txbPais.Enabled = true;
            }
            else if (att == true)
            {
                att = false;
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

                txbNome.Focus();

                //comando para atualizacao de dados

                String query = "update v_alunos SET Nome = @Nome, DataDeNascimento = @DataDeNascimento, Email = @Email, Rua = @Rua, Numero = @Numero, " +
                            "Complemento = @Complemento, Bairro = @Bairro, Cidade = @Cidade, Estado = @Estado, Pais = @Pais, " +
                            "Cpf = @Cpf, Telefone = @Telefone, DataUpdate = SYSDATETIME() " +
                            "where Codigo = " + txbCodigo.Text;

                //tratamento da atualizacao de dados
                try
                {
                    SqlCommand command = instance.NovoComando(query);

                    command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txbNome.Text;
                    command.Parameters.Add("@DataDeNascimento", SqlDbType.Date).Value = Convert.ToDateTime(txbNascimento.Text.Replace("/", "-"));
                    command.Parameters.Add("@DataUpdate", SqlDbType.Date).Value = DateTime.Now;
                    command.Parameters.Add("@Email", SqlDbType.VarChar).Value = txbEmail.Text.ToString();
                    command.Parameters.Add("@Street", SqlDbType.VarChar).Value = txbRua.Text.ToString();
                    command.Parameters.Add("@Numero", SqlDbType.Int).Value = Convert.ToInt32(txbNumero.Text);
                    command.Parameters.Add("@Complemento", SqlDbType.VarChar).Value = txbComplemento.Text;
                    command.Parameters.Add("@Rua", SqlDbType.VarChar).Value = txbRua.Text;
                    command.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txbBairro.Text;
                    command.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = txbCidade.Text.ToString();
                    command.Parameters.Add("@Estado", SqlDbType.VarChar).Value = txbEstado.Text.ToString();
                    command.Parameters.Add("@Pais", SqlDbType.VarChar).Value = txbPais.Text.ToString();
                    command.Parameters.Add("@Cpf", SqlDbType.VarChar).Value = txbCpf.Text;
                    command.Parameters.Add("@Telefone", SqlDbType.Float).Value = Convert.ToDouble(txbTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", ""));

                    instance.NovaConexao();
                    command.ExecuteNonQuery();

                    MetroFramework.MetroMessageBox.Show(this, "Registro Atualizado Com Exito!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    instance.FechaConexao();
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    txbNome.Focus();
                    instance.FechaConexao();
                }
            }
        }
        
        public void LimparDados()
        {
            txbParametro.Clear();
            txbNome.Clear();
            txbNascimento.Clear();
            txbCpf.Clear();
            txbEmail.Clear();
            txbEstado.Clear();
            txbTelefone.Clear();
            txbRua.Clear();
            txbNumero.Clear();
            txbComplemento.Clear();
            txbCidade.Clear();
            txbBairro.Clear();
            txbPais.Clear();

            btnAtualizar.Enabled = false;
            
        }
    }
}
