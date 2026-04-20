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
using WpfNobel.model;

namespace WpfNobel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<NobelDij> nobelDijasok=new List<NobelDij>();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void buttonBetoltes_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = ".csv fájlok|*.csv|minden fájl|*.*";
            try
            {
                if (dialog.ShowDialog()==true)
                {
                    nobelDijasok = LoadFromFile.LoadCsv(dialog.FileName, ';');
                    datagridNobel.ItemsSource = nobelDijasok;

                    var kategoriak = nobelDijasok.OrderBy(x=>x.Tipus).Select(x => x.Tipus).Distinct().ToList();
                    comboTipus.ItemsSource = kategoriak;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!");                
            }
        }

        private void buttonKereses_Click(object sender, RoutedEventArgs e)
        {
            //A keresés elején kiürítjük a datagridet.
            datagridNobel.ItemsSource = null;

            if (textboxKeresztnev.Text.Length>0)
            {
                //Keresés egyezésre
                //var result = nobelDijasok.FindAll(x => x.Keresztnev.ToLower() == textboxKeresztnev.Text.ToLower());

                //Keresés tartalmazás szerint
                var result = nobelDijasok.FindAll(x => x.Keresztnev.ToLower().Contains(textboxKeresztnev.Text.ToLower()));

                if (result.Count<1)
                {
                    MessageBox.Show("Nincs a feltételnek megfelelő adat!");
                } else
                {
                    datagridNobel.ItemsSource= result;
                }
            }
        }

        private void buttonVissza_Click(object sender, RoutedEventArgs e)
        {
            datagridNobel.ItemsSource = nobelDijasok;
        }

        private void comboTipus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (comboTipus.SelectedValue!=null)
            {
                var result = nobelDijasok.FindAll(x => x.Tipus == comboTipus.SelectedValue.ToString());
                datagridNobel.ItemsSource = result;
            }
        }

        private void buttonMentes_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog=new SaveFileDialog();
            dialog.Filter= ".csv fájlok|*.csv|minden fájl|*.*";

            try
            {
                if (dialog.ShowDialog()==true)
                {
                    FileStream fajl = new FileStream(dialog.FileName, FileMode.Create);
                    using (StreamWriter writer = new StreamWriter(fajl, Encoding.UTF8))
                    {
                        writer.WriteLine($"év;típus;keresztnév;vezetéknév");
                        foreach (var i in datagridNobel.ItemsSource as List<NobelDij>)
                        {
                            writer.WriteLine($"{i.Ev};{i.Tipus};{i.Keresztnev};{i.Vezeteknev}");
                        }
                    }
                    MessageBox.Show("Adatok kiírva!", "Mentés");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!");                
            }
        }
    }
}