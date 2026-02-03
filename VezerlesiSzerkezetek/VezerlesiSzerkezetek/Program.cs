namespace VezerlesiSzerkezetek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elágazások");

            int szam = 12;

            //egyszeres, egyágú szelekció
            if (szam>=0)
            {
                //lokális változó
                int szam2 = szam + 100;
                Console.WriteLine("A szám pozitív!");
                Console.WriteLine(szam2);
            }
                        

            //egyszeres, kétágú
            if (szam >= 0)
            {
                Console.WriteLine("A szám pozitív!");
            } else
            {
                Console.WriteLine("A szám negatív!");
            }

            //switch
            int valaszt = 2;
            switch (valaszt)
            {
                case 1:
                    Console.WriteLine("1-es kiválasztva");
                    break;
                case 2:
                    Console.WriteLine("2-es kiválasztva");
                    break;
                case 3:
                    Console.WriteLine("3-as kiválasztva");
                    break;
                default:
                    Console.WriteLine("Nincs semmi kiválasztva!");
                    break;
            }

            //többszörös elágazás
            int bmi = 32;
            if (bmi < 16)
            {
                Console.WriteLine("Kóros soványság");
            }
            else if (bmi >= 16 && bmi < 17)
            {
                Console.WriteLine("Mérsékelt soványság");
            } else if (bmi >= 17 && bmi < 18.5) {

                Console.WriteLine("Enyhe soványság");
            } else if (bmi>=18.5 && bmi < 25)
            {
                Console.WriteLine("Normál testsúly");
            } else if (bmi>=25 && bmi<30)
            {
                Console.WriteLine("Túlsúly");
            } else if (bmi>=30 && bmi<35)
            {
                Console.WriteLine("Elhízás");
            } else if (bmi>=35 && bmi<40)
            {
                Console.WriteLine("Túlzott elhízás");
            } else
            {
                Console.WriteLine("Extrém elhízás");
            }

            //switch máshogy
            int pontszam = 83;

            string erdemjegy = pontszam switch
            {
                >= 90 =>"5 - Jeles",
                >= 75 =>"4 - Jó",
                >= 60 =>"3 - közepes",
                >= 45 =>"2 - elégséges",
                _ =>"1 - elégtelen"
            };

            Console.WriteLine(erdemjegy);

        }
    }
}
