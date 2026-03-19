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

namespace WpfSzamolas
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

        private void buttonSzamol_Click(object sender, RoutedEventArgs e)
        {
            //eredmeny=(szam1*szam2)/szam3

            try
            {
                double szam1 = Convert.ToDouble(textboxSzam1.Text);
                double szam2 = Convert.ToDouble(textboxSzam2.Text);
                double szam3 = Convert.ToDouble(textboxSzam3.Text);

                double eredmeny = (szam1 * szam2) / szam3;

                labelEredmeny.Content = eredmeny;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Számot kell megadni!", "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);                
            }

            
        }
    }
}