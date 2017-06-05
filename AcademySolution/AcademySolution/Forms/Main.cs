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
using System.IO;
using System.Data.SqlClient;
using AcademySolution.Classes;

namespace AcademySolution.Forms
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        Instance instancia = new Instance();
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
            Stream arquivo;
            String nomeArq = "Id.txt";

            arquivo = File.Open(nomeArq, FileMode.Open);

            StreamReader ler = new StreamReader(arquivo);

            string IdUser = Convert.ToString(ler.ReadLine());

            instancia.NovaConexao();
            string query = "SELECT * FROM tb_logins WHERE Id = "+IdUser+"";
            SqlDataReader pegaNomeAluno = instancia.LerDados(query);
            pegaNomeAluno.Read();

            lblInfoUser.Text = "Logado como : " + Convert.ToString(pegaNomeAluno["Username"]);

            ler.Close();
            arquivo.Close();
        }

        public void pedeLogin()
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        public void getUsernameAccount()
        {
            
        }
        
        //chama a tela de criar conta

        private void smiAddNew_Click(object sender, EventArgs e)
        {
            // instancia do form CreateConta para chamar a tela

            CreateConta register = new CreateConta();
            register.ShowDialog();
        }

        //chama a tela de informacoes do usuario logado

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instancia do form infoUser para chamar a tela
            frmPerfil user = new frmPerfil();
            user.ShowDialog();
        }

        //chama a tela de Criar nova ficha

        private void addNewFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instancia do form RegisterRecord para chamar a tela
            frmRegisterRecord registerFicha = new frmRegisterRecord();
            registerFicha.ShowDialog();
        }

        //chama a tela de procurar ficha

        private void fichasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instancia do form SearchFicha para chamar a tela
            frmSearchFicha registerFicha = new frmSearchFicha();
            registerFicha.ShowDialog();
        }

        //chama a tela de buscar aluno

        private void mniProcurarAlunos_Click(object sender, EventArgs e)
        {
            // instancia do form BuscarAluno para chamar a tela

            frmBuscarAluno buscarAluno = new frmBuscarAluno();
            buscarAluno.ShowDialog();

           
        }

        //chama a tela de excluir ficha

        private void excluirFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instancia do form ExcluirFicha para chamar a tela
            frmExcluirFicha excluirFicha = new frmExcluirFicha();
            excluirFicha.ShowDialog();
        }

        //chama a tela de excluir aluno

        private void excluirAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instancia do form ExcluirAluno para chamar a tela
            frmExcluirAluno excluirAluno = new frmExcluirAluno();
            excluirAluno.ShowDialog();
        }

        //chama a tela de excluir Trainer

        private void excluirTrainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instancia do form ExcluirTrainer para chamar a tela
            frmExcluirTrainer excluirTrainer = new frmExcluirTrainer();
            excluirTrainer.ShowDialog();
        }

        //chama a tela de listar alunos

        private void listarAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instancia do form ListarAlunos para chamar a tela
            //ListarAlunos view = new ListarAlunos();
            //view.ShowDialog();
        }

        //chama a tela de buscar trainer
        private void trainersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instancia do form BuscarTreiner para chamar a tela
            frmBuscarTreiner buscarTrainer = new frmBuscarTreiner();
            buscarTrainer.ShowDialog();
        }

        private void adicionarNovoExercícioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarExercicio frm = new AdicionarExercicio();
            frm.ShowDialog();
        }

        private void mniNovoTreinner_Click(object sender, EventArgs e)
        {
            frmCreateTreinner frm = new frmCreateTreinner();
            frm.ShowDialog();
        }

        private void excluirExercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcluirExercicio frm = new ExcluirExercicio();
            frm.ShowDialog();
        }

        private void exerciciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarExercicios frm = new ListarExercicios();
            frm.ShowDialog();
        }
    }
}