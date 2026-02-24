using System.Text;

namespace EU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Csatlakozas> csatlakozasok=new List<Csatlakozas>();

            try
            {
                var sorok=File.ReadAllLines("EUcsatlakozas.txt",Encoding.UTF7);

                for(int i = 0; i < sorok.Length; i++)
                {
                    csatlakozasok.Add(new Csatlakozas(sorok[i],';'));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Feladat 3. {csatlakozasok.Count} db");

            Console.WriteLine($"Feladat 4. {csatlakozasok.FindAll(x=>x.CsatlakozasDatum.Year==2007).Count} csatlakozás.");

            var mo = csatlakozasok.Find(x=>x.Orszag=="Magyarország");

            if (mo!=null)
            {
                Console.WriteLine($"Feladat 5. Mo csatlakozásának dátuma:{mo.CsatlakozasDatum.Year}.{mo.CsatlakozasDatum.Month}.{mo.CsatlakozasDatum.Day}");
            }

            if (csatlakozasok.Any(x=>x.CsatlakozasDatum.Month==5))
            {
                Console.WriteLine("Májusban volt csatlakozás!");
            } else
            {
                Console.WriteLine("Májusban nem volt csatlakozás!");
            }


            //Sok adatnál teljesítmény problémát okozhat!!
            var legutoljara = csatlakozasok.Find(x => x.CsatlakozasDatum == csatlakozasok.Max(x=>x.CsatlakozasDatum));

            Console.WriteLine($"7.feladat:{legutoljara.Orszag}");

            var stat = csatlakozasok.ToLookup(x=>x.CsatlakozasDatum.Year);

            foreach (var i in stat)
            {
                Console.WriteLine($"{i.Key} - {i.Count()} ország");
            }

            //Írassa ki egy ketezres.txt nevű fájlba azokat az országokat és csatlakozási dátumaikat, amelyek 1999 után csatlakoztak az EU-hoz! Az adatokat ; válassza el egymástól!
            //StreamWriter

            var ketezres = csatlakozasok.FindAll(x=>x.CsatlakozasDatum.Year>1999);

            try
            {
                FileStream fajl = new FileStream("ketezres.txt",FileMode.Create);
                StreamWriter writer=new StreamWriter(fajl,Encoding.UTF8);

                foreach (var i in ketezres) {
                    writer.WriteLine($"{i.Orszag};{i.CsatlakozasDatum}");
                }

                //Ha nem zárjuk le a streamwritert, akkor a kiírt fájl sérült lesz!!!
                writer.Close();
                Console.WriteLine("Fájlba írás kész!");
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }



        }
    }
}
