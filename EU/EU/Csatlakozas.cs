using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EU
{
    public class Csatlakozas
    {
        public string Orszag { get; set; }
        public DateTime CsatlakozasDatum { get; set; }

        public Csatlakozas(string sor,char hatarolo)
        {
            var adatok = sor.Split(hatarolo);
            Orszag = adatok[0];
            CsatlakozasDatum=Convert.ToDateTime(adatok[1]);
        }
    }
}
