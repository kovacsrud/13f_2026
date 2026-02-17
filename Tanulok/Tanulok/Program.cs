namespace Tanulok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tanulók");

            List<Tanulo> tanulok=new List<Tanulo>();
            string[] vezeteknevek = {"Nagy","Kósa","Kiss","László", "Dobos","Kun","Kertész","Zsiga" };
            string[] keresztnevek = { "Viktória","Alexanra","Géza","János","Elek","Róbert","Dániel"};
            string[] osztalyok = { "9/a", "9/b","9/c","9/d","10/a","10/b","10/c","10/d" };
            Random rand=new Random();
            int listaHossz = 1000;

            for (int i = 0; i < listaHossz; i++)
            {
                string vezeteknev = vezeteknevek[rand.Next(0,vezeteknevek.Length)];
                string keresztnev = keresztnevek[rand.Next(0, keresztnevek.Length)];
                string osztaly = osztalyok[rand.Next(0, osztalyok.Length)];

                Tanulo tanulo = new Tanulo
                {
                    Vezeteknev = vezeteknev,
                    Keresztnev = keresztnev,
                    Osztaly = osztaly,
                    SzuletesiEv = rand.Next(1999, 2006)
                };

                tanulok.Add(tanulo);
            }

            //Hány darab Dobos vezetéknevű tanuló van a listában?
            var dobosDb = tanulok.FindAll(x=>x.Vezeteknev.ToLower()=="Dobos".ToLower()).Count;

            Console.WriteLine($"Dobos vezetéknevűek száma:{dobosDb}");

            //Hány tanuló van 9/a osztályban
            var letszam9a = tanulok.FindAll(x => x.Osztaly == "9/a").Count;
            Console.WriteLine($"9a létszáma:{letszam9a}");

            //Van-e a listában Kertész Elek nevű tanuló?
            //Megoldás 1.
            var vanElek1 = tanulok.Find(x => x.Vezeteknev == "Kertész" && x.Keresztnev == "Elek");

            
            if (vanElek1!=null)
            {
                Console.WriteLine("Van ilyen név a listában");
            } else
            {
                Console.WriteLine("Nincs ilyen név a listában");
            }
            //Megoldás 2. Any használata
            if (tanulok.Any(x=>x.Vezeteknev=="Kertész" && x.Keresztnev=="Elek"))
            {
                Console.WriteLine("Van ilyen név a listában");
            } else
            {
                Console.WriteLine("Nincs ilyen név a listában");
            }

            //Megoldás 3. FindAll nincs null probléma
            var vanElek2= tanulok.FindAll(x => x.Vezeteknev == "Kertéssz" && x.Keresztnev == "Elek");

            if (vanElek2.Count == 0)
            {
                Console.WriteLine("Nincs ilyen név a listában");
            } else
            {
                Console.WriteLine("Van ilyen név a listában");
            }

            //Mennyi a 9/b osztály tanulóinak átlagéletkora?
            var altagEletkor9b = tanulok.FindAll(x => x.Osztaly == "9/b").Average(x=>x.Eletkor());
            Console.WriteLine($"9/b átlagéletkor:{altagEletkor9b}");

            //Kérjen be billentyűzetről egy nevet! Állapítsa meg, hogy van-e ilyen nevű tanuló és ha van akkor mennyien vannak.
            Console.Write("Adja meg a keresett nevet!");
            string nev = Console.ReadLine();
            var teljesNev = nev.Split(' ');

            var vanEIlyen = tanulok.FindAll(x => x.Vezeteknev.ToLower() == teljesNev[0].ToLower() && x.Keresztnev.ToLower() == teljesNev[1].ToLower()).Count;

            if (vanEIlyen>0)
            {
                Console.WriteLine($"{vanEIlyen} db ilyen tanuló van");
            } else
            {
                Console.WriteLine("Nincs ilyen tanuló a listában");
            }

            //Adja meg, hogy az egyes osztályoknak mennyi a létszáma!
            //Összesítés feladat

            var stat = tanulok.ToLookup(x=>x.Osztaly).OrderBy(x=>x.Key);

            foreach (var i in stat)
            {
                Console.WriteLine($"{i.Key} - {i.Count()} fő - {i.Average(x=>x.Eletkor())} - {i.Min(x=>x.Eletkor())} - {i.Max(x=>x.Eletkor())}");
            }

            var stat2 = tanulok.ToLookup(x=>new {x.Osztaly,x.Vezeteknev }).OrderBy(x=>x.Key.Vezeteknev).ThenByDescending(x=>x.Key.Osztaly);

            foreach (var i in stat2) {
                Console.WriteLine($"{i.Key.Vezeteknev} - {i.Key.Osztaly} - {i.Count()}");
            }

            //Adja meg, hogy az egyes vezetéknevek hányszor szerepelnek a listában!


            //Adja meg, hogy az egyes keresztnevek hányszor szerepelnek az egyes osztályokban

        }
    }
}
