namespace Parameteratadas
{
    internal class Program
    {
        //Érték szerinti paraméterátadás
        public static int Negyzet(int a)
        {
            a = a * a;
            return a;
        }

        //Cím szerinti paraméterátadás
        public static int Negyzet(ref int a)
        {
            a = a * a;
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Érték és cím szerinti paraméterátadás");
            int x = 3;
            Console.WriteLine(Negyzet(x));
            Console.WriteLine($"X értéke:{x}");

            Console.WriteLine(Negyzet(ref x));
            Console.WriteLine($"X értéke:{x}");
        }
    }
}
