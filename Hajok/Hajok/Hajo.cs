using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hajok
{
    public abstract class Hajo
    {
        public string Nev { get; set; }
        public int Hossz { get; set; }
        public int Suly { get; set; }
        public int MaxSebesseg { get; set; }
        public int GyartasEve { get; set; }

        public abstract void Haladas();
        public abstract void Leiras();

        public double MegteszTavolsag(double tavolsag)
        {
            return tavolsag / MaxSebesseg;
        }

        public override string ToString()
        {
            return $"Nev:{Nev},Hossz:{Hossz},Suly:{Suly},MaxSebesseg:{MaxSebesseg},Gyártás éve:{GyartasEve}";
        }
       

        
    }
}
