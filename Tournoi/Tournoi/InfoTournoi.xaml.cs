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
    /// Logique d'interaction pour InfoTournoi.xaml
    /// </summary>
    public partial class InfoTournoi : Window
    {
        Sql sql = new Sql();
        public InfoTournoi()
        {
            InitializeComponent();
            string sqlProduit = RechercheProduit(searchTeamTextBox.Text);
            SqlDataAdapter sda = new SqlDataAdapter(sqlProduit, sql.connectionString);
            DataTable dt = new DataTable("Team");
            sda.Fill(dt);
            searchTeamDataGrid.ItemsSource = dt.DefaultView;
        }

        private void addTeamButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AddTeam addTeam = new AddTeam();
                addTeam.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void backTournoiButton_Click(object sender, RoutedEventArgs e)
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

        private void editTeamButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EditTeam editTeam = new EditTeam();
                editTeam.Show();
            }
            catch (Exception)
            {

                throw;
            } 
        }

        private void deleteTeamButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DeleteTeam deleteTeam = new DeleteTeam();
                deleteTeam.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void searchTeamButton_Click(object sender, RoutedEventArgs e)
        {
            string sqlProduit = RechercheProduit(searchTeamTextBox.Text);
            SqlDataAdapter sda = new SqlDataAdapter(sqlProduit, sql.connectionString);
            DataTable dt = new DataTable("Team");
            sda.Fill(dt);
            searchTeamDataGrid.ItemsSource = dt.DefaultView;
        }

        public string RechercheProduit(string textrecherche)
        {
            sql.OpenConnection();
            string commandesql = "SELECT nom_t as Team, point FROM Team WHERE";
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
                        commandesql += " nom_t LIKE '%" + mot + "%' ORDER BY point DESC";
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

        private void searchTeamDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
