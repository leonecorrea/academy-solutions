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

            aluno.ValidaDados();
            aluno.Create();

            switch (aluno._error)
            {
                case "0010":
                    var m = MetroFramework.MetroMessageBox.Show(this,"Usuário cadastrado com sucesso!","Cadastrado",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    if (m == DialogResult.OK)
                    {
                        txbCodigo.Text = Convert.ToString(aluno.Codigo);
                        txbFullName.Enabled = false;
                        btnRegistrar.Enabled = false;
                        txbFullName.Enabled = false;
                        txbNascimento.Enabled = false;
                        cbbCategoria.Enabled = false;
                        txbEmail.Enabled = false;
                        cbbPais.Enabled = false;
                        cbbCidade.Enabled = false;
                        txbComplemento.Enabled = false;
                        cbbEstado.Enabled = false;
                        txbRua.Enabled = false;
                        txbNumero.Enabled = false;
                        tbxCpf.Enabled = false;
                        txbTelefone.Enabled = false;
                        txbBairro.Enabled = false;
                    }
                    else if (m == DialogResult.Retry)
                    {

                    }
                    break;
                case "0001":
                    MetroFramework.MetroMessageBox.Show(this, "Por favor, preencha os dados obrigatórios!", "Falha", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                    break;
                case "0002":
                    MetroFramework.MetroMessageBox.Show(this, "Erro fatal!", "E Morreu", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    break;
                case "0011":
                    MetroFramework.MetroMessageBox.Show(this, "Erro mortal", "E Morreu", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    break;
                default:
                    break;
            }

            //var v = MetroFramework.MetroMessageBox.Show(this, aluno._error);
            //if ( v == DialogResult.OK ) {
            //}
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
