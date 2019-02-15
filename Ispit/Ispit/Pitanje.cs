using System.Data.Common;

namespace Ispit
{
    class Pitanje
    {
        public int Id { get; set; }
        public string Tekst { get; set; }
        public float BrojBodova { get; set; }
        public Pitanje(DbDataReader podaci)
        {
            if (podaci != null)
            {
                Id = int.Parse(podaci["Id"].ToString());
                Tekst = podaci["Tekst"].ToString();
                BrojBodova = float.Parse(podaci["BrojBodova"].ToString());
            }
        }
    }
}
