using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfHegyek
{
    //Comment
    public static class Betoltes
    {
        public static List<Hegy> LoadFromCsv(string fajl,char hatarolo,int start=1)
        {
            List<Hegy> hegyek=new List<Hegy>();

            var sorok=File.ReadAllLines(fajl,Encoding.UTF8);

            for (int i = start; i < sorok.Length; i++)
            {
                hegyek.Add(new Hegy(sorok[i], hatarolo));
            }

            return hegyek;
        }
    }
}
