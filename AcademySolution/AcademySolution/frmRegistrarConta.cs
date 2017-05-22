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
                    int categoria=0;
                    switch (cbbLevel.Text)
                    {
                        case "Aluno":
                            categoria = 1;
                            break;
                        case "Trainer":
                            categoria = 2;
                            break;
                        case "Recepção":
                            categoria = 3;
                            break;
                        case "Developer":
                            categoria = 4;
                            break;
                        default:
                            categoria = 5;
                            break;
                    }
                    Instance instance = new Instance();

                    String query = "insert into tb_contas(Nome, DataNasc, DataRegistro, Categoria, Email, Rua, Numero, " +
                        "Complemento, Bairro, Cidade, Estado, Pais, Cpf, Telefone) " +
                        "values(@Nome, @DateBirth, @DateRegister, @Categoria, @Email, @Street, @Number, @Complemento, @Bairro, " +
                        "@Cidade, @Estado, @Country, @Cpf, @Telefone)";

                    /*String query = "insert into tb_contas(Nome, DataNasc, DataRegistro, Categoria, Email, Rua, Numero, " +
                        "Complemento, Bairro, Cidade, Estado, Pais, Cpf, Telefone) " +
                        "values('" + txbFirstName.Text + " " + txbLastName.Text + "', '" + txbNascimento.Text + "', GETDATE(), " +
                        categoria + ", '" + txbEmail.Text +"', '" + txbStreet.Text + "', '" + txbNumber.Text + "', '"+txbComplemento.Text + "', '" + 
                        txbBairro.Text + "', '" + cbbCidade + "', '"+ cbbPlace + "', '" +cbbCountry+ "', '"+ tbxCpf.Text + "', '" + tbxTelefone.Text + "');";*/

                    SqlCommand command = instance.NovoComando(query);

                    command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txbFirstName.Text + " " + txbLastName.Text;
                    command.Parameters.Add("@DateBirth", SqlDbType.Date).Value = Convert.ToDateTime(txbNascimento.Text.Replace("/", "-"));
                    command.Parameters.Add("@DateRegister", SqlDbType.Date).Value = DateTime.Now;
                    command.Parameters.Add("@Email", SqlDbType.VarChar).Value = txbEmail.Text.ToString();
                    command.Parameters.Add("@Categoria", SqlDbType.Int).Value = categoria;
                    command.Parameters.Add("@Street", SqlDbType.VarChar).Value = txbStreet.Text.ToString();
                    command.Parameters.Add("@Number", SqlDbType.Int).Value = txbNumber.Text;
                    command.Parameters.Add("@Complemento", SqlDbType.VarChar).Value = txbComplemento.Text;
                    command.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txbBairro.Text;
                    command.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = cbbCidade.Text.ToString();
                    command.Parameters.Add("@Estado", SqlDbType.VarChar).Value = cbbPlace.Text.ToString();
                    command.Parameters.Add("@Country", SqlDbType.VarChar).Value = cbbCountry.Text.ToString();
                    command.Parameters.Add("@Cpf", SqlDbType.VarChar).Value = tbxCpf.Text;
                    command.Parameters.Add("@Telefone", SqlDbType.Float).Value = Convert.ToDouble(tbxTelefone.Text.Replace("-",""));

                    instance.NovaConexao();
                    command.ExecuteNonQuery();

                    MetroFramework.MetroMessageBox.Show(this, "Registro Concluido Com Exito!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
                finally
                {
                    /*instance.FechaConexao();
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
                    txbBairro.Clear();*/
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
