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
    public partial class ListarExercicios : MetroFramework.Forms.MetroForm
    {
        public ListarExercicios()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
            listaIdExercicio.Items.Clear();
            listaNomeExercicio.Items.Clear();
            listaDescricaoExercicio.Items.Clear();
        }

        private void AdicionarExercicios()
        {
            var addExercicio = MetroFramework.MetroMessageBox.Show(this, "Deseja Cadastrar algum Exercicio?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (addExercicio == DialogResult.Yes)
            {
                this.Close();
                AdicionarExercicio frm = new AdicionarExercicio();
                frm.ShowDialog();
            }
            else if (addExercicio == DialogResult.No)
            {
                this.Close();
            }
        }

        private void btnListarExercicios_Click(object sender, EventArgs e)
        {
            using (IConnection conexao = new Connection())
            {
                conexao.Abrir();
                IDAO<Exercicio> ExercicioDAO = new ExercicioDAO(conexao);
                int ExerciciosEncontrados = ExercicioDAO.ListarTudo().Count();
                if (ExerciciosEncontrados > 0)
                {
                    limparCampos();
                    for(int i = 0; i < ExerciciosEncontrados; i++)
                    {
                        listaIdExercicio.Items.Add(ExercicioDAO.ListarTudo().ToArray<Exercicio>()[i].getId());
                        listaNomeExercicio.Items.Add(ExercicioDAO.ListarTudo().ToArray<Exercicio>()[i].getNomeExercicio());
                        listaDescricaoExercicio.Items.Add(ExercicioDAO.ListarTudo().ToArray<Exercicio>()[i].getDescricaoExercicio());
                    }
                }else
                {
                    var q = MetroFramework.MetroMessageBox.Show(this, "Nenhum Exercício Cadastrado", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (q == DialogResult.Abort)
                    {
                        limparCampos();
                        AdicionarExercicios();
                    }
                    else if (q == DialogResult.Cancel)
                    {
                        limparCampos();
                        AdicionarExercicios();
                    }
                    else
                    {
                        limparCampos();
                        AdicionarExercicios();
                    }
                }
            }
        }
    }
}
