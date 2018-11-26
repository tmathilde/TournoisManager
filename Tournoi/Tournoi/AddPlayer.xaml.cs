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
    /// Logique d'interaction pour AddPlayer.xaml
    /// </summary>
    public partial class AddPlayer : Window
    {
        Sql sql = new Sql();
        public AddPlayer()
        {
            InitializeComponent();
        }

        private void addPLayerButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sql.OpenConnection();
                //cast a string in number  and cast a datepicker in datetime  
                int number = int.Parse(numberPlayerTextBox.Text);
                DateTime birth_day = DateTime.Parse(datePlayer.ToString());
                //Call a stored procedure with SqlCommand that receive in parameter the name of procedure and a connexion
                SqlCommand cmd = new SqlCommand("AddPLayer", sql.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Add the values in stored procedure
                cmd.Parameters.AddWithValue("@nom", namePlayerTextBox.Text);
                cmd.Parameters.AddWithValue("@prenom", lastNamePlayerTextBox.Text);
                cmd.Parameters.AddWithValue("@numeros", number);
                cmd.Parameters.AddWithValue("@nationalites", nationalitiesPlayerTextBox.Text);
                cmd.Parameters.AddWithValue("@date_naissance", birth_day);
                cmd.Parameters.AddWithValue("@id_poste", postPlayerComboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@id_t", nameTeamPlayerComboBox.SelectedValue);

                try
                {
                    //executed the query
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Le joueur a bien était ajouté");
                }
                catch
                {
                    throw;
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

        private void postPlayerComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                sql.OpenConnection();
                //post
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT id_poste, libelle_poste FROM Poste", sql.con);
                    //filled a dataTable
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    //recovered the data od query
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //poster the data
                    postPlayerComboBox.DataContext = dt.DefaultView;
                    postPlayerComboBox.DisplayMemberPath = "libelle_poste";
                    postPlayerComboBox.SelectedValuePath = "id_poste";
                }
                catch
                {
                    throw;
                }

                //Team
                try
                {
                    SqlCommand sqlCommand = new SqlCommand("select id_t, nom_t from Team", sql.con);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    nameTeamPlayerComboBox.DataContext = dataTable.DefaultView;
                    nameTeamPlayerComboBox.DisplayMemberPath = "nom_t";
                    nameTeamPlayerComboBox.SelectedValuePath = "id_t";
                }
                catch (Exception)
                {

                    throw;
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

        private void BackButton_Click(object sender, RoutedEventArgs e)
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
