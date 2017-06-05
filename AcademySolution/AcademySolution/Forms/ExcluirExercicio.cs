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
    public partial class ExcluirExercicio : MetroFramework.Forms.MetroForm
    {
        public ExcluirExercicio()
        {
            InitializeComponent();
        }

        private void txbCancelarExcluirExercicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimparCampos()
        {
            txbIdExcluirExercicio.Text = "";
        }

        private void ExcluirOutroExercicio()
        {
            var repetir = MetroFramework.MetroMessageBox.Show(this, "Deseja excluir outro Exercicio?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(repetir == DialogResult.Yes)
            {
                LimparCampos();
                txbIdExcluirExercicio.Focus();
            }else if(repetir == DialogResult.No)
            {
                this.Close();
            }
        }

        private void btnExcluirExercicio_Click(object sender, EventArgs e)
        {
            var delete = MetroFramework.MetroMessageBox.Show(this, "Deseja mesmo escluir este Exercicio?", "Confirmação De Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(delete == DialogResult.Yes)
            {
                using(IConnection conexao = new Connection())
                {
                    conexao.Abrir();
                    IDAO<Exercicio> ExercicioDAO = new ExercicioDAO(conexao);

                    Exercicio ex = new Exercicio();
                    ex.setId(Convert.ToInt32(txbIdExcluirExercicio.Text));

                    ExercicioDAO.remover(ex);

                    if(ex.Erro == null || ex.Erro == "")
                    {
                        var q = MetroFramework.MetroMessageBox.Show(this, "Exercicio Excluido com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if(q == DialogResult.Abort)
                        {
                            ExcluirOutroExercicio();
                        }else if(q == DialogResult.Cancel)
                        {
                            ExcluirOutroExercicio();
                        }
                        else
                        {
                            ExcluirOutroExercicio();
                        }
                    }else
                    {
                        var q = MetroFramework.MetroMessageBox.Show(this, "Erro ao Excluir Exercicio!", "Erro", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

                        if(q == DialogResult.Abort)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Erro, "Falha", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                            LimparCampos();
                        }else if(q == DialogResult.Cancel)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Erro, "Falha", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                            LimparCampos();
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Erro, "Falha", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                            LimparCampos();
                        }

                    }
                }
            }

            if(delete == DialogResult.No)
            {
                txbIdExcluirExercicio.Focus();
                txbIdExcluirExercicio.Clear();
            }
        }
    }
}
