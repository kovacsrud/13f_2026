using System.Text;

namespace Fajlkezeles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fájlok beolvasása, feldolgozása");

            List<Pilota2> pilotak=new List<Pilota2>();

            //beolvasás while ciklussal,streamreader használatával
            //try
            //{
            //    FileStream fajl = new FileStream("pilotak.csv", FileMode.Open);
            //    StreamReader sr = new StreamReader(fajl,Encoding.Default);
            //    //Első sor átlépése
            //    //sr.ReadLine();
            //    while (!sr.EndOfStream) {
            //        //Feldolgozás
            //        //Console.WriteLine(sr.ReadLine());
            //    }

            //    sr.Close();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);                
            //}

            try
            {
                //Egy string tömbbe olvassuk be a fájl sorait.
                var sorok = File.ReadAllLines("pilotak.csv",Encoding.Default);
                

                for (int i = 1; i < sorok.Length; i++)
                {
                    pilotak.Add(new Pilota2(sorok[i],';'));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }


            Console.WriteLine($"Elemszám:{pilotak.Count}");

        }
    }
}
