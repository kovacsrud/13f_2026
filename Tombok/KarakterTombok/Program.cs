namespace KarakterTombok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Karakter tömbök");


            string szoveg = "Valami, bármi, akármi";


            //A string nem módosítható ciklusban, karakterenként

            char[] chSzoveg=szoveg.ToCharArray();

            for (int i = 0; i < chSzoveg.Length; i++)
            {
                if (chSzoveg[i]=='b')
                {
                    chSzoveg[i] = 'x';
                }
            }

            szoveg=new string(chSzoveg);

            Console.WriteLine(szoveg);

            //Alakítsuk a kisbetűket nagyra és fordítva
            string szoveg2 = "vAlAmi, BÁrMi, aKÁrMi";
            char[] chSzoveg2=szoveg2.ToCharArray();

            for (int i = 0; i < chSzoveg2.Length; i++)
            {
                if (Char.IsLower(chSzoveg2[i]))
                {
                    chSzoveg2[i] = Char.ToUpper(chSzoveg2[i]);
                } else
                {
                    chSzoveg2[i]=Char.ToLower(chSzoveg2[i]);
                }
            }

            Console.WriteLine(chSzoveg2);

            string szamEsSzoveg = "Valami 129, bármi 874";
            //Mennyi a szövegben lévő számok összege?

            char[] chSzamEsSzoveg=szamEsSzoveg.ToCharArray();
            int osszeg = 0;

            for (int i = 0; i < chSzamEsSzoveg.Length; i++)
            {
                if (Char.IsNumber(chSzamEsSzoveg[i]))
                {
                    osszeg += (int)Char.GetNumericValue(chSzamEsSzoveg[i]);
                }
            }

            Console.WriteLine($"Összeg:{osszeg}");

        }
    }
}
