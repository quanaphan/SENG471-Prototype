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
    /// Interaction logic for SalesPerson.xaml
    /// </summary>
    public partial class SalesPerson : UserControl
    {
        public SalesPerson()
        {
            InitializeComponent();
            if(LogIn.user == "1111111111")
            {
                JohnMays.IsEnabled = true;
                JohnMays.Content = "John Mays";
            }
            else
            {
                JohnMays.IsEnabled = false;
            }
            
        }

        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToLogInView();
        }

        private void SearchClient_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToSearchClientMainView();
        }

        private void RequestClient_Click(object sender, RoutedEventArgs e)
        {
            //Global variable, send name to Owner view
            MainWindow.switchRequestClientMainView();
        }

        private void JohnMaysChecked(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToJohnMaysMainView();
        }
    }
}
