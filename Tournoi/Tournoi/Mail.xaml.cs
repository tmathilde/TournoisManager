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
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Tournoi
{
    /// <summary>
    /// Logique d'interaction pour Mail.xaml
    /// </summary>
    public partial class Mail : Window
    {
        Sql sql = new Sql();
        public Mail()
        {
            InitializeComponent();
        }
    }

    private void MessageButton_Click(object sender, RoutedEventArgs e)
    {
        string mailRe = From.Text;
        string[] mailRecherche = mailRe.Split('@');
        string item = mailRecherche[1];
        //Console.WriteLine(item);
        if (item == "gmail.com")
        {
            MailMessage mail = new MailMessage(From.Text, To.Text, Subjet.Text, MessageTextBox.Text);
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.Credentials = new NetworkCredential(User.Text, Mdp.Password);
            client.EnableSsl = true;
            //client.UseDefaultCredentials = true;
            client.Send(mail);
            MessageBox.Show("mail sent", "success", MessageBoxButton.OK);
        }
        else if (item == "live.fr")
        {
            MailMessage mail = new MailMessage(From.Text, To.Text, Subjet.Text, MessageTextBox.Text);
            SmtpClient client = new SmtpClient("smtp.live.com");
            client.Port = 587;
            client.Credentials = new NetworkCredential(User.Text, Mdp.Password);
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("mail sent", "success", MessageBoxButton.OK);
        }
        else
        {
            MessageBox.Show("defefe");
        }
    }
}
