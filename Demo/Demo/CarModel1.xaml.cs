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
    /// Interaction logic for CarModel1.xaml
    /// </summary>
    public partial class CarModel1 : UserControl
    {
        public static String car1 = "";
        public CarModel1()
        {
            InitializeComponent();
        }

        private void BlueisChecked(object sender, RoutedEventArgs e)
        {
            if (Brown.IsChecked ==true)
            {
                MainWindow.switchToBlueandBrown();
            }
            else if (Blue.IsChecked == true && Grey.IsChecked == true){
                MainWindow.switchToBlueandGrey();
            }
        }

        private void cancelclick(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToJohnMaysMainView();
        }

        private void backbutton(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToNewCarMainView();
        }

        private void greyis(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToRedandGrey();
        }

        private void redandbrown(object sender, RoutedEventArgs e)
        {
            car1 = "Make: Honda" + System.Environment.NewLine + "Model: X100" + System.Environment.NewLine + "Exterior Colour: Red" + System.Environment.NewLine + "Interior: Brown";
            MainWindow.switchToConfirmCar();
        }
    }
}
