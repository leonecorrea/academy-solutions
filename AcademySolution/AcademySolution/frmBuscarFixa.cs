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

namespace AcademySolution
{
    public partial class frmSearchFicha : MetroFramework.Forms.MetroForm
    {
        Instance instancia = new Instance();

        public frmSearchFicha()
        {
            InitializeComponent();
        }

        private void frmSearchFicha_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbbParametro.Text = "";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            
            try
            {
                String campo = txbEntrada.Text;
                String parametro = "tb_record_exercises.idRecord";
                String query = "select tb_exercises.Name as NomeExercicio, tb_record_exercises.repetitions as Repeticoes, tb_record_exercises.Series as Series from tb_exercises inner join tb_record_exercises on tb_exercises.Id = tb_record_exercises.idExercise  inner join tb_records on tb_records.IdRecord = tb_record_exercises.idRecord where ";
                query = query + parametro + " = " + campo;
                instancia.NovaConexao();
                SqlDataReader leituras = instancia.LerDados(query);

                if(leituras.HasRows == false)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Nenhum ficha encontrada", "Erro", MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                    txbEntrada.Text = "";
                }else
                {
                    leituras.Read();
                    for(int i = 0; i < )
                    listaExercicios.Items.Add(Convert.ToString(leituras["NomeExercicio"]));
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
            
        }
    }      
}
