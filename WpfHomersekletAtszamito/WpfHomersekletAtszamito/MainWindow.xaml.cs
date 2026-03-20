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

namespace WpfHomersekletAtszamito
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Grafikus felület inicializálása
            //Ha "véletlenül" kitöröljük, akkor a program futásakor egy üres ablakot fogunk látni
            InitializeComponent();
            this.Title = "Hőmérséklet átszámítás";
        }

        private void buttonSzamol_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (radioCelsius.IsChecked==true)
                {
                    textblockEredmeny.Text = HomersekletAtvalto.FahrenheitToCelsius(Convert.ToDouble(textboxHomerseklet.Text)).ToString()+" C";
                } else
                {
                    textblockEredmeny.Text = HomersekletAtvalto.CelsiusToFahrenheit(Convert.ToDouble(textboxHomerseklet.Text)).ToString()+" F";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!");                
            }
        }
    }
}