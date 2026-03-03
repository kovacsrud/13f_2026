using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hajok
{
    public class Teher : Hajo
    {
        public int SzallithatoTomeg { get; set; }
        public override void Haladas()
        {
            Console.WriteLine("A teherhajó motor segítségével halad.");
        }

        public override void Leiras()
        {
            Console.WriteLine("Masszív teherhajó, konténerek szállítására.");
        }

        public override string ToString()
        {
            return base.ToString()+$" Szállítható tömeg:{SzallithatoTomeg}";
        }
    }
}
