using Microsoft.Win32;
using System.Runtime.CompilerServices;
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
using WpfFileList.model;

namespace WpfFileList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public FileList FileList { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            FileList = new FileList();


            listboxFajlok.DataContext=FileList;
        }

        private void buttonTallozas_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = ".png|*.png|.jpg|*.jpg|minden fájl|*.*";
            dialog.Multiselect = true;
            if (dialog.ShowDialog()==true)
            {
                //listboxFajlok.ItemsSource = dialog.FileNames;
                //imageKep.Source = new BitmapImage(new Uri(dialog.FileNames.First()));
                FileList.SetFileList(dialog.FileNames,'\\');
                listboxFajlok.SelectedIndex = 0;

            }
        }

        private void listboxFajlok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //imageKep.Source = new BitmapImage(new Uri(listboxFajlok.SelectedItem.ToString()));
            if (listboxFajlok.SelectedItem!=null)
            {
                var selected = (FileItem)listboxFajlok.SelectedItem;
                imageKep.Source = new BitmapImage(new Uri(selected.FullPath));
            }


        }
    }
}