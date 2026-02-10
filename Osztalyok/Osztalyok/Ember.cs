using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
    public class Ember
    {
        //propery => változó+ lekérdező függvény+ beállító függvény 3 in 1
        public string Vezeteknev { get; set; }
        public string Keresztnev { get; set; }

        private int szuletesiev;

        

        public int SzuletesiEv {
            get { return szuletesiev; }
            set {
                if (value>=1920 && value<=2026)
                {
                    szuletesiev = value;
                } else
                {
                    throw new ArgumentException("Hibás születési év!");
                }
            } 
        }

        //üres konstruktor
        public Ember()
        {
            
        }

        //paraméteres konstruktor
        public Ember(string vezeteknev, string keresztnev, int szuletesiEv)
        {
            Vezeteknev = vezeteknev;
            Keresztnev = keresztnev;
            SzuletesiEv = szuletesiEv;
        }

        public int GetEletkor()
        {
            return DateTime.Now.Year - szuletesiev;
        }
    }
}
