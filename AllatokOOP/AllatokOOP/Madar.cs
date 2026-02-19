using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatokOOP
{
    public class Madar:Allat
    {
        //A base() függvény az ős osztály valamelyik metódusának a meghívására szolgál
        public int SzarnyFesztav { get; set; }
        public Madar(string nev, string faj, int kor,int suly,int szarnyfesztav) : base(nev, faj, kor, suly)
        {
            SzarnyFesztav = szarnyfesztav;
        }

       public void Hang()
       {
            Console.WriteLine("A madár csipog.");
       }
        //Az override kulcsszó segítségével tudjuk felülírni az ős osztály metódusait.
        public override void Eszik()
        {
            Console.WriteLine("A madár a csőrével eszik.");
        }

        public override void Mozog()
        {
            Console.WriteLine("A madár repül");
        }

        public override void Iszik()
        {
            Console.WriteLine("A madár a csőrével iszik");
        }

        public override string ToString()
        {
            return base.ToString()+$"Szárny fesztáv:{SzarnyFesztav}";
        }
    }
}
