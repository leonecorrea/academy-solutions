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
    public partial class AdicionarExercicio : MetroFramework.Forms.MetroForm
    {
        public AdicionarExercicio()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            TxbAddExercicioNome.Text = "";
            TxbAddExercicioDescricao.Text = "";
        }

        private void AdicionarExercicio_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarAddExercicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddExercicioLimpaCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void AdicionarOutroExercicio()
        {
            var repetir = MetroFramework.MetroMessageBox.Show(this, "Deseja Adicionar outro Exercicio?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (repetir == DialogResult.Yes)
            {
                LimparCampos();
                TxbAddExercicioNome.Focus();
            }
            else if (repetir == DialogResult.No)
            {
                this.Close();
            }
        }

        private void BtnAddExercicio_Click(object sender, EventArgs e)
        {
            if(TxbAddExercicioNome.Text == "" || TxbAddExercicioDescricao.Text == "") {
                MetroFramework.MetroMessageBox.Show(this, "Preencha os campos Corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }else
            {
                using (IConnection conexao = new Connection())
                {
                    conexao.Abrir();

                    IDAO<Exercicio> ExercicioDAO = new ExercicioDAO(conexao);

                    Exercicio ex = new Exercicio();

                    ex.setNomeExercicio(TxbAddExercicioNome.Text);
                    ex.setDescricaoExercicio(TxbAddExercicioDescricao.Text);

                    ExercicioDAO.inserir(ex);

                    if (ex.Erro == null || ex.Erro == "")
                    {
                        var q = MetroFramework.MetroMessageBox.Show(this, "Exercicio cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (q == DialogResult.Abort)
                        {
                            AdicionarOutroExercicio();
                        }
                        else if (q == DialogResult.Cancel)
                        {
                            AdicionarOutroExercicio();
                        }
                        else
                        {
                            AdicionarOutroExercicio();
                        }
                    }
                    else
                    {
                        var q = MetroFramework.MetroMessageBox.Show(this, "Exercicio não cadastrado!", "Falha", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

                        if (q == DialogResult.Abort)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Erro, "Falha", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                            LimparCampos();
                            //this.Close();
                        }
                        else if (q == DialogResult.Cancel)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Erro, "Falha", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                            LimparCampos();
                            //this.Close();
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Erro, "Falha", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                            LimparCampos();
                            //this.Close();
                        }
                    }
                }
            }
        }
    }
}
