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

        Instance instance = new Instance();

        public frmBuscarAluno()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                String parametro = "";
                String campo = txbParametro.Text;
                String query = "SELECT * FROM v_alunos WHERE ";

                switch (cbbItemFiltragem.Text)
                {
                    case "Código":
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
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
            btnDeletar.Enabled = false;
        }

        public void Atualizar(SqlDataReader leituras)
        {
            String query = "UPDATE v_alunos SET Nome = '@Nome', Cpf = '@Cpf',DataAtualizacao = " + DateTime.Now +",Email = '@Email'," +
                " Rua = '', Numero = '', Cidade = '', Pais = '', Telefone = '', Complemento = '' WHERE Codigo = '103';";

            try
            {
                leituras.Read();

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
            }
            catch ()
            {

            }
        }
        
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }
    }
}
