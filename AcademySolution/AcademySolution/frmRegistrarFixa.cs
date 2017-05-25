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
            cbbNome.Text = "";
            
            //Limpando Campos Series Exercicios
            cbbRepeticao.Text = "";
            
            //Limpando campo repetições
            cbbSeries.Text = "";
        }

        private void btnCancelFicha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
