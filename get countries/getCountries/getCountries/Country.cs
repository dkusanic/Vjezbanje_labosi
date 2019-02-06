using System;
using System.Collections.Generic;

namespace getCountries
{
    class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public int Area { get; set; }
        public float PopulationDensity { get; set; }

        public Country(int id, string name, int population, int area)
        {
            Id = id;
            Name = name;
            Population = population;
            Area = area;
            CalculatePopulationDensity();
        }

        public float CalculatePopulationDensity()
        {
            PopulationDensity = (float)Population / Area;
            return PopulationDensity;
        }

        public static List<Country> GetCountries(List<string> countries)
        {
            List<Country> listaZemalja = new List<Country>();
            
            foreach (string zemlja in countries)
            {
                string[] razdvojeno = zemlja.Split(';');
                
                Country jednaZemlja = new Country(Int32.Parse(razdvojeno[0]), razdvojeno[1], Int32.Parse(razdvojeno[2]), Int32.Parse(razdvojeno[3]));
                listaZemalja.Add(jednaZemlja);
            }
            return listaZemalja;
        }
    }
}
