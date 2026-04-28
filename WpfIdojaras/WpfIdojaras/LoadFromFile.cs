using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfIdojaras
{
    public static class LoadFromFile
    {
        public static List<Idojaras> LoadIdojaras(string fajl,char hatarolo,int start=1)
        {
            List<Idojaras> idojaraslista=new List<Idojaras>();
            var sorok=File.ReadAllLines(fajl);

            for (int i = start; i < sorok.Length; i++)
            {
                idojaraslista.Add(new Idojaras(sorok[i],hatarolo));
            }


            return idojaraslista;
        }
    }
}
