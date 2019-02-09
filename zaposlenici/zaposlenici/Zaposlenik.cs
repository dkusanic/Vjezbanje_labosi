using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaposlenici
{
    class Zaposlenik
    {
        public int Id { get; set; }
        public string ImePrezime { get; set; }
        public List<double> MjesecnePlace { get; set; }
        public Zaposlenik (int id, string imeprezime)
        {
            Id = id;
            ImePrezime = imeprezime;
            MjesecnePlace = new List<double>();
        }
        public void DodajPlacu(double Placa)
        {
            MjesecnePlace.Add(Placa);
        }
        public double IzracunUkupnePlace()
        {
            double Ukupno = 0;
            foreach (double placa in MjesecnePlace)
                Ukupno += placa;
            return Math.Round(Ukupno, 2);
        }
        public double IzracunProsjecneZarade()
        {
            double Prosjek = 0;
            int brojac = 0;
            for (int i=0; i < MjesecnePlace.Count(); i++)
            {
                if (MjesecnePlace[i] != 0)
                {
                    brojac++;
                    Prosjek += MjesecnePlace[i];
                }
            }
            if (MjesecnePlace.Count == 0)
                return 0;
            else
                return Math.Round(Prosjek/brojac, 2);
        }
    }
}
