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
using WpfAdatBinding.ablakok;
using WpfAdatBinding.model;

namespace WpfAdatBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new DataSource();
        }

        private void menuitemDronok_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuitemRepterek_Click(object sender, RoutedEventArgs e)
        {
            var dc=DataContext as DataSource;
            AirportsWin airports = new AirportsWin { DataContext=dc };
            airports.ShowDialog();
        }

        private void menuitemMobilok_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuitemKilepes_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}