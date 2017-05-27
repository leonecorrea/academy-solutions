﻿using System;
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

        private void limpaCampos() {
            //Limpa lista todos os campos
            txbEntrada.Text = "";
            txbNomeAlunoProcuraFicha.Text = "";
            txbNomeTrainerProcuraFicha.Text = "";
            txbBuscaFichaDataInicio.Text = "";
            txbBuscaFichaDataTroca.Text = "";
            listaExercicios.Items.Clear();
            listaRepeticoes.Items.Clear();
            listaSeries.Items.Clear();
        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            try
            {
                String campo = txbEntrada.Text;
                //Parametro para pegar pelo id da ficha 
                String parametrPegaPelaFicha = "tb_record_exercises.idRecord";
                //Lista Exercicios os exercicios da ficha
                String query = "select tb_exercises.Name as NomeExercicio, tb_record_exercises.repetitions as Repeticoes, tb_record_exercises.Series as Series from tb_exercises inner join tb_record_exercises on tb_exercises.Id = tb_record_exercises.idExercise  inner join tb_records on tb_records.IdRecord = tb_record_exercises.idRecord where ";
                query = query + parametrPegaPelaFicha + " = " + campo;

                //Lista nome do aluno, data inicio e data troca
                String infoAluno = "select tb_contas.Nome as Nome, tb_records.DateBegin as dataInicio, tb_records.DateExpiration as dataTroca from tb_contas inner join tb_records on tb_records.IdStudent = tb_contas.id where tb_records.IdRecord";
                infoAluno = infoAluno + " = " + campo;

                //Pega o nome do professor
                String infoProf = "select tb_contas.Nome as NomeProf from tb_contas inner join tb_records on tb_records.IdTrainer = tb_contas.id where tb_records.IdRecord";
                infoProf = infoProf + " = " + campo;

                //Verificar se a ficha está cadastrada
                String stringBuscaFicha = "select * from tb_records where idRecord ";
                stringBuscaFicha = stringBuscaFicha + " = " + campo;

                instancia.NovaConexao();
                SqlDataReader buscaFicha = instancia.LerDados(stringBuscaFicha);
                
                if (buscaFicha.HasRows == false)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Nenhum ficha encontrada", "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    limpaCampos();
                }
                else
                {
                    buscaFicha.Close();


                    SqlDataReader buscaExercicios = instancia.LerDados(query);
                    
                    
                    if (buscaExercicios.HasRows == false)
                    {
                        buscaExercicios.Close();
                        limpaCampos();

                        SqlDataReader pegaInfoAluno = instancia.LerDados(infoAluno);
                        pegaInfoAluno.Read();
                        txbNomeAlunoProcuraFicha.Text = Convert.ToString(pegaInfoAluno["Nome"]);
                        txbBuscaFichaDataInicio.Text = Convert.ToString(pegaInfoAluno["dataInicio"]).Replace("00:00:00", "");
                        txbBuscaFichaDataTroca.Text = Convert.ToString(pegaInfoAluno["dataTroca"]).Replace("00:00:00", "");

                        pegaInfoAluno.Close();

                        SqlDataReader pegaInfoProf = instancia.LerDados(infoProf);
                        pegaInfoProf.Read();
                        txbNomeTrainerProcuraFicha.Text = Convert.ToString(pegaInfoProf["NomeProf"]);

                        pegaInfoProf.Close();

                        listaExercicios.Items.Add("Nenhum Exercicio cadastrado");
                        listaRepeticoes.Items.Add("Nenhum resultado encontrado");
                        listaSeries.Items.Add("Nenhum resultado encontrado");
                        
                    }
                    else
                    {
                        limpaCampos();

                        while (buscaExercicios.Read())
                        {
                            listaExercicios.Items.Add(Convert.ToString(buscaExercicios["NomeExercicio"]));
                            listaSeries.Items.Add(Convert.ToString(buscaExercicios["Series"]));
                            listaRepeticoes.Items.Add(Convert.ToString(buscaExercicios["Repeticoes"]));
                        }
                        buscaExercicios.Close();

                        SqlDataReader pegaInfoAluno = instancia.LerDados(infoAluno);
                        pegaInfoAluno.Read();
                        txbNomeAlunoProcuraFicha.Text = Convert.ToString(pegaInfoAluno["Nome"]);
                        txbBuscaFichaDataInicio.Text = Convert.ToString(pegaInfoAluno["dataInicio"]).Replace("00:00:00", "");
                        txbBuscaFichaDataTroca.Text = Convert.ToString(pegaInfoAluno["dataTroca"]).Replace("00:00:00", "");

                        pegaInfoAluno.Close();

                        SqlDataReader pegaInfoProf = instancia.LerDados(infoProf);
                        pegaInfoProf.Read();
                        txbNomeTrainerProcuraFicha.Text = Convert.ToString(pegaInfoProf["NomeProf"]);

                        pegaInfoProf.Close();
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
