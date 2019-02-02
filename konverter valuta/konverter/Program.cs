using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konverter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tecaj> tecajnaLista = new List<Tecaj>();
            int unos;
            do
            {
                Console.Clear();
                Console.Write("---IZBORNIK---\n" +
                "Odaberi:\n" +
                "--------\n" +
                "1 - Konvertiraj\n" +
                "2 - Izlaz\n" +
                "---------\n" +
                "UNOS: ");
                unos = int.Parse(Console.ReadLine());
                switch(unos)
                {
                    case 1:
                        tecajnaLista.Clear();
                        string url = "https://www.hnb.hr/tecajn/htecajn.htm";
                        System.Net.WebClient webClient = new System.Net.WebClient();
                        webClient.DownloadFile(url, "lista.txt");
                        string[] hnbTecaj = File.ReadAllLines("lista.txt");
                        for (int i = 1; i < hnbTecaj.Count(); i++)
                        {
                            Tecaj t = new Tecaj(hnbTecaj[i].Substring(3, 3).ToString(), double.Parse(hnbTecaj[i].Substring(31, 8)));
                            Console.WriteLine(t.Valuta + " = " + t.Iznos);
                            tecajnaLista.Add(t);
                        }
                        string valuta2 = "HRK";
                        Console.Write("Unesi iznos koji želiš konvertirati: ");
                        double iznos = double.Parse(Console.ReadLine());
                        Console.Write("Iz koje valute želiš konvertirati: ");
                        string valuta1 = "";
                        valuta1 = Console.ReadLine().ToString();
                        Console.Write("U koju valutu želiš konvertirati: ");
                        string valuta3 = "";
                        valuta3 = Console.ReadLine().ToString();
                        double temp = 0;
                        foreach (var v in tecajnaLista)
                        {
                            if (v.Valuta==valuta1)
                            {
                                temp = v.Iznos * iznos;
                                //Console.Write(iznos + " " + valuta1 + " = " + temp + " " + valuta2);
                            }
                        }
                        foreach (var v in tecajnaLista)
                        {
                            if(v.Valuta==valuta3)
                            {
                                double konv = temp / v.Iznos;
                                Console.Write(iznos + " " + valuta1 + " = " + konv + " " + valuta3);
                            }
                        }
                        Console.Write("\nŽeliš li opet konvertirati (D/N):");
                        string dn = Console.ReadLine().ToString();
                        if (dn == "D")
                            goto case 1;
                        else
                            break;
                    case 2:
                        Console.Write("Izlazim iz programa...\nPress any key to exit...");
                        string e = Console.ReadKey().ToString();
                        break;
                    default:
                        Console.Write("Pogrešan unos\n");
                        Console.Read();
                        break;
                }
            } while (unos != 2);
            
        }
    }
}
