using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmberOOP
{
    public class Dolgozo:Ember
    {
        public string Munkahely { get; set; }
        public Dolgozo(string nev, int magassag, int eletkor,string munkahely) : base(nev, magassag, eletkor)
        {
            Munkahely = munkahely;
        }

        

        public override void Eszik()
        {
            Console.WriteLine("A dolgozó a menzán eszik.");
        }

        public override void Iszik()
        {
            Console.WriteLine("A dolgozó keveset iszik.");
        }

        public override void Mozog()
        {
            Console.WriteLine("A dolgozó megfontoltan mozog.");
        }
    }
}
