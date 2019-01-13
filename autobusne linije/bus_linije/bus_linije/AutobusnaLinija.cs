using System.Collections.Generic;

namespace bus_linije
{
    public class AutobusnaLinija
    {
        public string Polaziste { get; set; }
        public string Odrediste { get; set; }
        public int Udaljenost { get; set; }
        public double CijenaKarte { get; set; }
        public double CijenaStudenti { get; set; }
        public double CijenaPovratna { get; set; }

        AutobusnaLinija(string polaziste, string odrediste, int udaljenost)
        {
            Polaziste = polaziste;
            Odrediste = odrediste;
            Udaljenost = udaljenost;
            CijenaKarte = IzracunajCijenuKarte();
            CijenaStudenti = IzracunajcijenuStudenti();
            CijenaPovratna = IzracunajCijenaPovratna();
        }
        public double IzracunajCijenuKarte()
        {
            return Udaljenost * 1.5;
        }
        public double IzracunajcijenuStudenti()
        {
            return Udaljenost * 0.8;
        }
        public double IzracunajCijenaPovratna()
        {
            return Udaljenost * 2 * 0.8;
        }
        public static List<AutobusnaLinija> UcitajAUtobusneLInije(List<string> podaci)
        {
            List<AutobusnaLinija> linije = new List<AutobusnaLinija>();
            foreach (string linija in podaci)
            {
                string[] jednaLinija = linija.Split(';');
                AutobusnaLinija novaLinija = new AutobusnaLinija(jednaLinija[0], jednaLinija[1], int.Parse(jednaLinija[2]));
                linije.Add(novaLinija);
            }
            return linije;
        }
    }
}
