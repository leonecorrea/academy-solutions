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
                //Lista Exercicios
                String query = "select tb_exercises.Name as NomeExercicio, tb_record_exercises.repetitions as Repeticoes, tb_record_exercises.Series as Series from tb_exercises inner join tb_record_exercises on tb_exercises.Id = tb_record_exercises.idExercise  inner join tb_records on tb_records.IdRecord = tb_record_exercises.idRecord where ";
                query = query + parametro + " = " + campo;

                String queryContarRegistros = "select count(tb_record_exercises.idRecord) as registros from tb_record_exercises inner join tb_records on tb_record_exercises.idRecord = tb_records.IdRecord where ";
                queryContarRegistros = queryContarRegistros + parametro + " = " + campo;

                instancia.NovaConexao();

                SqlDataReader contaRegistros = instancia.LerDados(queryContarRegistros);
                contaRegistros.Read();

                int registrosContados = Convert.ToInt32(contaRegistros["registros"]);
                contaRegistros.Close();


                SqlDataReader leituras = instancia.LerDados(query);

                if (leituras.HasRows == false)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Nenhum ficha encontrada", "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    txbEntrada.Text = "";
                }
                else
                {

                    //Limpa lista de exercicios
                    listaExercicios.Items.Clear();
                    

                    while (leituras.Read())
                    {
                        listaExercicios.Items.Add("Exercicios: " + Convert.ToString(leituras["NomeExercicio"]).ToString() + " Series: " + Convert.ToString(leituras["Series"]).ToString() + " Repetições: " + Convert.ToString(leituras["Repeticoes"]).ToString());
                    }

                }           
                
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                instancia.FechaConexao();
            }
            
        }
    }      
}
