using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    public static class Betolto
    {
        public static List<Kutyanev> BetoltKutyanev(string fajl,char hatarolo,int start=1)
        {
            List<Kutyanev> kutyanevek=new List<Kutyanev>();

            var adatok = File.ReadAllLines(fajl,Encoding.Default);

            for (int i = start; i < adatok.Length; i++)
            {
                kutyanevek.Add(new Kutyanev(adatok[i],hatarolo));
            }

            return kutyanevek;
        }

        public static List<Kutyafajta> BetoltKutyafajta(string fajl, char hatarolo, int start = 1)
        {
            List<Kutyafajta> kutyafajtak=new List<Kutyafajta>();

            var adatok = File.ReadAllLines(fajl, Encoding.Default);

            for (int i = start; i < adatok.Length; i++)
            {
                kutyafajtak.Add(new Kutyafajta(adatok[i], hatarolo));
            }

            return kutyafajtak;
        }

        public static List<Kutya> BetoltKutya(string fajl, char hatarolo, int start = 1)
        {
            List<Kutya> kutyak=new List<Kutya>();

            var adatok = File.ReadAllLines(fajl, Encoding.Default);

            for (int i = start; i < adatok.Length; i++)
            {
                kutyak.Add(new Kutya(adatok[i], hatarolo));
            }


            return kutyak;
        }
    }
}
