namespace Szovegek_stringek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String típus tulajdonságai, műveletei");

            string szoveg = "Szöveges típus";

            //A string típusú változó valójában egy tömb, az egyes karakterekre hivatkozhatunk az 
            //indexük megadásával

            Console.WriteLine(szoveg[2]);

            Console.WriteLine($"A szöveg hossza:{szoveg.Length}");

            //String műveletek
            //Tartalmazás vizsgálata
            Console.WriteLine(szoveg.Contains("eg"));

            //Kezdődik-e valamilyen szöveggel?
            Console.WriteLine(szoveg.StartsWith("típ"));

            //Végződik-e valamilyen szöveggel
            Console.WriteLine(szoveg.EndsWith("pus"));

            //Írásmód változtatása
            Console.WriteLine(szoveg.ToUpper());

            Console.WriteLine(szoveg.ToLower());

            //stringek összehasonlítása
            string sz1 = "Valami";
            string sz2 = "valami";

            if (sz1.ToLower()==sz2.ToLower())
            {
                Console.WriteLine("Megegyeznek a szövegek");
            } else
            {
                Console.WriteLine("Nem egyeznek meg a szövegek");
            }

            if (sz1.ToLower().Equals(sz2.ToLower())) {
                Console.WriteLine("Megegyeznek a szövegek");
            }

            //Karakterek cseréje
            Console.WriteLine(szoveg.Replace('e','x'));

            //szöveg cseréje
            Console.WriteLine(szoveg.Replace("típus","változó"));

            //Szöveg első/utolsó karaktere
            //Indexeléssel
            Console.WriteLine(szoveg[0]);
            Console.WriteLine(szoveg[szoveg.Length-1]);

            //Függvénnyel
            Console.WriteLine(szoveg.First());
            Console.WriteLine(szoveg.Last());

            //Rész szöveg kiemelése

            var datum = "2009.12.26";

            //var -> a bal oldali változó a jobb oldali értéknek megfelelő típust fogja felvenni
            var ev = datum.Substring(0,4);
            var honap=datum.Substring(5,2);
            var nap = datum.Substring(8,2);

            Console.WriteLine($"Ev:{ev},hónap:{honap},nap:{nap}");

            //string darabolása egy karakter mentén
            var datumElemek = datum.Split('.');
            Console.WriteLine($"Év:{datumElemek[0]},hónap:{datumElemek[1]},nap:{datumElemek[2]}");



        }
    }
}
