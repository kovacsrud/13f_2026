using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanulok
{
    public class Tanulo
    {
        public string Vezeteknev { get; set; }
        public string Keresztnev { get; set; }
        public string Osztaly { get; set; }
        public int SzuletesiEv { get; set; }

        public int Eletkor()
        {
            return DateTime.Now.Year - SzuletesiEv;
        }
    }
}
