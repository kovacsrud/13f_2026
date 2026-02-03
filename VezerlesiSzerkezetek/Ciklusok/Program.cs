namespace Ciklusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ciklusok");

            //elöltesztelő, hátultesztelő, előírt lépésszámú (növekményes)

            //előírt lépésszámú
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            //elöltesztelő ciklus
            int szamlalo=1;

            while (szamlalo<=10)
            {
                Console.Write(szamlalo + " ");
                szamlalo++;
            }

            Console.WriteLine();
            szamlalo = 1;
            //hátulteszelő ciklus a ciklusmag egyszer mindenféleképpen le fog futni
            do
            {
                Console.Write(szamlalo + " ");
                szamlalo++;
            }
            while (szamlalo>10);

            Console.WriteLine();
        }
    }
}
