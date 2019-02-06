using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public static class Podaci
    {
        public static List<string> DohvatiAUtobusneLinije()
        {
            List<string> list = new List<string>();
            list.Add("Varaždin;Zagreb;80");
            list.Add("Varaždin;Čakovec;20");
            list.Add("Varaždin:Slavonski Brod;240");
            list.Add("Varaždin;Krapina;40");
            list.Add("Varaždin;Novi Marof;22");
            list.Add("Varaždin;Koprivnica;45");
            list.Add("Varaždin;Virovitica;100");
            list.Add("Varaždin;Osijek;220");
            return list;
        }
    }
}
