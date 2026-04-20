using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfNobel.model
{
    public class NobelDij
    {
        public int Ev { get; set; }
        public string Tipus { get; set; }
        public string Vezeteknev { get; set; }
        public  string Keresztnev { get; set; }

        public NobelDij(string sor,char hatarolo)
        {
            var adatok = sor.Split(hatarolo);
            Ev=Convert.ToInt32(adatok[0]);
            Tipus=adatok[1];
            Keresztnev=adatok[2];
            Vezeteknev=adatok[3];
        }
    }
}
