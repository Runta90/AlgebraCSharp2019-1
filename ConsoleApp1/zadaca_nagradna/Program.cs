using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca_nagradna
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ucenik> listaUcenika = new List<Ucenik>
            {
                new Ucenik("Ivan", "Ivić"),
                new Ucenik("Maja", "Majić", "54896741236"),
                new Ucenik("Mario", "Marić", "14528614736", 1990),
            };

            listaUcenika.ForEach(Ucenik => IspisUcenika(Ucenik));
            Console.WriteLine("");
            listaUcenika.ForEach(Ucenik => UnesiBrojTelefona(Ucenik));
            listaUcenika.ForEach(Ucenik => UmanjiRacun(Ucenik));
            listaUcenika.ForEach(Ucenik => NoviIspis(Ucenik));

            Console.ReadKey();

        }


            private static void NoviIspis(Ucenik ucenik)
            {
                Console.WriteLine("\nUčenik: {0} {1}", ucenik.Ime, ucenik.Prezime);
                Console.WriteLine("Broj telefona: {0}", ucenik.telefon);
                Console.WriteLine("Stanje računa: {0}", ucenik.Racun);
            }

            private static void UnesiBrojTelefona(Ucenik ucenik)
            {
                Console.WriteLine("Unesite broj telefona za: " + ucenik.Ime + " " + ucenik.Prezime);
                ucenik.telefon = Console.ReadLine();

            }

            private static void UmanjiRacun(Ucenik ucenik)
            {
                Console.WriteLine("Unesite iznos školarine za: " + ucenik.Ime + " " + ucenik.Prezime);
                double iznosSkolarine = double.Parse(Console.ReadLine());
               
                ucenik.Racun -= iznosSkolarine;
            }

            private static void IspisUcenika(Ucenik ucenik)
            {
                Console.WriteLine(ucenik.ToString());
            }
        
    }
}
