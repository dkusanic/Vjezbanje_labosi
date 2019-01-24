using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodoviKolegij
{
    public class Aktivnosti
    {
        public string Naziv { get; set; }
        public int Bodovi { get; set; }
        public int MaxBodovi { get; set; }
        public Aktivnosti(string naziv, int maxBodovi)
        {
            Naziv = naziv;
            MaxBodovi = maxBodovi;
        }
    }
}
