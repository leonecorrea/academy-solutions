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
    public partial class frmRegistrarConta : MetroFramework.Forms.MetroForm
    {
        public frmRegistrarConta()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Instance instance = new Instance();

            String query = "insert into tb_contas(Nome, DataNasc, DataRegistro, Categoria, Email, Rua, Numero, Complemento, Bairro, Cidade, Estado, Pais, Cpf, Telefone) " +
                "values(@Name, @DateBirth, @DateRegister, @Cotegoria, @Email, @Street, @Number, @Complemento, @Bairro, @Cidade, @Estado, @Country, @Cpf, @Telefone)";

            SqlCommand comando = instance.NovoComando(query);

            if(
                txbFirstName.Text == "" || txbLastName.Text == "" || txbStreet.Text == "" ||
                txbEmail.Text == "" || txbBairro.Text == "" || txbNascimento.Text == ""
                )
            {
                MetroFramework.MetroMessageBox.Show(this, "Por favor, preencha os campos corretamente!", "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int nivel=0;
                    switch (cbbLevel.Text)
                    {
                        case "Aluno":
                            nivel = 1;
                            break;
                        case "Instrutor":
                            nivel = 2;
                            break;
                        default:
                            nivel = 0;
                            break;
                    }

                    comando.Parameters.Add("@Name", SqlDbType.VarChar).Value = txbFirstName.Text + txbLastName.Text;
                    comando.Parameters.Add("@DateBirth", SqlDbType.Date).Value = txbNascimento.Text.Replace("/", "-");
                    comando.Parameters.Add("@DateRegister", SqlDbType.DateTime).Value = DateTime.Now;
                    comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txbEmail.Text;
                    comando.Parameters.Add("@Categoria", SqlDbType.Int).Value = nivel;
                    comando.Parameters.Add("@Street", SqlDbType.VarChar).Value = txbStreet.Text;
                    comando.Parameters.Add("@Number", SqlDbType.Int).Value = txbNumber.Text;
                    comando.Parameters.Add("@Complemento", SqlDbType.VarChar).Value = txbComplemento.Text;
                    comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txbBairro.Text;
                    comando.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = cbbCidade.Text;
                    comando.Parameters.Add("@Estado", SqlDbType.VarChar).Value = cbbPlace.Text;
                    comando.Parameters.Add("@Country", SqlDbType.VarChar).Value = cbbCountry.Text;
                    comando.Parameters.Add("@Cpf", SqlDbType.VarChar).Value = tbxCpf.Text;
                    comando.Parameters.Add("@Telefone", SqlDbType.Float).Value = Convert.ToDouble(tbxTelefone.Text.Replace("-", ""));

                    instance.NovaConexao();
                    comando.ExecuteNonQuery();
                    MetroFramework.MetroMessageBox.Show(this, "Registro Concluido Com Exito!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
                finally
                {
                    instance.FechaConexao();
                    txbFirstName.Clear();
                    txbLastName.Clear();
                    txbNascimento.Clear();
                    cbbLevel.Text = "";
                    txbEmail.Clear();
                    cbbCountry.Text = "";
                    cbbCidade.Text = "";
                    txbComplemento.Clear();
                    cbbPlace.Text = "";
                    txbStreet.Clear();
                    txbNumber.Clear();
                    tbxCpf.Clear();
                    tbxTelefone.Clear();
                    txbBairro.Clear();
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txbFirstName.Clear();
            txbLastName.Clear();
            txbNascimento.Clear();
            cbbLevel.Text = "";
            txbEmail.Clear();
            cbbCountry.Text = "";
            cbbCidade.Text = "";
            txbComplemento.Clear();
            cbbPlace.Text = "";
            txbStreet.Clear();
            txbNumber.Clear();
            tbxCpf.Clear();
            tbxTelefone.Clear();
            txbBairro.Clear();
            txbFirstName.Focus();
        }
    }
}
