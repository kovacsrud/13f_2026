
namespace Extract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Függvények generálása kódból");

            //F12-vel a függvény definíciójához lehet ugrani

            int osszeg = Osszead(102, 456, 321);

            int[] szamok = { 124, 679, 54, 16, 998, 345, 783, 1233 };

            TombLista(szamok);

            szamok[2] = 611;

            TombLista(szamok);

        }

        private static void TombLista(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + " ");
            }
        }

        private static int Osszead(int v1, int v2, int v3)
        {
            return v1 + v2 + v3;
        }
    }
}
