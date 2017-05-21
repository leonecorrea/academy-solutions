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
    public partial class frmRegisterAccount : MetroFramework.Forms.MetroForm
    {
        public frmRegisterAccount()
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

            SqlCommand command = new SqlCommand("insert into TblConta (Nome,Sobrenome,DataNasc,DataRegistro,CodCategory,Email,Rua,Numero,Complemento,Bairro,Cidade,Estado,Pais,Cpf,Telefone) values(@FirstName,@LastName,@DateBirth,@DateRegister,@CodCategory,@Email,@Street,@Number,@Complemento,@Bairro,@Cidade,@Estado,@Country,@Cpf,@Telefone)", instance.NovaInstancea());
            int nivelAcesso;
            if(cbbLevel.Text == "Instrutor")
            {
                nivelAcesso = 2;
            }else
            {
                nivelAcesso = 1;
            }


            command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = txbFirstName.Text;//Adcionando o nome da conta
            command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = txbLastName.Text;//Adcionando o sobrenome
            command.Parameters.Add("@DateBirth", SqlDbType.Date).Value = txbDateBirth.Text.Replace("/", "-");
            command.Parameters.Add("@DateRegister", SqlDbType.DateTime).Value = DateTime.Now;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = txbEmail.Text;
            command.Parameters.Add("@CodCategory", SqlDbType.Int).Value = nivelAcesso;
            command.Parameters.Add("@Street", SqlDbType.VarChar).Value = txbStreet.Text;
            command.Parameters.Add("@Number", SqlDbType.Int).Value = txbNumber.Text;
            command.Parameters.Add("@Complemento", SqlDbType.VarChar).Value = txbComplemento.Text;
            command.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txbBairro.Text;
            command.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = cbbCidade.Text;
            command.Parameters.Add("@Estado", SqlDbType.VarChar).Value = cbbPlace.Text;
            command.Parameters.Add("@Country", SqlDbType.VarChar).Value = cbbCountry.Text;
            command.Parameters.Add("@Cpf", SqlDbType.VarChar).Value = tbxCPF.Text;
            command.Parameters.Add("@Telefone", SqlDbType.Float).Value = Convert.ToDouble(tbxCellphone.Text.Replace("-", ""));



            try
            {
                instance.NovaInstancea().Open();
                command.ExecuteNonQuery();
                MetroFramework.MetroMessageBox.Show(this, "Account successfully registered!");
            }catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
            finally
            {
                instance.NovaInstancea().Close();
                txbFirstName.Clear();
                txbLastName.Clear();
                txbDateBirth.Clear();
                cbbLevel.Text = "";
                txbEmail.Clear();
                cbbCountry.Text = "";
                cbbCidade.Text = "";
                txbComplemento.Clear();
                cbbPlace.Text = "";
                txbStreet.Clear();
                txbNumber.Clear();
                tbxCPF.Clear();
                tbxCellphone.Clear();
                txbBairro.Clear();
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txbFirstName.Clear();
            txbLastName.Clear();
            txbDateBirth.Clear();
            cbbLevel.Text = "";
            txbEmail.Clear();
            cbbCountry.Text = "";
            cbbCidade.Text = "";
            txbComplemento.Clear();
            cbbPlace.Text = "";
            txbStreet.Clear();
            txbNumber.Clear();
            tbxCPF.Clear();
            tbxCellphone.Clear();
            txbBairro.Clear();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
