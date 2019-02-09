using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaposlenici
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Zaposlenik> listaZaposlenika = new List<Zaposlenik>();
            int izbor = 0;
            int id = 1;
            do
            {
                Console.Clear();
                Console.Write("- - - I Z B O R N I K - - -\n" +
                    "1. Dodavanje zaposlenika\n" +
                    "2. Dodavanje plaće zaposleniku (već unesenom)\n" +
                    "3. Pretraživanje i ispis podataka zaposlenika po imenu i/ili ID\n" +
                    "0. Izlaz iz programa\n" +
                    "- - - - - - - - - - - - - - - - - - - - - -\n" +
                    "- - - - - - - - - - - - - - - - - - - - - -\n" +
                    "Vaš odabir: ");
                izbor = int.Parse(Console.ReadLine());
                switch (izbor)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Unesi ime i prezime zaposlenika: ");
                        string ip = Console.ReadLine();
                        Zaposlenik noviZaposlenik = new Zaposlenik(id, ip);
                        listaZaposlenika.Add(noviZaposlenik);
                        id++;
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Pogrešan unos! Pokušajte ponovno!\n");
                        break;
                }
            } while (izbor != 0);
        }
    }
}
