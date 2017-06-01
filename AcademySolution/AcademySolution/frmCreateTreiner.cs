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
    public partial class frmCreateTreiner : MetroFramework.Forms.MetroForm
    {
        public frmCreateTreiner()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Criação de nova classe
            Treiner t = new Treiner();

            //Setando valores para a classe
            t.SetNome(txbFullName.Text);
            t.SetCpf(txbCpf.Text);
            t.SetDataNascimento(txbNascimento.Text);
            t.SetDataRegistro("SYSDATETYME()");
            t.SetEmail(txbEmail.Text);
            t.SetEndereco(txbRua.Text, txbNumero.Text, txbComplemento.Text, txbBairro.Text, cbbCidade.Text, cbbEstado.Text, cbbPais.Text);
            t.SetTelefone(txbTelefone.Text);
            t.GetCategoria().Codigo = "2";

            //Chama método de criação de usuário
            t.Create("tb_conta");
        }
    }
}
