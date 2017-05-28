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

namespace AcademySolution
{
    public partial class infoUser : MetroFramework.Forms.MetroForm
    {
        Instance instancia = new Instance();

        public infoUser()
        {
            InitializeComponent();
        }

        private void btnCloseInfoUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void infoUser_Load(object sender, EventArgs e) 
        {
            Stream Arquivo;
            String nomeArq = "Id.txt";

            Arquivo = File.Open(nomeArq, FileMode.Open);
            StreamReader ler = new StreamReader(Arquivo);
            string pegaId = "";
            
            pegaId = Convert.ToString(ler.ReadLine());
            
            ler.Close();
            Arquivo.Close();

            instancia.NovaConexao();
            string query = "select * from tb_contas where Id ";
            query = query + " = " + pegaId;

            SqlDataReader lerInfo = instancia.LerDados(query);
            lerInfo.Read();

            infoUserLastName.Text = "Nome : " + Convert.ToString(lerInfo["Nome"]);
            infoUserDateBirth.Text = "Data Nascimento : " + Convert.ToString(lerInfo["DataNasc"]).Replace("00:00:00", "");
            infoUserStreet.Text = "Rua : " + Convert.ToString(lerInfo["Rua"]);
            infoUserCpf.Text = "CPF : " + Convert.ToString(lerInfo["Cpf"]);
            infoUserTelefone.Text = "Telefone : " + Convert.ToString(lerInfo["Telefone"]);
            lerInfo.Close();
            instancia.FechaConexao();
        }
    }
}
