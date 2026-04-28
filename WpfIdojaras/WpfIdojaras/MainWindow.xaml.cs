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

namespace WpfIdojaras
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Idojaras> IdoJarasLista=new List<Idojaras>();
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                IdoJarasLista = LoadFromFile.LoadIdojaras("idojaras.csv", ';');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }

            var evek = IdoJarasLista.OrderBy(x => x.Ev).Select(x => x.Ev).Distinct().ToList();
            listboxEvek.ItemsSource = evek;

        }

        private void listboxEvek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var kivalasztottEv = (int)listboxEvek.SelectedItem;
            var kivalasztottEvAdatai=IdoJarasLista.FindAll(x=>x.Ev==kivalasztottEv);
            if (kivalasztottEvAdatai.Count < 1)
            {
                MessageBox.Show("Ehhez az évhez nem tartoznak adatok!");
            } else
            {
                datagridIdojaras.ItemsSource = kivalasztottEvAdatai;
                listboxHonapok.ItemsSource = kivalasztottEvAdatai.OrderBy(x => x.Honap).Select(x => x.Honap).Distinct().ToList();
                HoStat(kivalasztottEvAdatai);
                SzelStat(kivalasztottEvAdatai);
                ParaStat(kivalasztottEvAdatai);
            }
        }

        private void HoStat(List<Idojaras> adatok)
        {
            var atlag = adatok.Average(x => x.Homerseklet);
            var max = adatok.Max(x => x.Homerseklet);
            var min = adatok.Min(x => x.Homerseklet);
            textblockAtlagHo.Text = atlag.ToString();
            textblockMinHo.Text = min.ToString();
            textblockMaxHo.Text = max.ToString();   
        }

        private void SzelStat(List<Idojaras> adatok)
        {
            var atlag = adatok.Average(x => x.Szelsebesseg);
            var max = adatok.Max(x => x.Szelsebesseg);
            var min = adatok.Min(x => x.Szelsebesseg);
            textblockAtlagSzel.Text = atlag.ToString();
        }

        private void ParaStat(List<Idojaras> adatok)
        {
            var atlag = adatok.Average(x => x.Paratartalom);
            var max = adatok.Max(x => x.Paratartalom);
            var min = adatok.Min(x => x.Paratartalom);
            textblockAtlagPara.Text = atlag.ToString();
        }


        private void listboxHonapok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var kivalasztottEv = (int)listboxEvek.SelectedItem;
            var kivalasztottHonap = (int)listboxHonapok.SelectedItem;
            var kivalasztottEvHonapAdatai = IdoJarasLista.FindAll(x=>x.Ev==kivalasztottEv && x.Honap==kivalasztottHonap);
            if (kivalasztottEvHonapAdatai.Count<1)
            {
                MessageBox.Show("A kiválasztott hónaphoz nem tartoznak adatok!");
            } else
            {
                datagridIdojaras.ItemsSource = kivalasztottEvHonapAdatai;
                listboxNapok.ItemsSource=kivalasztottEvHonapAdatai.OrderBy(x=>x.Nap).Select(x=>x.Nap).Distinct().ToList();

                HoStat(kivalasztottEvHonapAdatai);
                SzelStat(kivalasztottEvHonapAdatai);
                ParaStat(kivalasztottEvHonapAdatai);
            }
        }

        private void listboxNapok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var kivalasztottEv = (int)listboxEvek.SelectedItem;
            var kivalasztottHonap = (int)listboxHonapok.SelectedItem;
            var kivalasztottNap = (int)listboxNapok.SelectedItem;
            var kivalasztottEvHonapNapAdatai=IdoJarasLista.FindAll(x=>x.Ev==kivalasztottEv && x.Honap==kivalasztottHonap && x.Nap==kivalasztottNap);
            if (kivalasztottEvHonapNapAdatai.Count<1)
            {
                MessageBox.Show("A kiválasztott aphoz nem tartoznak adatok!");
            } else
            {
                datagridIdojaras.ItemsSource = kivalasztottEvHonapNapAdatai;
                HoStat(kivalasztottEvHonapNapAdatai);
            }

        }
    }
}