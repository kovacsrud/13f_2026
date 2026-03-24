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

namespace WpfHegyek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Hegy> Hegyek { get; set; }= new List<Hegy>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonBetoltes_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog=new OpenFileDialog();
            dialog.Filter = ".csv fájlok|*.csv| minden fájl|*.*";

            try
            {
                if (dialog.ShowDialog()==true)
                {
                    //datagridHegyek.ItemsSource = Betoltes.LoadFromCsv(dialog.FileName,';');

                    Hegyek= Betoltes.LoadFromCsv(dialog.FileName, ';');
                    datagridHegyek.ItemsSource = Hegyek;
                    this.Title = dialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }
    }
}