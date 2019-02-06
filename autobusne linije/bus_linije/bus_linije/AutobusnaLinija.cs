using System.Collections.Generic;

namespace bus_linije
{
    class AutobusnaLinija
    {
        public string Polaziste { get; set; }
        public string Odrediste { get; set; }
        public int Udaljenost { get; set; }
        public double CijenaKarte { get; set; }
        public double CijenaStudenti { get; set; }
        public double CijenaPovratna { get; set; }

        public AutobusnaLinija(string polaziste, string odrediste, int udaljenost)
        {
            Polaziste = polaziste;
            Odrediste = odrediste;
            Udaljenost = udaljenost;
            IzracunajCijenuKarte();
            IzracunajcijenuStudenti();
            IzracunajCijenaPovratna();
        }
        public double IzracunajCijenuKarte()
        {
            return CijenaKarte = (double)Udaljenost * 1.5;
        }
        public double IzracunajcijenuStudenti()
        {
            return CijenaStudenti = (double)Udaljenost * 0.8;
        }
        public double IzracunajCijenaPovratna()
        {
            return CijenaPovratna = (double)Udaljenost * 2 * 0.8;
        }
        public static List<AutobusnaLinija> UcitajAUtobusneLinije(List<string> podaci)
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
