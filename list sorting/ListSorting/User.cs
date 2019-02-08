using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSorting
{
    class User
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public User (string n, string l)
        {
            Name = n;
            Lastname = l;
        }
        public override string ToString()
        {
            string s = Name + ", " + Lastname;
            return s;
        }
    }
}
