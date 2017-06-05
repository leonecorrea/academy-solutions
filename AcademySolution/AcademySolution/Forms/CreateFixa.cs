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
    public partial class frmRegisterRecord : MetroFramework.Forms.MetroForm{
        public frmRegisterRecord(){
            InitializeComponent();
        }

        //tratamento de validacao de campos

        private void btnRegisterFicha_Click(object sender, EventArgs e){
            if(tbxNameStudent.Text == "" || tbxNameTeacher.Text == "" || cbbNome.Text == "" || cbbRepeticao.Text == "" || cbbSeries.Text == ""){
                MetroFramework.MetroMessageBox.Show(this,"Por favor, Preencha os campos corretamente!","Mensagem",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else{
                MetroFramework.MetroMessageBox.Show(this, "Fixa Criada Com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
