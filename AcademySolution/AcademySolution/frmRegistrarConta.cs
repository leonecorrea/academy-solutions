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
    public partial class CreateConta : MetroFramework.Forms.MetroForm
    {
        public CreateConta()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();

            aluno.PegaDados(txbCodigo.Text, txbFullName.Text, txbRua.Text, txbRua.Text, txbEmail.Text, txbBairro.Text, txbNascimento.Text,
                cbbCategoria.Text, txbNumero.Text, txbComplemento.Text, cbbCidade.Text, cbbEstado.Text, cbbPais.Text, txbTelefone.Text);

            aluno.Create();

            switch (aluno._error)
            {
                case "0001":
                    var m = MetroFramework.MetroMessageBox.Show(this,"Usuário cadastrado com sucesso!");

                    if (m == DialogResult.OK)
                    {
                        txbCodigo.Text = Convert.ToString(aluno.Codigo);
                        txbFullName.Enabled = false;
                        btnRegistrar.Enabled = false;
                    }
                    else if (m == DialogResult.Retry)
                    {

                    }
                    break;
                case "0002":
                    MetroFramework.MetroMessageBox.Show(this, "Erro ao cadastrar usuário!");
                    break;
                default:
                    break;
            }

            var v = MetroFramework.MetroMessageBox.Show(this, aluno._error);
            if ( v == DialogResult.OK ) {
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
            cbbCategoria.Text = "";
            txbEmail.Clear();
            cbbPais.Text = "";
            cbbCidade.Text = "";
            txbComplemento.Clear();
            cbbEstado.Text = "";
            txbRua.Clear();
            txbNumero.Clear();
            tbxCpf.Clear();
            txbTelefone.Clear();
            txbBairro.Clear();
        }
    }
}
