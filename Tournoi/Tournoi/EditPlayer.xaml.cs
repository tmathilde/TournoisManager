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
    /// Logique d'interaction pour EditPlayer.xaml
    /// </summary>
    public partial class EditPlayer : Window
    {
        Sql sql = new Sql();
        Data data = new Data();
        public EditPlayer()
        {
            InitializeComponent();
        }

        public string SearchPlayer(string textrecherche)
        {
            sql.OpenConnection();
            string commandesql = "SELECT id_p, nom_p, prenom_p, numeros, nationalites, date_naissance FROM Player WHERE ";
            try
            {
                string[] motsderecherche = textrecherche.Split(' ');
                int index = 1;
                foreach (string mot in motsderecherche)
                {
                    if (index < motsderecherche.Length)
                    {
                        commandesql += " nom_p LIKE '%" + mot + "%' OR";
                        index++;
                    }
                    else
                    {
                        commandesql += " nom_p LIKE '%" + mot + "%'";
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

                MessageBox.Show("The player isn't found");
            }
            finally
            {
                sql.CloseConnection();
            }
            return commandesql;
        }

        private void searchEditTeamButton_Click(object sender, RoutedEventArgs e)
        {

            string sqlProduit = SearchPlayer(searchEditTeamTextBox.Text);
            sql.OpenConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(sqlProduit, sql.con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    data.idPlayer = reader.GetInt32(0);
                    lastNamePlayerEditPlayerTextBox.Text = reader.GetString(1);
                    firstNamePlayerEditPlayerTextBox.Text = reader.GetString(2);
                    numbersEditPlayerTextBox.Text = reader.GetInt32(3).ToString();
                    nationalitiesEditPlayerTextBox.Text = reader.GetString(4);
                    dateNaissanceEditPlayerDataPicker.Text = reader.GetDateTime(5).ToString();
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
                int numbers = int.Parse(numbersEditPlayerTextBox.Text);
                string query = "UPDATE Player SET nom_p = '" + lastNamePlayerEditPlayerTextBox.Text + "' , prenom_p = '" + firstNamePlayerEditPlayerTextBox.Text + "'" +
                    ", numeros = '" + numbers + "', nationalites = '" + nationalitiesEditPlayerTextBox.Text + "', date_naissance = '" + dateNaissanceEditPlayerDataPicker.Text + "' WHERE id_p = " + data.idPlayer;
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
