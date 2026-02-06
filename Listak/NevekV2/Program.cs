namespace NevekV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nevek V2");

            Random rand = new Random();
            string[] vezetekNevek = { "Kiss", "Kovács", "Kósa", "Szabó", "Mezei", "Kertész" };
            string[] keresztNevek = { "Egon", "Géza", "Ella", "Janka", "János", "Éva" };
            int elemszam = 1000;

            List<Nev> nevek = new List<Nev>();

            for (int i = 0; i < elemszam; i++)
            {
                string vezeteknev = vezetekNevek[rand.Next(0, vezetekNevek.Length)];
                string keresztnev = keresztNevek[rand.Next(0, keresztNevek.Length)];

                nevek.Add(new Nev {
                    VezetekNev=vezeteknev,
                    KeresztNev=keresztnev
                });

              


            }


            //Keressük meg Kiss Egont!
            var egon = nevek.Find(x => x.VezetekNev == "Kiss" && x.KeresztNev == "Egon");

            if (egon != null) {
                Console.WriteLine($"{egon.VezetekNev} {egon.KeresztNev}");
            } else
            {
                Console.WriteLine("A név nem található");
            }

            //Kertészek kiszűrése

            var kerteszek = nevek.FindAll(x => x.VezetekNev == "Kertész");

            Console.WriteLine($"Elemszám:{kerteszek.Count}");

            //statisztika

            var stat = nevek.ToLookup(x=>x.KeresztNev).OrderBy(x=>x.Key);

            foreach (var i in stat)
            {
                Console.WriteLine($"{i.Key} - {i.Count()}");
            }

            //Összetett kulcs

            var stat2 = nevek.ToLookup(x=>new {x.VezetekNev,x.KeresztNev}).OrderBy(x=>x.Key.VezetekNev).ThenBy(x=>x.Key.VezetekNev);

            foreach (var i in stat2)
            {
                Console.WriteLine($"{i.Key.VezetekNev} {i.Key.KeresztNev} - {i.Count()}");
            }

            


        }
    }
}
