using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBindingInotify
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Allapot allapot=new Allapot();
        public MainWindow()
        {
            InitializeComponent();
            //Adatforrás beállítása
            DataContext = allapot;
            allapot.Ertek = 20;
        }
    }
}