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

namespace Demo
{
    /// <summary>
    /// Interaction logic for Owner.xaml
    /// </summary>
    public partial class Owner : UserControl
    {
        public Owner()
        {
            InitializeComponent();
            if (RequestClient.client != "")
            {
                Request.IsEnabled = true;
                Request.Content = RequestClient.client + System.Environment.NewLine + "Requested by: " + LogIn.user;
            }
            else 
            {
                Request.IsEnabled = false;
            }
        }

        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToLogInView();
        }

        private void Request_Checked(object sender, RoutedEventArgs e)
        {
            //create new client
        }
    }
}
