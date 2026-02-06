using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSzamokkal
{
    public class Auto
    {
        public string Marka { get; set; }
        public int GyartasiEv { get; set; }

        public int Eletkor()
        {
            int ev = DateTime.Now.Year;

            return ev - GyartasiEv;
        }
    }
}
