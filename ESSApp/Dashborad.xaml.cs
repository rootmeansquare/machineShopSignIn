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

namespace ESSApp
{
    /// <summary>
    /// Interaction logic for Dashborad.xaml
    /// </summary>
    public partial class Dashborad : Window
    {
        
        public Dashborad(DataTable results)
        {
            InitializeComponent();
            StudentName.Content = results.Rows[0][1].ToString() + results.Rows[0][2].ToString();
            Student_Number.Content = results.Rows[0][0].ToString();
            Variables.currentstudent = results.Rows[0][6].ToString();
            
        }
        WaitList waitList = new WaitList();
        private void WaitList_Click(object sender, RoutedEventArgs e)
        {
            waitList.ShowDialog();
        }
    }
}
