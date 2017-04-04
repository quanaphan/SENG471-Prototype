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
    /// Interaction logic for AddNote.xaml
    /// </summary>
    public partial class AddNote : UserControl
    {
        public static String note = "";
        public AddNote()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LogIn.user == "1111111111")
            {
                note = "April 7, 2017, added by " + "Sam" + System.Environment.NewLine + notebox.Text;
            }
            else if (LogIn.user == "2222222222")
            {
                note = "April 7, 2017, added by " + "Tom" + System.Environment.NewLine + notebox.Text;
            }
            MainWindow.switchToJohnMaysMainView();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToJohnMaysMainView();
        }

        private void ScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
