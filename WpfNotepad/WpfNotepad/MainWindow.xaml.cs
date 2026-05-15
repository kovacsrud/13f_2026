using Microsoft.Win32;
using System.IO;
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

namespace WpfNotepad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool modositva=false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menuitemMegnyitas_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = ".txt|*.txt|.csv|*.csv|.html|*.html|minden fájl|*.*";
            if (dialog.ShowDialog()==true)
            {
                try
                {
                    textboxSzoveg.Text=File.ReadAllText(dialog.FileName,Encoding.UTF8);
                    this.Title = dialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);                    
                }
            }
        }

        private void MentesMaskent()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = ".txt|*.txt|.csv|*.csv|.html|*.html|minden fájl|*.*";
            if (dialog.ShowDialog() == true) {
                try
                {
                    File.WriteAllText(dialog.FileName,textboxSzoveg.Text,Encoding.UTF8);
                    this.Title = dialog.FileName;
                    modositva = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void menuitemMentes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuitemMentesMaskent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuitemKilepes_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void menuitemKivagas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuitemMasolas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuitemBeillesztes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void textboxSzoveg_TextChanged(object sender, TextChangedEventArgs e)
        {
            modositva = true;
        }
    }
}