namespace Nevlista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nevek listája");
            Random rand = new Random();
            string[] vezetekNevek = { "Kiss", "Kovács", "Kósa", "Szabó", "Mezei", "Kertész" };
            string[] keresztNevek = { "Egon", "Géza", "Ella", "Janka", "János", "Éva" };
            int elemszam = 1000;

            List<string> nevek = new List<string>();

            for (int i = 0; i < elemszam; i++)
            {
                string vezeteknev = vezetekNevek[rand.Next(0, vezetekNevek.Length)];
                string keresztnev = keresztNevek[rand.Next(0, keresztNevek.Length)];
                nevek.Add($"{vezeteknev} {keresztnev}");
            }

            //NevLista(nevek);

            //Adott név kiszűrése egy másik listába

            var kissevak = nevek.FindAll(x=>x=="Kiss Éva");
            Console.WriteLine($"Elemek száma:{kissevak.Count}");

            NevLista(kissevak);

            //Keressük meg az összes Szabó vezetéknevű embert

            var szabok = nevek.FindAll(x=>x.StartsWith("Szabó"));
            Console.WriteLine($"Elemek száma:{szabok.Count}");

            var szabokv2 = nevek.FindAll(x => x.Contains("Szabó"));
            Console.WriteLine($"Elemek száma:{szabokv2.Count}");

            //Ne számítson a kis és nagy betű
            var ellak = nevek.FindAll(x => x.ToLower().EndsWith("Ella".ToLower()));

            Console.WriteLine($"Elemek száma:{ellak.Count}");

            //Ellák, akiknek a vezetéknevük M-el kezdődik
            var m_ellak = nevek.FindAll(x=>x.StartsWith("M") && x.EndsWith("Ella"));

            Console.WriteLine($"Elemek száma:{m_ellak.Count}");

            //Egyetlen elem visszakeresése
            //Az első, akinek a keresztneve Egon

            var egon = nevek.Find(x => x.EndsWith("Egonn"));

            //Find esetén az eredmény lehet null ezért mindig vizsgálni kell

            if (egon!=null)
            {
                Console.WriteLine(egon);
            }

            //Statisztika
            //Határozzuk meg, hogy az egyes nevekből hány darab van a listában!

            var stat = nevek.ToLookup(x=>x).OrderByDescending(x=>x.Key);

            foreach(var v in stat)
            {
                Console.WriteLine($"{v.Key} {v.Count()}");
            }

            

        }

        private static void NevLista(List<string> nevek)
        {
            Console.WriteLine();
            foreach (var i in nevek)
            {
                Console.WriteLine(i);
            }
        }
    }
}
