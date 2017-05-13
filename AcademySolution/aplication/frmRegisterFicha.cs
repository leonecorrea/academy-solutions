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
    public partial class frmRegisterFicha : MetroFramework.Forms.MetroForm
    {
        public frmRegisterFicha()
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
            MetroFramework.MetroMessageBox.Show(this, "Ficha registrada com Sucesso");
        }

        private void btnCleanFicha_Click(object sender, EventArgs e)
        {
            tbxNameStudent.Text = "";
            tbxNameTeacher.Text = "";
            //Limpando Campos Nome Exercicio
            tbxExerciseName1.Text = "";
            tbxExerciseName2.Text = "";
            tbxExerciseName3.Text = "";
            tbxExerciseName4.Text = "";
            tbxExerciseName5.Text = "";
            tbxExerciseName6.Text = "";
            tbxExerciseName7.Text = "";
            tbxExerciseName8.Text = "";
            tbxExerciseName9.Text = "";
            tbxExerciseName10.Text = "";
            tbxExerciseName11.Text = "";
            tbxExerciseName12.Text = "";
            tbxExerciseName13.Text = "";
            tbxExerciseName14.Text = "";

            //Limpando Campos Series Exercicios
            tbxSeries1.Text = "";
            tbxSeries2.Text = "";
            tbxSeries3.Text = "";
            tbxSeries4.Text = "";
            tbxSeries5.Text = "";
            tbxSeries6.Text = "";
            tbxSeries7.Text = "";
            tbxSeries8.Text = "";
            tbxSeries9.Text = "";
            tbxSeries10.Text = "";
            tbxSeries11.Text = "";
            tbxSeries12.Text = "";
            tbxSeries13.Text = "";
            tbxSeries14.Text = "";

            //Limpando campo repetições

            tbxRepetitions1.Text = "";
            tbxRepetitions2.Text = "";
            tbxRepetitions3.Text = "";
            tbxRepetitions4.Text = "";
            tbxRepetitions5.Text = "";
            tbxRepetitions6.Text = "";
            tbxRepetitions7.Text = "";
            tbxRepetitions8.Text = "";
            tbxRepetitions9.Text = "";
            tbxRepetitions10.Text = "";
            tbxRepetitions11.Text = "";
            tbxRepetitions12.Text = "";
            tbxRepetitions13.Text = "";
            tbxRepetitions14.Text = "";
        }

        private void btnCancelFicha_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
