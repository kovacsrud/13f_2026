namespace Tombok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tömbök használata");

            //Tömb (array): Több, azonos típusú változót tároló adatszerkezet, melynek kötött az elemszáma

            //5 elemű tömb deklarálása
            int[] szamok = new int[5];

            //Hivatkozás a tömb egy elemére
            Console.WriteLine(szamok[2]);

            //Hibás, túlindexelés!
            //Console.WriteLine(szamok[6]);
            szamok[1] = 129;

            int[] szamok2 = { 102,52,778,196,44,751 };

            int[] szamok3 = szamok2;

            szamok3[2] = 369;

            Console.WriteLine(szamok2[2]);

            for (int i = 0; i < szamok2.Length; i++)
            {
                Console.Write(szamok2[i]+" ");
            }
            Console.WriteLine();

            int[] sokSzam = new int[1000];

            //Töltsük fel a tömböt véletlen számokkal!
            Random rand = new Random();

            //Véletlenszám generálása:
            rand.Next(10, 100 + 1);

            for (int i = 0; i < sokSzam.Length; i++)
            {
                sokSzam[i]=rand.Next(10,100+1);
            }

            for (int i = 0; i < sokSzam.Length; i++)
            {
               // Console.Write(sokSzam[i]+" ");
            }
            Console.WriteLine();

            //Mennyi a sokSzam tömbben lévő elemek értékének az összege?

            //Összeg gyűjtése
            int osszeg = 0;
            for (int i = 0; i < sokSzam.Length; i++)
            {
                osszeg += sokSzam[i];
            }

            Console.WriteLine($"A tömb elemeinek összege:{osszeg}");

            //Min, max meghatározása
            int min = sokSzam[0];
            int max = sokSzam[0];

            for (int i = 0; i < sokSzam.Length; i++)
            {
                if (sokSzam[i]<min)
                {
                    min = sokSzam[i];
                }
                if (sokSzam[i]>max)
                {
                    max = sokSzam[i];
                }
            }

            Console.WriteLine($"Min:{min},max:{max}");

            //Ugyanez a nyelv lehetőségeit kihasználva
            Console.WriteLine($"Min:{sokSzam.Min()},max:{sokSzam.Max()},összeg:{sokSzam.Sum()},átlag:{sokSzam.Average()}");

            //Kérjen be billentyűzetről egy számot, és mondja meg, hogy a szám benne van-e a sokSzam tömbben, és ha igen, akkor ez hanyadik elem.

            //Lineáris keresés a tömbben
            Console.Write("Adj meg egy számot:");
            int beSzam=Convert.ToInt32( Console.ReadLine() );
            bool bennevan = false;
            
            for (int i = 0; i < sokSzam.Length; i++)
            {
                if (beSzam == sokSzam[i])
                {
                    bennevan=true;
                    Console.WriteLine($"{beSzam} megvan a tömbben, indexe:{i}");
                    break;
                }
            }

            if (!bennevan)
            {
                Console.WriteLine($"A keresett szám:{beSzam} nem található a tömbben!");
            }

            //Ugyanez a nyelv eszközeivel
            if (sokSzam.Any(x=>x==beSzam))
            {
                Console.WriteLine("Benne van");
            } else
            {
                Console.WriteLine("Nincs benne");
            }

            if (sokSzam.Contains(beSzam))
            {
                Console.WriteLine("Benne van");
            }
            else
            {
                Console.WriteLine("Nincs benne");
            }
        }
    }
}
