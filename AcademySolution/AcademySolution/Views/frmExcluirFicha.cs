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
    public partial class frmExcluirFicha : MetroFramework.Forms.MetroForm
    {
        public frmExcluirFicha()
        {
            InitializeComponent();
        }

        private void frmExcluirFicha_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)

        // tratamento da exclusão de fichas no banco
        {
            Fixa ficha = new Fixa();

            ficha.ExcluirFicha(Convert.ToString(txbCodFicha.Text));


            var r = MetroFramework.MetroMessageBox.Show(this, "Deseja Mesmo Excluir a Ficha?", "Confimação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if  (r == DialogResult.Yes)
            {
                MetroFramework.MetroMessageBox.Show(this, "Excluido Com Sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbCodFicha.Clear();
            }

            if( r == DialogResult.No)
            {
                txbCodFicha.Focus();
                txbCodFicha.Clear();

            }
        }
    }
}
