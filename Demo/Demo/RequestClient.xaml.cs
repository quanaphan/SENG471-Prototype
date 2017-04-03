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
    /// Interaction logic for RequestClient.xaml
    /// </summary>
    public partial class RequestClient : UserControl
    {
        public static String client = "";
        public RequestClient()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToSalesPersonMainView();
        }

        private void requestclient_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToSalesPersonMainView();
            client = RequestedClient.Text;
        }
    }
}
