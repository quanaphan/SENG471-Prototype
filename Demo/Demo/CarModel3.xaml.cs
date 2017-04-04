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
    /// Interaction logic for CarModel3.xaml
    /// </summary>
    public partial class CarModel3 : UserControl
    {
        public static String car3 = "";
        public CarModel3()
        {
            InitializeComponent();
        }

        private void redchecked(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToRedandBrown();
        }

        private void bluechecked(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToBlueandGrey();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToJohnMaysMainView();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToNewCarMainView();
        }

        private void blueandbrown(object sender, RoutedEventArgs e)
        {
            car3 = "Make: Honda" + System.Environment.NewLine + "Model: X100" + System.Environment.NewLine + "Exterior Colour: Blue" + System.Environment.NewLine + "Interior: Brown";
            MainWindow.switchToConfirmCar();
        }
    }
}
