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
    public partial class frmRegisterRecord : MetroFramework.Forms.MetroForm
    {
        public frmRegisterRecord()
        {
            InitializeComponent();
        }

        private void frmRegisterFicha_Load(object sender, EventArgs e)
        {

        }

        private void metroToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void metroLabel43_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel33_Click(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnRegisterFicha_Click(object sender, EventArgs e)
        {
            if(tbxNameStudent.Text == "" || tbxNameTeacher.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this,"Por favor, Preencha os campos corretamente!","Mensagem",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }


            //MetroFramework.MetroMessageBox.Show(this, "Ficha registrada com Sucesso");
        }

        private void btnCleanFicha_Click(object sender, EventArgs e)
        {
            tbxNameStudent.Text = "";
            tbxNameTeacher.Text = "";
            //Limpando Campos Nome Exercicio
            tbxExerciseName1.Text = "";
            
            //Limpando Campos Series Exercicios
            tbxSeries1.Text = "";
            
            //Limpando campo repetições
            tbxRepetitions1.Text = "";
        }

        private void btnCancelFicha_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
