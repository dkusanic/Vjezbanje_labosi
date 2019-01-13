using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public static class Podaci
    {
        public static List<string> DohvatiAUtobusneLinije()=>
            new List<string>
            {
                "Varaždin;Zagreb;80",
                "Varaždin;Čakovec;20",
                "Varaždin:Slavosnki Brod;240",
                "Varaždin;Krapina;40",
                "Varaždin;Novi marof;22",
                "Varaždin;Koprivnica;45",
                "Varaždin;Virovitica;100",
                "Varaždin;Osijek;220"
            };
    }
}
