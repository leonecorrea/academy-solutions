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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        static frmLogin _instance;

        public static frmLogin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmLogin();
                return _instance;
            }
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbUser.Clear();
            txbPassword.Clear();
            txbUser.Focus();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _instance = this;
            txbUser.Focus();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txbUser.Text == "")
            {
                if (string.IsNullOrEmpty(txbUser.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this,"Por favor, preencha seus dados corretamente.","Mensagem",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txbUser.Focus();
                    return;
                }
                try
                {
                    using (AcademiaSolutionsEntities1 db = new AcademiaSolutionsEntities1())
                    {
                        var query = from a in db.Accounts
                                    where a.UserName == txbUser.Text && a.Password == txbPassword.Text
                                    select a;
                        if (query.SingleOrDefault() != null)
                        {
                            this.Hide();
                            frmMain frm = new frmMain();
                            frm.ShowDialog();
                        }
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Seu nome de usuário ou senha estão incorretos!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro",MessageBoxButtons.RetryCancel);
                }
            }
        }
    }
}
