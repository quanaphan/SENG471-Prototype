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
    /// Interaction logic for CarMaker.xaml
    /// </summary>
    public partial class CarMaker : UserControl
    {
        public CarMaker()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToJohnMaysMainView();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToJohnMaysMainView();
        }

        private void hondaclick(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToNewCarMainView();
        }
    }
}
