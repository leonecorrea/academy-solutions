using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademySolution
{
    public partial class frmExcluirAluno : MetroFramework.Forms.MetroForm
    {
        //private object instance;

        public frmExcluirAluno()
        {
            InitializeComponent();
        }

        private void frmExcluirAluno_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        // tratamento da exclusão de alunos no banco

          var ex =  MetroFramework.MetroMessageBox.Show(this, "Deseja Mesmo Excluir o Aluno?", "Confimação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
          if (ex == DialogResult.Yes)
            {
                Aluno aluno = new Aluno();
                

                aluno.Delete(Convert.ToString(txbCodAluno.Text));

                MetroFramework.MetroMessageBox.Show(this, "Aluno Excluido Com Sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbCodAluno.Clear();
            }

          if (ex == DialogResult.No)
            {
                txbCodAluno.Focus();
                txbCodAluno.Clear();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
