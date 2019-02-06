using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imenik
{
    class Kontakt
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public Grupa grupa { get; set; }
        public Kontakt()
        {
            
        }

        public string ToString()
        {
            string s = Ime + " " + Prezime;
            return s;
        }
    }
}
