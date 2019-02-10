using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class Measurement
    {
        public string Name { get; set; }
        public double Temperature { get; set; }
        public DateTime Time { get; set; }
        public Measurement (DateTime dt, string ime, double t)
        {
            Name = ime;
            Temperature = t;
            Time = dt;
        }
    }
}
