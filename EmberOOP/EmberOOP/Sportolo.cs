using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmberOOP
{
    public class Sportolo:Ember
    {
        public string Sportag { get; set; }
        public Sportolo(string nev, int magassag, int eletkor,string sportag) : base(nev, magassag, eletkor)
        {
            Sportag = sportag;
        }

        public override void Eszik()
        {
            Console.WriteLine("A sportoló sokat eszik.");
        }

        public override void Iszik()
        {
            Console.WriteLine("A sportoló sokat iszik.");
        }

        public override void Mozog()
        {
            Console.WriteLine("A sportoló gyorsan mozog.");
        }
    }
}
