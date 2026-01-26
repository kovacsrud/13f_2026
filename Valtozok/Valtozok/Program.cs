namespace Valtozok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //Típusos nyelv, azaz minden változónak meg kell adni a típusát

            //Egész számok, abban különböznek, hogy mekkora értéket képesek tárolni,
            //ill. előjeles változók, vagy sem.

            //byte 8-bit, előjel nélkül

            byte bajt = 14;

            Console.WriteLine(Convert.ToString(bajt,2).PadLeft(8,'0'));
            Console.WriteLine($"Min:{Byte.MinValue},Max:{Byte.MaxValue}");

            //short 16 bites előjeles
            short bajtok = -567;

            Console.WriteLine(Convert.ToString(bajtok, 2).PadLeft(16, '0'));
            Console.WriteLine($"Min:{short.MinValue},Max:{short.MaxValue}");

            //ushort 16 bites előjel nélküli

            ushort ubajtok = 567;
                        
            Console.WriteLine(Convert.ToString(ubajtok, 2).PadLeft(16, '0'));
            Console.WriteLine($"Min:{ushort.MinValue},Max:{ushort.MaxValue}");

            //32 bites előjeles
            int simaEgeszElojeles = 123000;

            Console.WriteLine(Convert.ToString(simaEgeszElojeles, 2).PadLeft(32, '0'));
            Console.WriteLine($"Min:{int.MinValue},Max:{int.MaxValue}");

            //32 bites előjel nélküli
            uint simaEgeszElojelNelkul = 3450000;

            Console.WriteLine(Convert.ToString(simaEgeszElojelNelkul, 2).PadLeft(32, '0'));
            Console.WriteLine($"Min:{uint.MinValue},Max:{uint.MaxValue}");

            //64 bites

            long hosszuElojeles = 34534534345;
            Console.WriteLine(Convert.ToString(hosszuElojeles, 2).PadLeft(64, '0'));
            Console.WriteLine($"Min:{long.MinValue},Max:{long.MaxValue}");

            ulong hosszuElojelNelkuli = 68848848888778878;
           
            //Console.WriteLine(Convert.ToString(hosszuElojelNelkuli, 2).PadLeft(64, '0'));
            Console.WriteLine($"Min:{ulong.MinValue},Max:{ulong.MaxValue}");

            Int128 int128 = 6577878888586;

            //Console.WriteLine(Convert.ToString(int128, 2).PadLeft(128, '0'));
            Console.WriteLine($"Min:{Int128.MinValue},Max:{Int128.MaxValue}");

            //Nem egész (lebegőpontos)

            //Egyszeres pontosságú
            float nemEgeszFloat = 124.123456789012345678901234567890f;

            //Kétszeres pontosságú
            double nemEgeszDouble = 124.123456789012345678901234567890;

            //Decimális
            
            decimal nemEgeszDecimalis = 124.123456789012345678901234567890m;

            Console.WriteLine(nemEgeszFloat);
            Console.WriteLine(nemEgeszDouble);
            Console.WriteLine(nemEgeszDecimalis);

            //Logikai
            bool logikai = true;

            //Karakter, egyetlen karakter, betű, szám, írásjel, spec. karakter

            char karakter = 'C';

            //Szöveg típus
            string szoveg = "Valami, bármi, akármi";

        }
    }
}
