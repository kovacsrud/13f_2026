namespace ListaSzamokkal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista számokkal");
            string[] markak = {"Skoda","Dacia","Renault","BMW","Tesla","Fiat","Kia" };
            Random rand=new Random();
            int elemszam = 1000;
            List<Auto> autok=new List<Auto>();

            for (int i = 0; i < elemszam; i++)
            {
                string marka = markak[rand.Next(0, markak.Length)];
                int gyartasiEv=rand.Next(1990, 2026+1);
                autok.Add(new Auto {
                    Marka = marka,
                    GyartasiEv = gyartasiEv,
                });
            }

            //foreach (var i in autok)
            //{
            //    Console.WriteLine($"{i.Marka}-{i.GyartasiEv}-{i.Eletkor()}");
            //}

            var atlagEletkor = autok.Average(x=>x.Eletkor());
            Console.WriteLine($"Az autók átlagéletkora:{atlagEletkor}");

            //Skodák átlagéletkora
            var skodak = autok.FindAll(x=>x.Marka=="Skoda");
            var skodaAtlagEletkor = skodak.Average(x=>x.Eletkor());
            Console.WriteLine($"Skodák átlagéletkora:{skodaAtlagEletkor}");

            //Skodák átlagéletkora
            var skodak2 = autok.FindAll(x => x.Marka == "Skoda").Average(x => x.Eletkor());
            Console.WriteLine($"Skodák átlagéletkora:{skodak2}");

            //Legidősebb Skoda

            var legidosebbSkoda=autok.FindAll(x=>x.Marka=="Skoda").Max(x=>x.Eletkor());
            Console.WriteLine($"A legidősebb skoda:{legidosebbSkoda} éves");

            //Statisztika
            var stat = autok.ToLookup(x => x.Marka).OrderBy(x=>x.Key);

            foreach (var i in stat)
            {
                Console.WriteLine($"{i.Key} - {i.Average(x=>x.Eletkor())}");
            }

            //Legfiatalabb BMW
            //Daciák átlagéletkora
            //Legöregebb Tesla
            //2003 év 2008 között gyártott autók listája
            //2010 után gyártott Kiák darabszáma

            //Statisztika - az egyes években gyártott autók darabszáma
        }
    }
}
