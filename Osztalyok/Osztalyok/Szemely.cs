using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
    public class Szemely
    {
        private string vezeteknev;
        private string keresztnev;
        private int szuletesiev;

        //Konstruktor
        //Nincs visszatérési értéke és nem is void
        //A neve meg kell hogy egyezzen az osztály nevével
        //Automatikusan lefut, amikor példányosítjuk az osztályt
        //Overloading ugyanúgy mint a függvényeknél

        public Szemely(string vezeteknev,string knev,int szulev)
        {
            this.vezeteknev = vezeteknev;
            keresztnev= knev;
            szuletesiev = szulev;
        }

        public void SetNev(string vezeteknev,string keresztnev)
        {
            if (vezeteknev.Length>2 && keresztnev.Length>2)
            {
                this.vezeteknev = vezeteknev;
                this.keresztnev = keresztnev;
            } else
            {
                throw new ArgumentException("Túl rövid név!");
            }
            
        }

        public string GetNev() {
            return $"{vezeteknev} {keresztnev}";
        }

        public void SetSzuletesiEv(int szuletesiev) {
            if (szuletesiev>1920 && szuletesiev<=2026)
            {
                this.szuletesiev = szuletesiev;
            } else
            {
                throw new ArgumentException("Hibás születési év!");
            }
        }

        public int GetSzuletesiev() {
            return szuletesiev;
        }
    }
}
