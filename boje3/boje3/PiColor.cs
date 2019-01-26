using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boje3
{
    class PiColor
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public string Name { get; set; }
        public PiColor (int r, int g, int b, string n)
        {
            Red = r;
            Green = g;
            Blue = b;
            Name = n;
        }
    }
}
