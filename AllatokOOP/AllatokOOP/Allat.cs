using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllatokOOP
{
    public class Allat
    {
        public string Nev { get; set; }
        public string Faj { get; set; }
        public int Kor { get; set; }
        public int Suly { get; set; }

        public Allat(string nev, string faj, int kor,int suly)
        {
            Nev = nev;
            Faj = faj;
            Kor = kor;
            Suly = suly;
        }

        //A virtual kulcsszó használatával engedélyezzük a metódus felülírását az utód osztályban
        public virtual void  Eszik()
        {
            Console.WriteLine("Az állat eszik.");
        }

        public virtual void Iszik()
        {
            Console.WriteLine("Az állat iszik");
        }

        public virtual void Mozog()
        {
            Console.WriteLine("Az állat mozog");
        }

        public override string ToString()
        {
            return $"Név:{Nev},Faj:{Faj},Kor:{Kor},Suly:{Suly}";
        }



    }
}
