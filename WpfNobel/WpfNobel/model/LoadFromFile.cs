using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfNobel.model
{
    public static class LoadFromFile
    {
        public static List<NobelDij> LoadCsv(string fajl,char hatarolo,int start = 1)
        {
            List<NobelDij> nobeldijasok=new List<NobelDij>();

            var sorok=File.ReadAllLines(fajl,Encoding.UTF8);

            for (int i = start; i < sorok.Length; i++)
            {
                nobeldijasok.Add(new NobelDij(sorok[i], hatarolo));
            }

            return nobeldijasok;
        }
    }
}
