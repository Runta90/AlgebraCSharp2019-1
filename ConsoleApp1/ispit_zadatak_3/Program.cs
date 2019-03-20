using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispit_zadatak_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil auto = new Automobil();

            Console.Write("Unesi naziv automobila: ");
            auto.Naziv = Console.ReadLine();

            Console.Write("Unesi godinu proizvodnje automobila: ");
            auto.GodinaProizvodnje = int.Parse(Console.ReadLine());

            Console.Write("Unesi osnovnu cijenu automobila: ");
            auto.OsnovnaCijena = double.Parse(Console.ReadLine());
        }
    }
}
