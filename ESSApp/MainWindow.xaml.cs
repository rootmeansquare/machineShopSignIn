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
using System.Data;

namespace ESSApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SQLClass sqlClass;
        public MainWindow()
        {
            InitializeComponent();
            sqlClass = new SQLClass();
        }

        private void Go_Click(object sender, RoutedEventArgs e)
        {
            NewStudent newStudent = new NewStudent();
           
            DataTable results = new DataTable();

           results = sqlClass.getStudent(IDnum.Text);
            if (results.Rows.Count == 0)
            {
                newStudent.ShowDialog();
            }
            else
            {
               Dashborad dash = new Dashborad(results);
               dash.ShowDialog();
                
            }

        }
    }
}
