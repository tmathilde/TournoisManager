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
    /// Logique d'interaction pour DeleteTeam.xaml
    /// </summary>
    public partial class DeleteTeam : Window
    {
        Sql sql = new Sql();
        public DeleteTeam()
        {
            InitializeComponent();
        }

        private void seachDeleteTeamButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string sqlProduit = RechercheProduit(searchDeleteTeamTextBox.Text);
                SqlDataAdapter sda = new SqlDataAdapter(sqlProduit, sql.connectionString);
                DataTable dt = new DataTable("Team");
                sda.Fill(dt);
                dataGridDeleteTeam.ItemsSource = dt.DefaultView;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string RechercheProduit(string textrecherche)
        {
            sql.OpenConnection();
            try
            {
                string[] motsderecherche = textrecherche.Split(' ');
                string query = "SELECT nom_t as Nom FROM Team WHERE ";
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

        private void backDeleteTeamButton_Click(object sender, RoutedEventArgs e)
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

        private void dataGridDeleteTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void deleteTeamButton_Click(object sender, RoutedEventArgs e)
        {
            int result = 0;
            sql.OpenConnection();
            try
            {
                DataRowView dataRow = (DataRowView)dataGridDeleteTeam.SelectedItem;
                string cellValue = dataRow.Row.ItemArray[0].ToString();
                string delcmd = "DELETE FROM team WHERE nom_t = '" + cellValue + "'";
                Console.WriteLine(cellValue);
                SqlCommand del = new SqlCommand(delcmd, sql.con);
                result = del.ExecuteNonQuery();
                MessageBox.Show("This team is been remove");
            }
            catch
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
