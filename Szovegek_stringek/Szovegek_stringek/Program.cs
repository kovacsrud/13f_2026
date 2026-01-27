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


        }
    }
}
