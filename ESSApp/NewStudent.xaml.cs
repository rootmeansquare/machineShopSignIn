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
    /// Interaction logic for NewStudent.xaml
    /// </summary>
    public partial class NewStudent : Window
    {
        SQLClass sqlClass;
        public NewStudent()
        {
            InitializeComponent();
            sqlClass = new SQLClass();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            Variables.newstudentid = StudentNumber.Text;
            Variables.newfirstname = FirstName.Text;
            Variables.newlastname = LastName.Text;
            Variables.newtype = ""; // ADD THIS FUNCTIONALITY
            Variables.newemail = Email.Text;
            Variables.newclass = ""; // ADD THIS FUNCTIONALITY

            sqlClass.newstudent();

            Variables.newstudentid = "";
            Variables.newfirstname = "";
            Variables.newlastname = "";
            Variables.newtype = ""; // ADD THIS FUNCTIONALITY
            Variables.newemail = "";
            Variables.newclass = ""; // ADD THIS FUNCTIONALITY
            this.Close();
        }
    }
}
