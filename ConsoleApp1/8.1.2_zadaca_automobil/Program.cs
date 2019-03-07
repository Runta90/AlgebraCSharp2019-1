using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._2_zadaca_automobil
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil auto = new Automobil();

            Console.Write("Unesi marku automobila:  ");
            auto.MarkaAutomobila = Console.ReadLine();

            Console.Write("Unesi broj konjskih snaga:  ");
            auto.KS = double.Parse(Console.ReadLine());

            Console.Write("Unesi osnovnu cijenu:  ");
            auto.OsnovnaCijena = double.Parse(Console.ReadLine());

            Console.WriteLine("Iznos poreza: {0} \nUkupna cijena: {1}", auto.IznosPoreza(), auto.UkupnaCijena());

            Console.ReadKey();
        }
    }
}
