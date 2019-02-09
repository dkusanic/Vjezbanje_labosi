using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrojacUlaza
{
    class Letter
    {
        public int Count { get; set; }
        public string Symbol { get; set; }
        public Letter (string s, int c)
        {
            Symbol = s;
            Count = c;
        }
        public override string ToString()
        {
            string s = Symbol + " -> " + Count;
            return s;
        }
    }
}
