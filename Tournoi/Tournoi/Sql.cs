using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tournoi
{
    class Sql
    {
        /*Its a connexion for a dataBase. For you if you change address Ip and you put your address ip*/
        public string connectionString = "Data Source = 192.168.137.128; Initial Catalog = TournoiCSharp; User ID = sa; Password=abcd4ABCD";
        public SqlConnection con;

        // Open a connexion
        public void OpenConnection()
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Close a connexion
        public void CloseConnection()
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
