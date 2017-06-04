using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
