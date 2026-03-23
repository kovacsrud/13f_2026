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
using WpfWindow.views;

namespace WpfWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menuitemKilepes_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void menitemAblak1_Click(object sender, RoutedEventArgs e)
        {
            Ablak1 ablak1 = new Ablak1();
            ablak1.Show();
        }

        private void menitemAblak2_Click(object sender, RoutedEventArgs e)
        {
            Ablak2 ablak2 = new Ablak2();
            ablak2.ShowDialog();
        }

        private void menitemAblak3_Click(object sender, RoutedEventArgs e)
        {
            Ablak3 ablak3 = new Ablak3();
            ablak3.ShowDialog();
        }
    }
}