using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace Tournoi
{
    /// <summary>
    /// Logique d'interaction pour EditTeam.xaml
    /// </summary>
    public partial class EditTeam : Window
    {
        Sql sql = new Sql();
        Data data = new Data();
        public EditTeam()
        {
            InitializeComponent();
        }

        public string RechercheProduit(string textrecherche)
        {
            sql.OpenConnection();
            string commandesql = "SELECT id_t, nom_t, nombre_joueur, point FROM Team WHERE ";
            try
            {
                string[] motsderecherche = textrecherche.Split(' ');
                int index = 1;
                foreach (string mot in motsderecherche)
                {
                    if (index < motsderecherche.Length)
                    {
                        commandesql += " nom_t LIKE '%" + mot + "%' OR";
                        index++;
                    }
                    else
                    {
                        commandesql += " nom_t LIKE '%" + mot + "%'";
                    }
                }

                SqlCommand cmd = new SqlCommand(commandesql, sql.con);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    //
                } 
            }
            catch (Exception)
            {

                MessageBox.Show("The team isn't found");
            }
            finally
            {
                sql.CloseConnection();
            }
            return commandesql;
        }

        private void searchEditTeamButton_Click(object sender, RoutedEventArgs e)
        {
            
            string sqlProduit = RechercheProduit(searchEditTeamTextBox.Text);
            sql.OpenConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(sqlProduit, sql.con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    data.idTeam = reader.GetInt32(0);
                    nameTeamEditTeamTextBox.Text = reader.GetString(1);
                    nbTeamEditTeamTextBox.Text = reader.GetInt32(2).ToString();
                    pointTeamEditTeamTextBox.Text = reader.GetInt32(3).ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sql.CloseConnection();
            }
            
        }

        private void updateEditTeamButton_Click(object sender, RoutedEventArgs e)
        {
            sql.OpenConnection();
            //Console.WriteLine(Data.idTeam);
            try
            {
                int number = int.Parse(nbTeamEditTeamTextBox.Text);
                int point = int.Parse(pointTeamEditTeamTextBox.Text);
                string query = "UPDATE Team SET nom_t = '" + nameTeamEditTeamTextBox.Text + "' , nombre_joueur = " + number + ", point = '" + point + "' WHERE id_t = " + data.idTeam;
                SqlCommand cmd = new SqlCommand(query, sql.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("The update is successful");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sql.CloseConnection();
            }
        }

        private void backEditTeamButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
