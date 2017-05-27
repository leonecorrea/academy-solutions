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
    public partial class ListarAlunos : MetroFramework.Forms.MetroForm
    {
        public ListarAlunos()
        {
            InitializeComponent();
        }

        private void ListarAlunos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'academySolutionDataSet.v_alunos'. Você pode movê-la ou removê-la conforme necessário.
            this.v_alunosTableAdapter.Fill(this.academySolutionDataSet.v_alunos);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.v_alunosTableAdapter.FillBy(this.academySolutionDataSet.v_alunos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
