using System.Text;

namespace NobelDijasok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nobel díjasok");

            List<Nobel> nobeldijasok=new List<Nobel>();

            try
            {
                var sorok = File.ReadAllLines("nobeldijasok.csv",Encoding.UTF8);

                for (int i = 1; i < sorok.Length; i++)
                {
                    nobeldijasok.Add(new Nobel(sorok[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Sorok száma:{nobeldijasok.Count}");

            //3.feladat
            var mcdonald = nobeldijasok.Find(x => x.Vezeteknev == "McDonald" && x.Keresztnev == "Arthur B.");

            if (mcdonald!=null)
            {
                Console.WriteLine($"3.feladat: {mcdonald.Tipus}");
            }

            //4.feladat
            var irodalmi2017 = nobeldijasok.Find(x=>x.Tipus=="irodalmi" && x.Ev==2017);

            if (irodalmi2017!=null)
            {
                Console.WriteLine($"4.feladat:{irodalmi2017.Vezeteknev} {irodalmi2017.Keresztnev}");
            }

            //5.feladat
            var szervezetek = nobeldijasok.FindAll(x=>x.Vezeteknev=="" && x.Ev>=1990);

            foreach (var i in szervezetek)
            {
                Console.WriteLine($"{i.Keresztnev}");
            }

            //6. feladat
            var curieCsalad = nobeldijasok.FindAll(x=>x.Vezeteknev.Contains("Curie") || x.Keresztnev.Contains("Curie"));

            foreach (var i in curieCsalad)
            {
                Console.WriteLine($"{i.Vezeteknev} {i.Keresztnev},{i.Ev},{i.Tipus}");
            }

            //7.feladat
            var stat = nobeldijasok.ToLookup(x=>x.Tipus);

            foreach (var i in stat)
            {
                Console.WriteLine($"{i.Key} - {i.Count()} db");
            }

            //8.feladat
            var orvosiNobel = nobeldijasok.FindAll(x=>x.Tipus=="orvosi").OrderBy(x=>x.Ev);

            try
            {
                FileStream fajl = new FileStream("orvosi.txt", FileMode.Create);

                using (StreamWriter writer=new StreamWriter(fajl,Encoding.UTF8))
                {
                    writer.WriteLine($"ev:nev");
                    foreach (var i in orvosiNobel)
                    {
                        writer.WriteLine($"{i.Ev}:{i.Vezeteknev} {i.Keresztnev}");
                    }
                }
                Console.WriteLine("Fájl kiírása kész!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
        }
    }
}
