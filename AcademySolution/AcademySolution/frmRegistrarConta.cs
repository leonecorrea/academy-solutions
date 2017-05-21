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

            String query = "insert into TblConta(Nome, Sobrenome, DataNasc, DataRegistro, CodCategory, Email, Rua, Numero, Complemento, Bairro, Cidade, Estado, Pais, Cpf, Telefone) values(@FirstName, @LastName, @DateBirth, @DateRegister, @CodCategory, @Email, @Street, @Number, @Complemento, @Bairro, @Cidade, @Estado, @Country, @Cpf, @Telefone)";

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
                    int nivelAcesso;
                    if (cbbLevel.Text == "Instrutor")
                    {
                        nivelAcesso = 2;
                    }
                    else
                    {
                        nivelAcesso = 1;
                    }

                    comando.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = txbFirstName.Text;//Adcionando o nome da conta
                    comando.Parameters.Add("@LastName", SqlDbType.VarChar).Value = txbLastName.Text;//Adcionando o sobrenome
                    comando.Parameters.Add("@DateBirth", SqlDbType.Date).Value = txbNascimento.Text.Replace("/", "-");
                    comando.Parameters.Add("@DateRegister", SqlDbType.DateTime).Value = DateTime.Now;
                    comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txbEmail.Text;
                    comando.Parameters.Add("@CodCategory", SqlDbType.Int).Value = nivelAcesso;
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
                    this.Close();
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

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
