using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using AcademySolution.Classes;

namespace AcademySolution.Forms
{
    public partial class frmPerfil : MetroFramework.Forms.MetroForm
    {
        Instance instancia = new Instance();

        public frmPerfil()
        {
            InitializeComponent();
        }

        private void btnCloseInfoUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void infoUser_Load(object sender, EventArgs e) 
        {
            //No login é gravado um arquivo com o id do usuario
            Stream Arquivo;
            String nomeArq = "Id.txt";
            //Abro o arquivo com o id gravado
            Arquivo = File.Open(nomeArq, FileMode.Open);
            //Defino um leitor para o arquivo
            StreamReader ler = new StreamReader(Arquivo);
            //Variavel que irá armazenar o id
            string pegaId = "";
            //Leio o ID do arquivo e passo para a variavel
            pegaId = Convert.ToString(ler.ReadLine());
            //Fecho meu leitor
            ler.Close();
            //Fecho meu stream
            Arquivo.Close();
            //Pesquiso as informações do usuario pelo id de usuario gravado durante o login
            instancia.NovaConexao();
            string query = "select * from tb_contas where Id ";
            query = query + " = " + pegaId;
            //DataReader para ler do banco
            SqlDataReader lerInfo = instancia.LerDados(query);
            lerInfo.Read();
            //Atribuo aos campos as informações do usuario
            infoUserLastName.Text = "Nome : " + Convert.ToString(lerInfo["Nome"]);
            infoUserDateBirth.Text = "Data Nascimento : " + Convert.ToString(lerInfo["DataNasc"]).Replace("00:00:00", "");
            infoUserStreet.Text = "Rua : " + Convert.ToString(lerInfo["Rua"]);
            long cpf = Convert.ToInt64(lerInfo["Cpf"]);
            //Campo cpf com formatação
            infoUserCpf.Text = "CPF : " + String.Format(@"{0: ###\.###\.###-##}", cpf);
            long telefone = Convert.ToInt64(lerInfo["Telefone"]);
            //Campo telefone com formatação
            infoUserTelefone.Text = "Telefone : " + String.Format("{0:(##) #####-####}", telefone);
            
            
            //Fecho o datareader
            lerInfo.Close();
            //Fecho a conexão
            instancia.FechaConexao();
            
        }
    }
}
