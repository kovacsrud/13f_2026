namespace Kivetelek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kivételek kezelése");


            try
            {
                Console.Write("Adjon meg egy számot:");
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.Write("Adjon meg egy másik számot:");
                int szam2 = Convert.ToInt32(Console.ReadLine());
                int szam3 = szam / szam2;
                Console.WriteLine(szam3);
                try
                {
                    throw new ArgumentException();
                }
                catch (ArithmeticException ex)
                {
                    Console.WriteLine("Arithmetic exception");                    
                }

            }
            catch (FormatException ex) {
                Console.WriteLine("Számot kell megadni!");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("A megadott érték túl nagy!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);     
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("A finally blokk kódja mindig lefut");
            }


            


        }
    }
}
