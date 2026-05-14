using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAdatBinding.model;

namespace WpfAdatBinding.fileload
{
    public static class LoadFromFile
    {
        public static List<Airport> LoadAirports(string fajl,char hatarolo,int start=1) {
            List<Airport> airports = new List<Airport>();

            var sorok=File.ReadAllLines(fajl,Encoding.UTF8);

            for (int i = start; i < sorok.Length; i++)
            {
                airports.Add(new Airport(sorok[i], hatarolo));
            }


            return airports;
        }

        public static List<Dron> LoadDrones(string fajl,char hatarolo,int start = 1)
        {
            List<Dron> dronok= new List<Dron>();
            var sorok = File.ReadAllLines(fajl, Encoding.UTF8);

            for (int i = start; i < sorok.Length; i++)
            {
                dronok.Add(new Dron(sorok[i], hatarolo));
            }

            return dronok;
        }
    }
}
