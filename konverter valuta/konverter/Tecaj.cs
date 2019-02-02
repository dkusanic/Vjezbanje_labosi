using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konverter
{
    class Tecaj
    {
        public string Valuta { get; set; }
        public double Iznos { get; set; }

        public Tecaj (string v, double i)
        {
            Valuta = v;
            Iznos = i;
        }
    }
}
