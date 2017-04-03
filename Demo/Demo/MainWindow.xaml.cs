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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static MainWindow m;
        public MainWindow()
        {
    
            m = this; 
            InitializeComponent();
            LogIn login = new LogIn();
            sp.Children.Add(login);

        }

        private void switchTo(UserControl u)
        {
            sp.Children.Clear();
            sp.Children.Add(u);
        }
        public static void switchToLogInView()
        {
            LogIn lg = new LogIn();
            m.switchTo(lg);
        }

        public static void switchToOwnerMainView()
        {
            Owner o = new Owner();
            m.switchTo(o);
        }
        public static void switchToSalesPersonMainView()
        {
            SalesPerson s = new SalesPerson();
            m.switchTo(s);
        }
        public static void switchToSearchClientMainView()
        {
            SearchClient sc = new SearchClient();
            m.switchTo(sc);
        }
        public static void switchToNewCarMainView()
        {
            NewCar sc = new NewCar();
            m.switchTo(sc);
        }
        public static void switchToJohnMaysMainView()
        {
            JohnMays jm = new JohnMays();
            m.switchTo(jm);
        }
        public static void switchaddNotesMainView()
        {
            AddNote note = new AddNote();
            m.switchTo(note);
        }
        public static void switchPrevNotesMainView()
        {
            PreviousNotes note = new PreviousNotes();
            m.switchTo(note);
        }
        public static void switchRequestClientMainView()
        {
            RequestClient c = new RequestClient();
            m.switchTo(c);
        }
    }
}
