using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;

namespace getCountries
{
    class Country
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private int Population { get; set; }
        private int Area { get; set; }
        private float PopulationDensity { get; set; }
        public Country(int id, string name, int population, int area)
        {

        }

        public float CalculatePopulationDensity()
        {
            return ;
        }

        public static List<Country> GetCountries(List<string> countries)
        {

        }
    }
}
