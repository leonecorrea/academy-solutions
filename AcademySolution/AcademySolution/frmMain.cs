using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademySolution
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public Login login = new Login();

        public frmMain()
        {
            InitializeComponent();
        }

        private void lnkLogOut_Click(object sender, EventArgs e)
        {
            login.Deslogar();
            login.LogOut = true;
            this.Close();
            pedeLogin();

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Main Form Close
            if (!login.LogOut)
                Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.lblInfoUser.Text = login.Username;
        }

        public void pedeLogin()
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        public void getUsernameAccount()
        {
            
        }
        
        private void smiAddNew_Click(object sender, EventArgs e)
        {
            CreateConta register = new CreateConta();
            register.ShowDialog();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoUser user = new infoUser();
            user.ShowDialog();
        }

       

        private void addNewFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisterRecord registerFicha = new frmRegisterRecord();
            registerFicha.ShowDialog();
        }

       

        private void fichasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchFicha registerFicha = new frmSearchFicha();
            registerFicha.ShowDialog();
        }

        private void mniProcurarAlunos_Click(object sender, EventArgs e)
        {
            //frmBuscarAluno buscarAluno = new frmBuscarAluno();
            //buscarAluno.ShowDialog();

            ListarAlunos view = new ListarAlunos();
            view.ShowDialog();
        }

        private void excluirFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExcluirFicha excluirFicha = new frmExcluirFicha();
            excluirFicha.ShowDialog();
        }

        private void excluirAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExcluirAluno excluirAluno = new frmExcluirAluno();
            excluirAluno.ShowDialog();
        }

        private void excluirTrainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExcluirTrainer excluirTrainer = new frmExcluirTrainer();
            excluirTrainer.ShowDialog();
        }
    }
}