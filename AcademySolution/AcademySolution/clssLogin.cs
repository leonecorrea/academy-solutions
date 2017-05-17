﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AcademySolution
{
    public class Login
    {
        public bool Status { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String _error { get; set; }
        public int Codigo { get; set; }
        public bool _LogOut { get; set; }

        public Instance instance = new Instance();
        
        public Login()
        {
            //this.Status = false;
            this.Codigo = 1;
            this.Username = "admin";
            this.Password = "admin";
            this._error = null;
            this._LogOut = false;
        }

        public string EncriptPass()
        {
            return Password;
        }

        //Método usado para trocar status para logado
        public void Logar(string username,string password)
        {
            this.Status = true;
            return;
        }


        public void Deslogar()
        {
            this.Status = false;
            this._LogOut = true;
        }

        //Método usado para validar o login
        public void ValidaLogin(String username, String password)
        {
            //Se usuário e senha forem vazios
            if ( username == "" || password == "" )
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    this._error = "Por favor, preencha seus dados corretamente.";
                    return;
                }
                //Mas se usuario for vazio e senha não
                else if ( username == "" && password != "" )
                {
                    this._error = "Por favor, preencha o campo usuário!";
                }
                //Mas se usuario for preenchido e senha não
                else if ( username != "" && password == "" )
                {
                    this._error = "Por favor, preencha sua senha!";
                    return;
                }
            }
            //Mas se usuário ou senha forem diferentes dos definidos pela classe 
            else if ( username != this.Username || password != this.Password )
            {
                this._error = "Seus dados estão incorretos! Refaça a operação.";
                return;
            }
            //Se usuário e senha estiverem corretos
            else if (username == this.Username || password == this.Password)
            {
                try
                {
                    //instance.connection();

                    using (AcademySolutionEntities academy = new AcademySolutionEntities())
                    {
                        var query = from o in academy.TblLogins
                                    where o.Username == username && o.Password == password
                                    select o;
                        if (query.SingleOrDefault() != null)
                        {
                            this.Logar(username, password);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    this._error = Convert.ToString(ex);
                }
            }
        }

        //Cadastra Logins
        public void CreateLogin()
        {

        }

        //Lê Logins
        public void ReadLogin()
        {

        }

        //Atualizar os Logins
        public void UpdateLogin()
        {

        }

        //Deleta Login
        public void DeleteLogin()
        {

        }
    }
}