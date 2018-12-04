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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tournoi
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void infoTournoi_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                InfoTournoi infoTournoi = new InfoTournoi();
                infoTournoi.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void infoTeam_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                InfoTeam infoTeam = new InfoTeam();
                infoTeam.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void infoPlayer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                InfoPlayer infoPlayer = new InfoPlayer();
                infoPlayer.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void contact_Click(object sender, RoutedEventArgs e)
        {
            Mail mail = new Mail();
            mail.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Match match = new Match();
            match.Show();
        }
    }
}
