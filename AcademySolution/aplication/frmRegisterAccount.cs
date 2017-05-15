using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademySolution
{
    public partial class frmRegisterAccount : MetroFramework.Forms.MetroForm
    {
        public frmRegisterAccount()
        {
            InitializeComponent();
        }

        private void txbFirstName_Click(object sender, EventArgs e)
        {
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this,"Os dados foram cadastrados com sucesso!");
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txbFirstName.Text = "";
            txbLastName.Text = "";
            txbDateBirth.Text = "";
            cbbLevel.Text = "";
            cbbCountry.Text = "";
            txbCidade.Text = "";
            txbComplemento.Text = "";
            cbbPlace.Text = "";
            txbStreet.Text = "";
            txbNumber.Text = "";
            tbxCPF.Text = "";
            tbxCellphone.Text = "";
            
        }

        private void frmRegisterAccount_Load(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbFirstName_Click_1(object sender, EventArgs e)
        {

        }

        private void cbbPlace_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
