namespace KetdimenziosTomb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Két dimenziós tömb");

            //Sorokból és oszlopokból áll
            int[,] szamok = new int[15,20]; 

            Random rand= new Random();

            for (int i = 0; i < szamok.GetLength(0); i++)
            {
                for (int j = 0; j < szamok.GetLength(1); j++)
                {
                    szamok[i, j] = rand.Next(10,100);
                }
            }

            for (int i = 0; i < szamok.GetLength(0); i++)
            {
                for (int j = 0; j < szamok.GetLength(1); j++)
                {
                    Console.Write(szamok[i,j]+" ");
                }
                Console.WriteLine();
            }

            //Összeg két dimenziós tömbben
            int osszeg = 0;
            for (int i = 0; i < szamok.GetLength(0); i++)
            {
                for (int j = 0; j < szamok.GetLength(1); j++)
                {
                    osszeg += szamok[i, j];
                }
            }
        }
    }
}
