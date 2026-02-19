using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmberOOP
{
    public class Nyugdijas:Ember
    {
        public int MunkaviszonyHossza { get; set; }
        public Nyugdijas(string nev, int magassag, int eletkor,int munkaviszonyhossza) : base(nev, magassag, eletkor)
        {
            MunkaviszonyHossza = munkaviszonyhossza;
        }

        public override void Eszik()
        {
            Console.WriteLine("A nyugdíjas keveset eszik.");
        }

        public override void Iszik()
        {
            Console.WriteLine("A nyugdíjas vizet iszik.");
        }

        public override void Mozog()
        {
            Console.WriteLine("A nyugdíjas lassan mozog.");
        }
    }
}
