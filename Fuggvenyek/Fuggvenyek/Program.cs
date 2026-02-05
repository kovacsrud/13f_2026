namespace Fuggvenyek
{
    internal class Program
    {
        public static void Kiir()
        {
            Console.WriteLine("Függvény");
        }

        //overloading "túlterhelés" => Több függvényt írhatunk ugyanazzal a névvel, viszont az egyes változatok eltérő paraméterlistával kell hogy rendelkezzenek
        public static void Kiir(string szoveg)
        {
            Console.WriteLine(szoveg);
        }

        //public static void Kiir(string szoveg1, string szoveg2) {
        //    Console.WriteLine(szoveg2+" "+szoveg1);
        //}

        public static void Kiir(string szoveg1,string szoveg2,bool forditott = false)
        {
            if (forditott)
            {
                Console.WriteLine(szoveg2 + " " + szoveg1);
            } else
            {
                Console.WriteLine(szoveg1 + " " + szoveg2);
            }
        }

        //Függvények visszatérési értékkel
        //A visszatérési értékkel rendelkező függvény lehet egy másik függvény paramétere ill. állhat értékadó utasítás jobb oldalán
        public static int Osszead(int a,int b)
        {
            return a + b;
        }

        public static double Osszead(double a,double b)
        {
            return a + b;
        }

        //Írjon egy osztás függvényt, amely két egész számot oszt el egymással és az eredményt visszaadja. Gondoskodjon a hibamentes működésről!
        public static int Osztas(int a, int b) {

            if (b==0)
            {
                return -1;
            }

            return a / b;

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Függvények");
            Kiir();
            Kiir("paraméter");
            Kiir("Kósa", "Angéla");
            Kiir("Kiss","Elek",true);
            int osszeg=Osszead(10, 12);
            Console.WriteLine(osszeg);
            Console.WriteLine(Osszead(100,269));
            Console.WriteLine(Osszead(211.56,673.68991));
            Console.WriteLine(Osztas(10,0));

        }
    }
}
