using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodoviKolegij
{
    public class Predmeti
    {
        public string Naziv { get; set; }
        public int Bodovi
        {
            get
            {
                int Bdv = 0;
                foreach (Aktivnosti a in listaAktivnosti)
                {
                    Bdv += a.Bodovi;
                }
                return Bdv;
            }
        }
        public int MaxBodovi
        {
            get
            {
                int MaxBdv = 0;
                foreach (Aktivnosti a in listaAktivnosti)
                {
                    MaxBdv += a.MaxBodovi;
                }
                return MaxBdv;
            }
        }
        public string Uspjeh
        {

            get
            {
                if (MaxBodovi != 0)
                    return (((double)Bodovi / MaxBodovi)*100 + 0.0000001).ToString().Substring(0,5) + " %";
                else
                    return null;
            }
        }
        public List<Aktivnosti> listaAktivnosti = new List<Aktivnosti>();
        public Predmeti(string naziv)
        {
            Naziv = naziv;
        }
    }
}
