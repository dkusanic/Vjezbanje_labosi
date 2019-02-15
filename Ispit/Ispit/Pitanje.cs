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

        }
    }
}
