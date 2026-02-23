using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fajlkezeles
{
    public class Pilota2
    {
        public string Nev { get; set; }
        public string SzulDatum { get; set; }
        public string Nemzetiseg { get; set; }
        public string Rajtszam { get; set; }

        public Pilota2(string sor,char hatarolo)
        {
            var adatok = sor.Split(hatarolo);
            Nev = adatok[0];
            SzulDatum = adatok[1];
            Nemzetiseg = adatok[2];
            Rajtszam = adatok[3];
        }
    }
}
