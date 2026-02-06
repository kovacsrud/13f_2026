namespace Listak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Listák");

            List<int> szamok = new List<int>();

            Console.WriteLine($"Elemek száma:{szamok.Count}");

            szamok.Add(178);
            szamok.Add(653);
            szamok.Add(112);

            Console.WriteLine($"Elemek száma:{szamok.Count}");

            //A lista elemei ugyanúgy indexelhetőek, mint a tömb elemei
            Console.WriteLine(szamok[1]);

            for (int i = 0; i < szamok.Count; i++)
            {
                Console.WriteLine(szamok[i]);
            }

            Listazas(szamok);

            List<int> szamok2 = new List<int>();
            szamok2.Add(1123);
            szamok2.Add(5621);

            szamok.AddRange(szamok2);

            Listazas(szamok);

            //Törlés a listából érték alapján
            szamok.Remove(112);

            Listazas(szamok);

            //Törlés a listából az elem indexe alapján is
            szamok.RemoveAt(0);

            Listazas(szamok);

            //Az összes elem törlése
            szamok.Clear();
        }

        private static void Listazas(List<int> szamok)
        {
            Console.WriteLine();
            foreach (var i in szamok)
            {
                Console.WriteLine(i);
            }
        }
    }
}
