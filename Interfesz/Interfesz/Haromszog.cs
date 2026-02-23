using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfesz
{
    public class Haromszog : ISikidom
    {

        public double Aoldal { get; set; }
        public double Boldal { get; set; }
        public double Coldal { get; set; }
        public double AMagassag { get; set; }
        public Haromszog(double aoldal, double boldal, double coldal, double aMagassag)
        {
            Aoldal = aoldal;
            Boldal = boldal;
            Coldal = coldal;
            AMagassag = aMagassag;
        }

        
        public double Kerulet()
        {
            return Aoldal + Boldal + Coldal;
                
        }

        public double Terulet()
        {
            return (Aoldal * AMagassag) / 2;
        }
    }
}
