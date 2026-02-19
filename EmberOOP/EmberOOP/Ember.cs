using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmberOOP
{
    //absztrakt osztály: nem példányosítható, csak öröklési célokat szolgál
    public abstract class Ember
    {

        public string Nev { get; set; }
        public int Magassag { get; set; }
        public int Eletkor { get; set; }

        protected Ember(string nev, int magassag, int eletkor)
        {
            Nev = nev;
            Magassag = magassag;
            Eletkor = eletkor;
        }

        public abstract void Eszik();
        public abstract void Iszik();
        public abstract void Mozog();

        public override string ToString()
        {
            return $"{Nev},{Magassag},{Eletkor}";
        }

        
    }
}
