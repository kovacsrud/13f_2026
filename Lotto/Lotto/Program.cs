namespace Lotto
{
    internal class Program
    {
        //private static char ujra;
        static void Main(string[] args)
        {
            Console.WriteLine("Lottó");

            //Lottó játék
            //Játék típus meghatározása
            //Tippek bekérése
            //"Sorsolás"
            //Találatok számának meghatározása

            Random rand = new Random();
            Console.Write("Hány számot húzunk?");
            int hanySzam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hány számból sorsolunk?");
            int osszSzam = Convert.ToInt32(Console.ReadLine());
            char valasz;


            //ide?

            do
            {
                
            

            int[] tippek = new int[hanySzam];
            int[] nyeroszamok = new int[hanySzam];


      


            int talalat = 0;


            //Tippek bekérése
            //1 és osszSzam között kell lennie
            //nem szerepelhet a tippek
            for (int i = 0; i < hanySzam; i++)
            {
                Console.Write($"{i + 1}.tipp:");
                int temp = Convert.ToInt32(Console.ReadLine());
                while (temp < 1 || temp > osszSzam || tippek.Contains(temp))
                {
                    Console.Write("Hibás tipp, újra!:");
                    temp = Convert.ToInt32(Console.ReadLine());

                }
                tippek[i] = temp;

            }

            Array.Sort(tippek);
            TombLista(tippek);

            //"Sorsolás"
            for (int i = 0; i < hanySzam; i++)
            {
                int temp = rand.Next(1, osszSzam + 1);
                while (nyeroszamok.Contains(temp))
                {
                    temp = rand.Next(1, osszSzam + 1);
                }
                nyeroszamok[i] = temp;
            }

            Array.Sort(nyeroszamok);
            TombLista(nyeroszamok);

            //for (int i = 0; i < tippek.Length; i++)
            //{
            //    for (int j = 0; j < nyeroszamok.Length; j++)
            //    {
            //        if (tippek[i] == nyeroszamok[j])
            //        {
            //            talalat++;
            //        }

            //    }

            //}

            //Egy for ciklussal?
            for (int i = 0; i < tippek.Length; i++)
            {
                if (nyeroszamok.Contains(tippek[i]))
                {
                    talalat++;
                }
            }


            Console.WriteLine($"Találatok száma:{talalat}");
            Console.Write("Akar még játszani?(i/n)");
            valasz = Console.ReadKey().KeyChar;



            }
            while (valasz=='i');




        }

        private static void TombLista(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
