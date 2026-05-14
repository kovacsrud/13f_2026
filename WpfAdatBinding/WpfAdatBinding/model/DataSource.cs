using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfAdatBinding.fileload;

namespace WpfAdatBinding.model
{
    public class DataSource
    {
        public List<Airport> Airports { get; set; } = new List<Airport>();
        public List<Dron> Drones { get; set; } = new List<Dron>();

        public DataSource()
        {
            try
            {
                Airports = LoadFromFile.LoadAirports("airports_pv.csv", ';');
                Drones = LoadFromFile.LoadDrones("dronok.csv", ',');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);                
            }
        }
    }
}
