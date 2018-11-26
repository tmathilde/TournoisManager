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
    /// Logique d'interaction pour AddTeam.xaml
    /// </summary>
    public partial class AddTeam : Window
    {
        Sql sql = new Sql();
        public AddTeam()
        {
            InitializeComponent();
        }

        private void backButtonAddTeam_Click(object sender, RoutedEventArgs e)
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

        private void addButtonAddTeam_Click(object sender, RoutedEventArgs e)
        {
            sql.OpenConnection();
            try
            {
                int nb = int.Parse(numberAddTeamTextBox.Text);
                SqlCommand cmd = new SqlCommand("addTeam", sql.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nom_equipe", nameAddTeamTextBox.Text);
                cmd.Parameters.AddWithValue("@nb_joueur", nb);
                cmd.Parameters.AddWithValue("@pays", countryAddTeamTextBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("This team has been added");
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
    }
}
