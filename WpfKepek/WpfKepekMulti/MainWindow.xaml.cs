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

namespace WpfKepekMulti
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

        private void buttonBetolt_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = ".png|*.png|minden fájl|*.*";
            dialog.Multiselect = true;
            if (dialog.ShowDialog()==true)
            {
                if (dialog.FileNames.Length >= 4)
                {
                    imageElso.Source = new BitmapImage(new Uri(dialog.FileNames[0]));
                    imageMasodik.Source = new BitmapImage(new Uri(dialog.FileNames[1]));
                    imageHarmadik.Source = new BitmapImage(new Uri(dialog.FileNames[2]));
                    imageNegyedik.Source = new BitmapImage(new Uri(dialog.FileNames[3]));
                }
            }
        }
    }
}