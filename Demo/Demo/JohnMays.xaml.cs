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
    /// Interaction logic for JohnMays.xaml
    /// </summary>
    public partial class JohnMays : UserControl
    {
        public JohnMays()
        {
            InitializeComponent();
            if (LogIn.user == "Tom") {
                NewCar.IsEnabled = false;
               // PreviousCar.IsEnabled = false;
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToSalesPersonMainView();
        }

        private void NewCar_Click(object sender, RoutedEventArgs e)
        {
            if (LogIn.user == "Sam")
            {
                MainWindow.switchToNewCarMainView();
            }
            else
            {
                
            }
        }

        private void Addnote_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchaddNotesMainView();
        }

        private void PrevNotes_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchPrevNotesMainView();
        }
    }
}
