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
    /// Logique d'interaction pour InfoTeam.xaml
    /// </summary>
    public partial class InfoTeam : Window
    {
        Sql sql = new Sql();
        public InfoTeam()
        {
            InitializeComponent();
        }

        private void backInfoTeamButton_Click(object sender, RoutedEventArgs e)
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

        private void addInfoTeamButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AddPlayer addPlayer = new AddPlayer();
                addPlayer.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void editInfoTeamButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EditPlayer editPlayer = new EditPlayer();
                editPlayer.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void deleteInfoTeamButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DeletePlayer deletePlayer = new DeletePlayer();
                deletePlayer.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string SearchTeam(string textrecherche)
        {
            sql.OpenConnection();
            try
            {
                string[] motsderecherche = textrecherche.Split(' ');
                string query = "SELECT nom_t as Name ,nombre_joueur as Number, pays as Country, point as Point FROM Team WHERE ";
                int index = 1;
                foreach (string mot in motsderecherche)
                {
                    if (index < motsderecherche.Length)
                    {
                        query += " nom_t LIKE '%" + mot + "%' OR";
                        index++;
                    }
                    else
                    {
                        query += " nom_t LIKE '%" + mot + "%'";
                    }
                }

                SqlCommand cmd = new SqlCommand(query, sql.con);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    //
                }
                else
                {
                    MessageBox.Show("This team does not exist");
                }
                return query;
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

        private void searchInfoTeamButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string sqlProduit = SearchTeam(searchInfoTeamTextBox.Text);
                SqlDataAdapter sda = new SqlDataAdapter(sqlProduit, sql.connectionString);
                DataTable dt = new DataTable("Team");
                sda.Fill(dt);
                dataGridInfoTeam.ItemsSource = dt.DefaultView;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridInfoTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
