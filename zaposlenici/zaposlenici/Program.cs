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
            Console.Title = "Evidencija zaposlenika";
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
                        Console.Clear();
                        Console.WriteLine("Odaberi za kojeg zaposlenika želiš unijeti plaću:");
                        for (int i=0; i<listaZaposlenika.Count(); i++)
                        {
                            int j = i + 1;
                            Console.WriteLine(j + ". " + listaZaposlenika[i].ImePrezime + "\n");
                        }
                        Console.WriteLine("- - - - - - - - - - \nOdabir zaposlenika za unos plaće: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Unesi plaću za zaposlenika: ");
                        double p = double.Parse(Console.ReadLine());
                        listaZaposlenika[a-1].DodajPlacu(p);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("ISPIS SVIH ZAPOSLENIKA\n");
                        Console.WriteLine("|{0,3}|{1,20}|{2,15}|{3,15}|", "ID", "Ime i prezime", "Ukupna plaća", "Prosječna plaća");
                        foreach (Zaposlenik z in listaZaposlenika)
                        {
                            Console.WriteLine("|{0,3}|{1,20}|{2,15}|{3,15}|", z.Id, z.ImePrezime, z.IzracunUkupnePlace(), z.IzracunProsjecneZarade());
                          //  Console.WriteLine(z.Id + " | " + z.ImePrezime + " | " + z.IzracunUkupnePlace() + " | " + z.IzracunProsjecneZarade());
                        }
                        Console.WriteLine("\nPritisnite Enter za povratak u glavni izbornik!");
                        Console.ReadLine();
                        break;
                    case 0:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Pogrešan unos! Pokušajte ponovno!\n");
                        System.Threading.Thread.Sleep(1000);
                        break;
                }
            } while (izbor != 0);
        }
    }
}
