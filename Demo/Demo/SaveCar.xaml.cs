﻿using System;
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
    /// Interaction logic for SaveCar.xaml
    /// </summary>
    public partial class SaveCar : UserControl
    {
        public SaveCar()
        {
            InitializeComponent();
            if (CarModel1.car1 != "")
            {
                carconfirmation.Text = CarModel1.car1 + System.Environment.NewLine + "Dealer:" + LogIn.user + System.Environment.NewLine + "Client: John Mays";
            }
            else if (CarModel2.car2 != "")
            {
                carconfirmation.Text = CarModel2.car2 + System.Environment.NewLine + "Dealer:" + LogIn.user + System.Environment.NewLine + "Client: John Mays";
            }
            else if (CarModel3.car3 != "")
            {
                carconfirmation.Text = CarModel3.car3 + System.Environment.NewLine + "Dealer:" + LogIn.user + System.Environment.NewLine + "Client: John Mays";
            }
            else if (CarModel4.car4 != "")
            {
                carconfirmation.Text = CarModel4.car4 + System.Environment.NewLine + "Dealer:" + LogIn.user + System.Environment.NewLine + "Client: John Mays";
            }
        }

        private void okbutton(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToJohnMaysMainView();
        }


        private void cancelbutton(object sender, RoutedEventArgs e)
        {
            MainWindow.switchToJohnMaysMainView();
        }
    }
}
