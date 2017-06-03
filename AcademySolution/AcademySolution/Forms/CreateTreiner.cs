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

namespace AcademySolution
{
    public partial class frmCreateTreiner : MetroFramework.Forms.MetroForm
    {
        public frmCreateTreiner()
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
                t.SetDataNascimento(txbNascimento.Text);
                //t.SetDataRegistro("SYSDATETYME()");
                t.SetEmail(txbEmail.Text);
                //t.SetEndereco(txbRua.Text, txbNumero.Text, txbComplemento.Text, txbBairro.Text, cbbCidade.Text, cbbEstado.Text, cbbPais.Text);
                t.SetRua(txbRua.Text);
                t.SetNumero(txbNumero.Text);
                t.SetComplemento(txbComplemento.Text);
                t.SetBairro(txbBairro.Text);
                t.SetEstado(cbbEstado.Text);
                t.SetPais(cbbPais.Text);
                t.SetTelefone(txbTelefone.Text);
                t.Categoria.SetId(2);

                var r = TreinnerDAO.inserir(t);

                if (r == t)
                {
                    MetroFramework.MetroMessageBox.Show(this,"Usuário cadastrado com sucesso!","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else{
                    MetroFramework.MetroMessageBox.Show(this, "Usuário não cadastrado!", "Falha", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }
        }
    }
}
