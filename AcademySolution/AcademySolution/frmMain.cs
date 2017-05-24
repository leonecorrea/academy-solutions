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
            login._LogOut = true;
            this.Close();
            pedeLogin();

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Main Form Close
            if (!login._LogOut)
                Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.lblInfoUser.Text = login.Username;
        }

        public void pedeLogin()
        {
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        public void getUsernameAccount()
        {
            
        }

        public void showRegister()
        {
            frmRegistrarConta register = new frmRegistrarConta();
            register.Show();
        }

        private void smiAddNew_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(showRegister));
            showRegister();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(showInfoUser));
            showInfoUser();
        }

        public void showInfoUser()
        {
            infoUser user = new infoUser();
            user.Show();
        }

        private void addNewFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(showRegisterFicha));
            showRegisterFicha();
        }

        public void showRegisterFicha()
        {
            frmRegisterRecord registerFicha = new frmRegisterRecord();
            registerFicha.Show();
        }

        private void fichasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchFicha registerFicha = new frmSearchFicha();
            registerFicha.Show();
        }

        private void mniProcurarAlunos_Click(object sender, EventArgs e)
        {
            frmBuscarAluno buscarAluno = new frmBuscarAluno();
            buscarAluno.Show();
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