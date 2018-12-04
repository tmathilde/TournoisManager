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
using System.Data;
using System.Data.SqlClient;

namespace Tournoi
{
    /// <summary>
    /// Logique d'interaction pour InfoPlayer.xaml
    /// </summary>
    public partial class InfoPlayer : Window
    {
        Sql sql = new Sql();
        public InfoPlayer()
        {
            InitializeComponent();
        }

        private void backButtonInfoPlayer_Click(object sender, RoutedEventArgs e)
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

        private void searchPayerButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string sqlProduit = RechercheProduit(searchPayerTextBox.Text);
                SqlDataAdapter sda = new SqlDataAdapter(sqlProduit, sql.connectionString);
                DataTable dt = new DataTable("Player, Poste");
                sda.Fill(dt);
                searchPlayerDataGrid.ItemsSource = dt.DefaultView;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string RechercheProduit(string textrecherche)
        {
            sql.OpenConnection();
            string commandesql = "SELECT nom_p as 'Last name', prenom_p as 'First name', numeros as Number, nationalites as Nationalities, date_naissance as Birth day, nom_equipe as Team, libelle_poste as Post  " +
                                "FROM Player pl, Poste p WHERE pl.id_poste = p.id_poste and ";
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

        private void searchPayerTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
