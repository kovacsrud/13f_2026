using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAdatBinding.model
{
    public class Dron
    {
        public string Nev { get; set; }
        public string Tipus { get; set; }
        public int GyartEv { get; set; }
        public int MaxSeb { get;set; }
        public int AkkuKapacitas { get; set; }
        public int RepulesiIdo { get; set; }

        public Dron(string sor,char hatarolo)
        {
            var adatok = sor.Split(hatarolo);
            Nev = adatok[0];
            Tipus = adatok[1];
            GyartEv=Convert.ToInt32(adatok[2]);
            MaxSeb=Convert.ToInt32(adatok[3]);
            AkkuKapacitas=Convert.ToInt32(adatok[4]);
            RepulesiIdo=Convert.ToInt32(adatok[5]);
        }
    }
}
