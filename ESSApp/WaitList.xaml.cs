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

namespace ESSApp
{
    /// <summary>
    /// Interaction logic for WaitList.xaml
    /// </summary>
    public partial class WaitList : Window
    {
        public WaitList()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            message.To.Add(Variables.currentstudent);
            message.Subject = "ESS Machine Open";
            message.From = new System.Net.Mail.MailAddress("imaad.umar@outlook.com");
            message.Body = "Your machines is ready, you have 15 mins to sign in and confirm before the machine is given to the next person in line.";
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("imaad.umar@outlook.com", "f58jmmlexus");
            smtp.Host= "smtp.live.com";
            smtp.Send(message);
        }
    }
}
