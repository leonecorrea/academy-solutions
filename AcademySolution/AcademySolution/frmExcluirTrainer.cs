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
    public partial class frmExcluirTrainer : MetroFramework.Forms.MetroForm
    {
        public frmExcluirTrainer()
        {
            InitializeComponent();
        }

        private void frmExcluirTrainer_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var ex = MetroFramework.MetroMessageBox.Show(this, "Deseja Mesmo Excluir o Trainer?", "Confimação de Trainer", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (ex == DialogResult.Yes)
            {
                MetroFramework.MetroMessageBox.Show(this, "Trainer Excluido Com Sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbCodFicha.Clear();
            }

            if (ex == DialogResult.No)
            {
                txbCodFicha.Focus();
                txbCodFicha.Clear();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
