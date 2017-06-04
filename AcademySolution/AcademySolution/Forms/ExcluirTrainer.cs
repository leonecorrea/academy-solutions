using AcademySolution.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademySolution.Forms{
    public partial class frmExcluirTrainer : MetroFramework.Forms.MetroForm{
        public frmExcluirTrainer()
        {
            InitializeComponent();
        }

        private void frmExcluirTrainer_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)

        // tratamento da exclusão de trainer no banco
        {
            var ex = MetroFramework.MetroMessageBox.Show(this, "Deseja Mesmo Excluir o Trainer?", "Confimação de Trainer", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (ex == DialogResult.Yes)
            {
                Aluno aluno = new Aluno();


                aluno.Delete(Convert.ToString(txbCodTrainer.Text));

                MetroFramework.MetroMessageBox.Show(this, "Trainer Excluido Com Sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbCodTrainer.Clear();
            }

            if (ex == DialogResult.No)
            {
                txbCodTrainer.Focus();
                txbCodTrainer.Clear();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
