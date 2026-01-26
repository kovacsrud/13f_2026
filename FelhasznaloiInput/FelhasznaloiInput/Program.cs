namespace FelhasznaloiInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Felhasználói input");

            //Egy sor beolvasása billentyűzetről
            Console.Write("Adjon meg egy szöveget:");
            string szoveg=Console.ReadLine();

            Console.WriteLine(szoveg);

            Console.Write("Adjon meg egy számot:");
            int szam1=Convert.ToInt32(Console.ReadLine());

            Console.Write("Adjon meg egy másik számot:");
            int szam2 = Convert.ToInt32(Console.ReadLine());

            int szam3 = szam1 * szam2;

            Console.WriteLine($"A szorzat:{szam3}");

            //Készítsen programot, amely bekér egy km/h-ban értelmezett sebesség értéket
            //A program számítsa át ezt az értéket m/s-ba, majd írja ki a kapott értéket
            //A váltószám 3.6

        }
    }
}
