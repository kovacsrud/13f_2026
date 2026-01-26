namespace AritmetikaiMuveletek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aritmetikai műveletek");

            int a = 127;
            int b = 31;

            //Növelés/csökkentés

            a++;

            ++a;

            Console.WriteLine(a);

            //csökkentés
            a--;
            --a;

            Console.WriteLine(a);

            //Trükkös!
            int c = a++;
            //int c = ++a;

            Console.WriteLine(c);

            //Aritmetikai műveletek : +,-,*,/,%
            c = c + a;
            c += a;
            c -= a;
            c *= a;
            c /= a;

            //Egész osztás
            int d = a / b;

            Console.WriteLine($"D:{d}");

            //Maradékos osztás
            d = a % 3;

            Console.WriteLine($"D:{d}");

            //Osztás a maradékkal, típus kényszerítéssel
            double maradekos = (double)a / b;

            Console.WriteLine($"Maradékos:{maradekos}");

        }
    }
}
