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

            //aluno.PegaDados(txbCodigo.Text, txbFullName.Text, txbRua.Text, txbRua.Text, txbEmail.Text, txbBairro.Text, txbNascimento.Text,
            //  cbbCategoria.Text, txbNumero.Text, txbComplemento.Text, cbbCidade.Text, cbbEstado.Text, cbbPais.Text, txbTelefone.Text);
            
            if (ValidaDados()==true)
            {
                aluno.Nome = txbFullName.Text;
                aluno.Cpf = txbCpf.Text;
                aluno.Email = txbEmail.Text;
                aluno.Nascimento = txbNascimento.Text;
                aluno.Categoria = "1";
                aluno.Numero = txbNumero.Text;
                aluno.Rua = txbRua.Text;
                aluno.Complemento = txbComplemento.Text;
                aluno.Bairro = txbBairro.Text;
                aluno.Cidade = cbbCidade.Text;
                aluno.Estado = cbbEstado.Text;
                aluno.Pais = cbbPais.Text;
                aluno.Telefone = txbTelefone.Text;

                string cr = aluno.Create();

                if (cr == "CSPAD1")
                {
                    var m = MetroFramework.MetroMessageBox.Show(this, "Usuário cadastrado com sucesso!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                        txbCpf.Enabled = false;
                        txbTelefone.Enabled = false;
                        txbBairro.Enabled = false;

                        btnCadastrarNovo.Enabled = true;
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, aluno.Error, "Falha", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCadastrarNovo_Click_1(object sender, EventArgs e)
        {
            Clear();

            txbFullName.Enabled = true;
            btnRegistrar.Enabled = true;
            txbFullName.Enabled = true;
            txbNascimento.Enabled = true;
            cbbCategoria.Enabled = true;
            txbEmail.Enabled = true;
            cbbPais.Enabled = true;
            cbbCidade.Enabled = true;
            txbComplemento.Enabled = true;
            cbbEstado.Enabled = true;
            txbRua.Enabled = true;
            txbNumero.Enabled = true;
            txbCpf.Enabled = true;
            txbTelefone.Enabled = true;
            txbBairro.Enabled = true;

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
            txbCpf.Clear();
            txbTelefone.Clear();
            txbBairro.Clear();
        }

        public bool ValidaDados()
        {
            if (txbFullName.Text != "" && txbRua.Text != "" && txbRua.Text != "" && txbEmail.Text != "" && txbBairro.Text != "" &&
                txbNascimento.Text != "" && cbbCategoria.Text != "" && txbNumero.Text != "" && txbComplemento.Text != "" && 
                cbbCidade.Text != "" && cbbEstado.Text != "" && cbbPais.Text != "" && txbTelefone.Text != "")
            {
                //MetroFramework.MetroMessageBox.Show(this, "Dados validos", "Valido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Por favor, preencha os campos obrigatórios!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
    }
}
