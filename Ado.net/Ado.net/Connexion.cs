using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Ado.net
{
     public class Connexion
    {
        MySqlConnection cnx;

        public MySqlConnection Cnx { get => cnx; set => cnx = value; }

        public Connexion(string h,string user,string pwd,string bdd)
        {
            string sCnx;

            sCnx = String.Format("server={0};uid={1};database={2};port=3306;pwd={3}",h,user,bdd,pwd);

            cnx = new MySqlConnection(sCnx);
            
        }
        public string ouvrir()
        {
            string message;
            try
            {
                cnx.Open();
                message = "Connexion réussie";
                
            }
            catch (Exception e)
            {
                message = string.Format("echec de la connexion {0}", e.Message);
            }
            return message;
        }
        public void Close()
        {
            cnx.Close();
        }
    }
}
