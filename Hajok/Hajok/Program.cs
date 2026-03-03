namespace Hajok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hajók");
            List<Hajo> hajok= new List<Hajo>();

            

            hajok.Add(new Vitorlas {
                GyartasEve=1990,
                Hossz=10,
                MaxSebesseg=25,
                Nev="V1",
                Suly=1000,
                VitorlakSzama=6
            });

            hajok.Add(new Vitorlas
            {
                GyartasEve = 1995,
                Hossz = 12,
                MaxSebesseg = 24,
                Nev = "V2",
                Suly = 1200,
                VitorlakSzama = 10
            });

            hajok.Add(new Teher
            {
                GyartasEve=1980,
                Hossz=50,
                MaxSebesseg=18,
                Nev="T1",
                Suly=15000,
                SzallithatoTomeg=50000
            });

            hajok.Add(new Teher
            {
                GyartasEve = 1986,
                Hossz = 70,
                MaxSebesseg = 20,
                Nev = "T2",
                Suly = 18000,
                SzallithatoTomeg = 60000
            });

            foreach (var i in hajok)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
