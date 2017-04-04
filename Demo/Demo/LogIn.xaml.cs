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
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : UserControl
    {
        public static String user = "DefaultUser";
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            user = username.Text;
            if (user == "0000000000") { 
                MainWindow.switchToOwnerMainView();
            }
            else if (user == "1111111111")
            {
                MainWindow.switchToSalesPersonMainView();
            }
            else if (user == "2222222222")
            {
                MainWindow.switchToSalesPersonMainView();
            }
        }
    }
}
