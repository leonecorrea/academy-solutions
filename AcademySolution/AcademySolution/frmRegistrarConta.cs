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
        Instance instance;

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
                txbFullName.Text == "" || txbStreet.Text == "" ||
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
                    
                    String query = "insert into tb_contas(Nome, DataNasc, DataRegistro, Categoria, Email, Rua, Numero, " +
                        "Complemento, Bairro, Cidade, Estado, Pais, Cpf, Telefone,DataUpdate) " +
                        "values(@Nome, @DateBirth, @DateRegister, @Categoria, @Email, @Rua, @Numero, @Complemento, @Bairro, " +
                        "@Cidade, @Estado, @Country, @Cpf, @Telefone,@DataUpdate)";
                    
                    SqlCommand command = instance.NovoComando(query);

                    command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txbFullName.Text;
                    command.Parameters.Add("@DateBirth", SqlDbType.Date).Value = Convert.ToDateTime(txbNascimento.Text.Replace("/", "-"));
                    command.Parameters.Add("@DateRegister", SqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@DataUpdate", SqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@Email", SqlDbType.VarChar).Value = txbEmail.Text.ToString();
                    command.Parameters.Add("@Categoria", SqlDbType.Int).Value = categoria;
                    command.Parameters.Add("@Rua", SqlDbType.Int).Value = Convert.ToInt32(txbStreet.Text);
                    command.Parameters.Add("@Numero", SqlDbType.Int).Value = Convert.ToInt32(txbNumber.Text);
                    command.Parameters.Add("@Complemento", SqlDbType.VarChar).Value = txbComplemento.Text;
                    command.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txbBairro.Text;
                    command.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = cbbCidade.Text.ToString();
                    command.Parameters.Add("@Estado", SqlDbType.VarChar).Value = cbbPlace.Text.ToString();
                    command.Parameters.Add("@Country", SqlDbType.VarChar).Value = cbbCountry.Text.ToString();
                    command.Parameters.Add("@Cpf", SqlDbType.VarChar).Value = tbxCpf.Text;
                    command.Parameters.Add("@Telefone", SqlDbType.Float).Value = Convert.ToDouble(tbxTelefone.Text.Replace("-","").Replace("(", "").Replace(")", ""));

                    instance.NovaConexao();
                    command.ExecuteNonQuery();

                    MetroFramework.MetroMessageBox.Show(this, "Registro Concluido Com Exito!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    instance.FechaConexao();
                    Clear();
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
                finally
                {
                    txbFullName.Focus();
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clear();
            txbFullName.Focus();
        }

        public void Clear()
        {
            txbFullName.Clear();
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

        private void grdPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
