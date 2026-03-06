using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoOOP
{
    public class LottoJatek
    {
        private int hanySzam;
        private int osszSzam;
        private List<int> tippek=new List<int>();
        private List<int> nyeroszamok=new List<int>();
        private List<int> sorsoloGomb=new List<int>();
        private int talalat;
        Random rand= new Random();

        public LottoJatek(int hanyszam,int osszszam)
        {
            hanySzam = hanyszam;
            osszSzam = osszszam;
            Gombfeltoltes();
            Jatek();
        }

        private void Jatek()
        {
            char valasz;
            do
            {
                Tippeles();
                Sorsolas();
                Console.WriteLine($"Találatok száma:{Talalatok()}");
                Console.Write("Akar még játszani?(i/n)");
                valasz = Console.ReadKey().KeyChar;
                sorsoloGomb.AddRange(nyeroszamok);
                nyeroszamok.Clear();
                tippek.Clear();
            }
            while (valasz=='i');

            
        }

        private void Gombfeltoltes()
        {
            for (int i = 0; i < osszSzam; i++)
            {
                sorsoloGomb.Add(i + 1);
            }
        }

        private void Tippeles()
        {
            for (int i = 0; i < hanySzam; i++)
            {
                Console.Write($"{i+1}.tipp:");
                int temp=Convert.ToInt32(Console.ReadLine());
                while (temp < 1 || temp>osszSzam || tippek.Contains(temp)) {
                    Console.Write($"Hibás tipp,újra! {i+1}:");
                    temp = Convert.ToInt32(Console.ReadLine());
                }
                tippek.Add(temp);
            }
            tippek.Sort();
            Lista(tippek);
        }

        private void Sorsolas()
        {
            for(int i = 0;i < hanySzam;i++)
            {
                int kivalasztott = sorsoloGomb[rand.Next(0,sorsoloGomb.Count)];
                nyeroszamok.Add(kivalasztott);
                sorsoloGomb.Remove(kivalasztott);
            }
            nyeroszamok.Sort();
            Lista(nyeroszamok);
            
        }

        private int Talalatok()
        {
            for (int i = 0; i < tippek.Count; i++)
            {
                if (nyeroszamok.Contains(tippek[i]))
                {
                    talalat++;
                }
            }

            return talalat;
        }

        private void Lista(List<int> lista)
        {
            foreach (int i in lista)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
