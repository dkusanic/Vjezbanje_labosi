using System.Collections.Generic;
using System.Data.Common;

namespace Ispit
{
    class Kolegij
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public Kolegij (DbDataReader podaci)
        {
            if (podaci != null)
            {
                Id = int.Parse(podaci["Id"].ToString());
                Naziv = podaci["Naziv"].ToString();
                //DohvatiPitanja();
            }
        }
        public static List<Kolegij> DohvatiKolegije()
        {
            List<Kolegij> listaKolegija = new List<Kolegij>();
            string sqlUpit = "SELECT * FROM Kolegiji";
            DbDataReader podaci = DB.Instance.DohvatiDataReader(sqlUpit);
            while (podaci.Read())
            {
                Kolegij k = new Kolegij(podaci);
                listaKolegija.Add(k);
            }
            podaci.Close();
            return listaKolegija;
        }
        public List<Pitanje> DohvatiPitanja()
        {
            List<Pitanje> listaPitanja = new List<Pitanje>();
            string sqlUpit = "SELECT * FROM Pitanja WHERE IdKolegija=" + this.Id;
            DbDataReader podaci = DB.Instance.DohvatiDataReader(sqlUpit);
            while (podaci.Read())
            {
                Pitanje p = new Pitanje(podaci);
                listaPitanja.Add(p);
            }
            podaci.Close();
            return listaPitanja;
        }
    }
}
