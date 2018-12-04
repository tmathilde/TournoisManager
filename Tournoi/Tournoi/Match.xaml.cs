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
using System.Windows.Threading;
using System.Timers;
using System.Data;
using System.Data.SqlClient;

namespace Tournoi
{
    /// <summary>
    /// Logique d'interaction pour Match.xaml
    /// </summary>
    public partial class Match : Window
    {
        #region Attribut
        DispatcherTimer timer = new DispatcherTimer();
        Sql sql = new Sql();
        Random rnd = new Random();
        Data data = new Data();
        private int increment = 0;
        private int one = 0;
        private int two = 0;
        int scoreTeamOne = 0;
        int scoreTeamTwo = 0;
        #endregion
        #region Fonction
        public Match()
        {
            InitializeComponent();
            try
            {
                AddTeamList();
                int oneTeamIndex = rnd.Next(data.listTeam.Count);
                int twoTeamIndex = rnd.Next(data.listTeam.Count);
                string oneTeam = data.listTeam[oneTeamIndex];
                string twoTeam = data.listTeam[twoTeamIndex];
                TeamOneMatchTextBlock.Text = oneTeam;
                TeamTwoMatchTextBlock.Text = twoTeam;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void StartButtonMatch_Click(object sender, RoutedEventArgs e)
        {
            timer.Start(); 
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            increment += 1;
            if (increment != 0)
            {
                TimerLabel.Content = increment.ToString();
            }

            scoreTeamOne = rnd.Next(2);
            scoreTeamTwo = rnd.Next(2);
            if (increment != 9)
            {
                if (increment > 0 && increment <= 9)
                {
                    if (scoreTeamOne == 1)
                    {
                        CompareOneTeam();
                        if (scoreTeamOne >= 1)
                        {
                            one += scoreTeamOne;
                            TeamOneMatchLabel.Content = one.ToString();
                        }
                    }
                    else if (scoreTeamTwo == 1)
                    {
                        CompareTwoTeam();
                        if (scoreTeamTwo >= 1)
                        {
                            two += scoreTeamTwo;
                            TeamTwoMatchLabel.Content = two.ToString();
                        }
                    }
                }
            }
            else
            {
                timer.Stop();
                if (one < two)
                {
                    MessageBox.Show(TeamTwoMatchTextBlock.Text + " won");
                }
                else if (one > two)
                {
                    MessageBox.Show(TeamOneMatchTextBlock.Text + " won");
                }
                else if (one == two)
                {
                    MessageBox.Show(TeamOneMatchTextBlock.Text + " and " + TeamTwoMatchTextBlock.Text + " have made a tie");
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
        }

        public void AddTeamList()
        {
            try
            {
                data.listTeam = new List<string>();
                sql.OpenConnection();
                string query = "select id_t, nom_t from Team";
                SqlCommand cmd = new SqlCommand(query, sql.con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        data.listTeam.Add(reader.GetString(1));
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                reader.Close();
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

        public void CompareOneTeam()
        {
            if (TeamOneMatchTextBlock.Text == "PSG")
            {
                int index = rnd.Next(Commentateur.ButPsg.Length);
                string but = Commentateur.ButPsg[index];
                CommentatorOneTextBlock.Inlines.Add('\n' + but);
            }
            else if (TeamOneMatchTextBlock.Text == "Barcelona")
            {
                int index = rnd.Next(Commentateur.ButBarca.Length);
                string but = Commentateur.ButBarca[index];
                CommentatorOneTextBlock.Inlines.Add('\n' + but);
            }
            else if (TeamOneMatchTextBlock.Text == "Juv")
            {
                int index = rnd.Next(Commentateur.ButJuv.Length);
                string but = Commentateur.ButJuv[index];
                CommentatorOneTextBlock.Inlines.Add('\n' + but);
            }
            if (TeamOneMatchTextBlock.Text == "Arsenal")
            {
                int index = rnd.Next(Commentateur.ButArsenal.Length);
                string but = Commentateur.ButArsenal[index];
                CommentatorOneTextBlock.Inlines.Add('\n' + but);
            }
            if (TeamOneMatchTextBlock.Text == "Marseille")
            { 
                int index = rnd.Next(Commentateur.ButMarseille.Length);
                string but = Commentateur.ButMarseille[index];
                CommentatorOneTextBlock.Inlines.Add('\n' + but);
            }
        }

        public void CompareTwoTeam()
        {
            if (TeamTwoMatchTextBlock.Text == "PSG")
            {
                int index = rnd.Next(Commentateur.ButPsg.Length);
                string but = Commentateur.ButPsg[index];
                CommentatorTwoTextBlock.Inlines.Add('\n' + but);
            }
            else if (TeamTwoMatchTextBlock.Text == "Barcelona")
            {
                int index = rnd.Next(Commentateur.ButBarca.Length);
                string but = Commentateur.ButBarca[index];
                CommentatorTwoTextBlock.Inlines.Add('\n' + but);
            }
            else if (TeamTwoMatchTextBlock.Text == "Arsenal")
            {
                int index = rnd.Next(Commentateur.ButArsenal.Length);
                string but = Commentateur.ButArsenal[index];
                CommentatorTwoTextBlock.Inlines.Add('\n' + but);
            }
            else if (TeamTwoMatchTextBlock.Text == "Juv")
            {
                int index = rnd.Next(Commentateur.ButPsg.Length);
                string but = Commentateur.ButJuv[index];
                CommentatorTwoTextBlock.Inlines.Add('\n' + but);
            }
            else if (TeamTwoMatchTextBlock.Text == "Marseille")
            {
                int index = rnd.Next(Commentateur.ButMarseille.Length);
                string but = Commentateur.ButMarseille[index];
                CommentatorTwoTextBlock.Inlines.Add('\n' + but);
            }
        }
        #endregion

        private void BackMatchButton_Click(object sender, RoutedEventArgs e)
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

        private void EndMatchButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sql.OpenConnection();
                if (one < two)
                {
                    string query = "Update Team set point += 3 where nom_t = @nom_t";
                    SqlCommand cmd = new SqlCommand(query, sql.con);
                    cmd.Parameters.AddWithValue("@nom_t", TeamTwoMatchTextBlock.Text);
                    cmd.ExecuteNonQuery();
                }
                else if (one > two)
                {
                    string query = "Update Team set point += 3 where nom_t = @nom_t";
                    SqlCommand cmd = new SqlCommand(query, sql.con);
                    cmd.Parameters.AddWithValue("@nom_t", TeamOneMatchTextBlock.Text);
                    cmd.ExecuteNonQuery();
                }
                else if (one == two)
                {
                    string query = "Update Team set point += 1 where nom_t = @nom_tOne and nom_t = @nom_tTwo";
                    SqlCommand cmd = new SqlCommand(query, sql.con);
                    cmd.Parameters.AddWithValue("@nom_tOne", TeamOneMatchTextBlock.Text);
                    cmd.Parameters.AddWithValue("@nom_tTwo", TeamTwoMatchTextBlock.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sql.CloseConnection();
                this.Close();
            }            
        }
    }
}
