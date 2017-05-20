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

            SqlCommand command = new SqlCommand("insert into TblAccount (FirstName,LastName,Email,DateBirth,DateRegister,Address,CodCategory) values (@LastName,@FirstName,@Email,@DateBirth,@DateRegister,@Address,@CodCategory)", instance.NovaInstancea());

            command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = txbFirstName.Text;//Adcionando o nome da conta
            command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = txbLastName.Text;//Adcionando o sobrenome
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = txbEmail.Text;
            command.Parameters.Add("@DateBirth", SqlDbType.Date).Value = txbDateBirth.Text;
            command.Parameters.Add("@DateRegister", SqlDbType.DateTime).Value = DateTime.Now;
            command.Parameters.Add("@Address", SqlDbType.VarChar).Value = txbStreet.Text + ", " + txbNumber.Text + ", " + txbComplemento.Text + ", " + cbbCidade.Text;
            command.Parameters.Add("@CodCategory", SqlDbType.VarChar).Value = cbbLevel.Text;

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
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txbFirstName.Clear();
            txbLastName.Clear();
            txbDateBirth.Clear();
            cbbLevel.Text = "";
            cbbCountry.Text = "";
            cbbCidade.Text = "";
            txbComplemento.Clear();
            cbbPlace.Text = "";
            txbStreet.Clear();
            txbNumber.Clear();
            tbxCPF.Clear();
            tbxCellphone.Clear();
        }
    }
}
