namespace Interfesz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interfész");
            //A feladat olyan osztályok készítése, amelyek síkidomokat tudnak "leírni",
            //azaz tudják egy adott síkidom adatait tárolni, illetve a megfelelő metódusok
            //meg tudják határozni az adott síkidom kerületét és területét

            //Probléma: rengeteg síkidom van, az adataik eltérőek és kerületüket valamint a
            //területüket is máshogyan kell kiszámolni

            //Közös pont: a kerület és a terület
            //Az egyik megoldás az absztrakt osztály

            Teglalap t1 = new Teglalap(10, 22);
            Console.WriteLine($"Kerület:{t1.Kerulet()},Terület:{t1.Terulet()}");
            Kor k1 = new Kor(23);
            Console.WriteLine($"Kerület:{k1.Kerulet()},Terület:{k1.Terulet()}");

            List<ISikidom> sikidomok = new List<ISikidom>();
            sikidomok.Add(t1);
            sikidomok.Add(k1);

            sikidomok.Add(new Teglalap(33, 11));
            sikidomok.Add(new Teglalap(6, 9));
            sikidomok.Add(new Teglalap(58, 73));
            sikidomok.Add(new Teglalap(98, 31));

            sikidomok.Add(new Kor(34));
            sikidomok.Add(new Kor(11));
            sikidomok.Add(new Kor(68));
            sikidomok.Add(new Kor(91));

            //Mennyi a síkidomok összes kerülete/területe:
            var osszKerulet = sikidomok.Sum(x=>x.Kerulet());
            var osszTerulet = sikidomok.Sum(x => x.Terulet());

            Console.WriteLine($"Össz kerület:{osszKerulet:0.00}, össz. terület:{osszTerulet:0.00}");

            //Körök kerülete/területe?
            var korokKerulete = sikidomok.FindAll(x=>x.GetType()==typeof(Kor)).Sum(x=>x.Kerulet());
            var korokTerulete=sikidomok.FindAll(x=>x.GetType()==typeof(Kor)).Sum(x=>x.Terulet());

            Console.WriteLine($"Körök kerülete:{korokKerulete:0.00},körök területe:{korokTerulete:0.00}");

            //Haromszog: (a*m)/2

            sikidomok.Add(new Haromszog(10, 12, 13, 8));
            sikidomok.Add(new Haromszog(12, 14, 16, 10));

            foreach (var i in sikidomok)
            {
                if (i.GetType() == typeof(Kor))
                {
                    Kor kor= (Kor)i;
                    Console.WriteLine($"Sugár:{kor.Sugar}");
                }
                if (i.GetType()==typeof(Teglalap))
                {
                    Teglalap t = (Teglalap)i;
                    Console.WriteLine($"Téglalap oldalai:{t.Aoldal},{t.Boldal}");
                }
                if (i.GetType() == typeof(Haromszog))
                {
                    Haromszog h = (Haromszog)i;
                    Console.WriteLine($"Háromszög odalai:{h.Aoldal},{h.Boldal},{h.Coldal}");
                }
            }


        }
    }
}
