using Microsoft.Win32;
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
using System.Windows.Threading;

namespace WpfSlideshow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int szamlalo = 0;
        DispatcherTimer timer;
        string[] kepfajlok;
        int speed = 1;
        public MainWindow()
        {
            InitializeComponent();
            timer= new DispatcherTimer(TimeSpan.FromSeconds(1),DispatcherPriority.Normal,Kepcsere,Dispatcher.CurrentDispatcher);
            timer.Stop();
           
        }

        private void Kepcsere(object? sender, EventArgs e)
        {
            kep.Source = new BitmapImage(new Uri(kepfajlok[szamlalo]));
            szamlalo++;
            if (szamlalo>=kepfajlok.Length)
            {
                szamlalo = 0;
            }
        }

        private void buttonBetoltes_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Filter = ".png|*.png|minden fájl|*.*";
            if (dialog.ShowDialog()==true)
            {
                kepfajlok = dialog.FileNames;
                timer.Start();
                buttonIdozito.IsEnabled = true;
                buttonIdozito.Content = "Stop";
            }
        }

        private void buttonIdozito_Click(object sender, RoutedEventArgs e)
        {
            timer.IsEnabled = !timer.IsEnabled;
            if (timer.IsEnabled)
            {
                buttonIdozito.Content = "Stop";
            }
            else
            {
                buttonIdozito.Content = "Start";
            }
        }
    }
}