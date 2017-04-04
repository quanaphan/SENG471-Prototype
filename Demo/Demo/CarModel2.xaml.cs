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
    /// Interaction logic for CarModel2.xaml
    /// </summary>
    public partial class CarModel2 : UserControl
    {
        public static String car2 = "";
        public CarModel2()
        {
            InitializeComponent();
        }

        private void bulechecked(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToBlueandGrey();
        }

        private void browncheck(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToRedandBrown();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToJohnMaysMainView();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToNewCarMainView();
        }

        private void redandgrey(object sender, RoutedEventArgs e)
        {
            car2 = "Make: Honda" + System.Environment.NewLine + "Model: X100" + System.Environment.NewLine + "Exterior Colour: Red" + System.Environment.NewLine + "Interior: Grey";
            MainWindow.switchToConfirmCar();

        }
    }
}
