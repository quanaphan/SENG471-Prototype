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
    /// Interaction logic for CarModel4.xaml
    /// </summary>
    public partial class CarModel4 : UserControl
    {
        public static String car4 = "";
        public CarModel4()
        {
            InitializeComponent();
        }

        private void redchecked(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToRedandGrey();
        }

        private void brownchecked(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToBlueandBrown();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToJohnMaysMainView();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToNewCarMainView();
        }

        private void blueandgrey(object sender, RoutedEventArgs e)
        {
            car4 = "Make: Honda" + System.Environment.NewLine + "Model: X100" + System.Environment.NewLine + "Exterior Colour: Blue" + System.Environment.NewLine + "Interior: Grey";
            MainWindow.switchToConfirmCar();
        }
    }
}
