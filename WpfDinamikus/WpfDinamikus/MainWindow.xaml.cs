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

namespace WpfDinamikus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Dinamikus elemek";
            GombGeneralas(100);
        }

        private void GombGeneralas(int db)
        {
            for (int i = 0; i < db; i++)
            {
                Button button = new Button();
                button.Content = $"{i + 1}";
                button.Width = 100;
                button.Margin = new Thickness(3);
                wrapGombok.Children.Add(button);
                button.Click += GombClick;
                button.MouseRightButtonDown += TorolClick;
            }
            
        }

        private void GombClick(object sender,RoutedEventArgs e)
        {
            Button gomb=(Button)sender;
            //Button gomb=sender as Button;
            textblockFelirat.Text = gomb.Content.ToString();
            gomb.Background = Brushes.Green;
            gomb.Foreground = Brushes.Yellow;

        }

        private void TorolClick(object sender, RoutedEventArgs e) 
        {
            Button gomb=(Button)sender;
            //wrapGombok.Children.Remove(gomb);
            gomb.ClearValue(Button.BackgroundProperty);
            gomb.ClearValue(Button.ForegroundProperty);

        }


    }
}