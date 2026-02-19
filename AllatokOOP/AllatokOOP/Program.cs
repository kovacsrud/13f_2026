using System.ComponentModel.DataAnnotations;

namespace AllatokOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Állatok OOP");

            Allat allat = new Allat("A", "madár", 2,23);
            allat.Eszik();
            allat.Iszik();
            allat.Mozog();
            

            Madar vereb = new Madar("B", "veréb", 1,12,34);
            vereb.Iszik();
            vereb.Eszik();
            Console.WriteLine($"Faj:{vereb.Faj}");
            vereb.Hang();
            Console.WriteLine(vereb.ToString());

            Hullo kigyo = new Hullo("C", "vipera", 3, 12, true);
            kigyo.Mozog();
            Console.WriteLine(kigyo.ToString());

            Console.WriteLine(allat.ToString());

            //polimorfizmus: Ugyanaz a metódushívás pl. ToString() osztályonként eltérő kimenetet ad.
        }
    }
}
