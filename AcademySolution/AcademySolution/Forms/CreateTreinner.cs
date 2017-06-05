using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcademySolution.Classes;
using AcademySolution.Interfaces;

namespace AcademySolution.Forms
{
    public partial class frmCreateTreinner : MetroFramework.Forms.MetroForm
    {
        public frmCreateTreinner()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            using (IConnection Conexao = new Connection())
            {
                Conexao.Abrir();

                IDAO<Treinner> TreinnerDAO = new TreinnerDAO(Conexao);

                //Criação de nova classe
                Treinner t = new Treinner();

                //Setando valores para a classe
                t.SetNome(txbFullName.Text);
                t.SetCpf(txbCpf.Text);
                t.SetNascimento(txbNascimento.Text);
                t.SetDataRegistro("SYSDATETYME()");
                t.SetEmail(txbEmail.Text);
                //t.SetEndereco(txbRua.Text, txbNumero.Text, txbComplemento.Text, txbBairro.Text, cbbCidade.Text, cbbEstado.Text, cbbPais.Text);
                t.Endereco.SetRua(txbRua.Text);
                t.Endereco.SetNumero(txbNumero.Text);
                t.Endereco.SetComplemento(txbComplemento.Text);
                t.Endereco.SetBairro(txbBairro.Text);
                t.Endereco.SetCidade(cbbCidade.Text);
                t.Endereco.SetEstado(cbbEstado.Text);
                t.Endereco.SetPais(cbbPais.Text);
                t.SetTelefone(txbTelefone.Text);
                t.Categoria.SetId(2);

                TreinnerDAO.inserir(t);

                if (t.Erro == null || t.Erro == ""){
                    var q = MetroFramework.MetroMessageBox.Show(this,"Usuário cadastrado com sucesso!","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    if (q == DialogResult.Abort) {
                        
                    } else if (q == DialogResult.Cancel){

                    }
                    else{

                    }
                } else{

                    var q = MetroFramework.MetroMessageBox.Show(this, "Usuário não cadastrado!", "Falha", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

                    if (q == DialogResult.Abort)
                    {
                        MetroFramework.MetroMessageBox.Show(this, t.Erro, "Falha", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                        //this.Close();
                    }
                    else if (q == DialogResult.Cancel)
                    {
                        MetroFramework.MetroMessageBox.Show(this, t.Erro, "Falha", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                        //this.Close();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, t.Erro, "Falha", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                        //this.Close();
                    }
                }
            }
        }
    }
}
