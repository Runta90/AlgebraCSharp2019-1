using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._4._2_primjer_direktor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite ime: ");
            string ime = Console.ReadLine();

            if (ime == "Tomislav" || ime == "Hrvoje" || ime == "Mislav")
            {
                Console.WriteLine("Dobar dan, direktore!");
            }

            else
            {
                Console.WriteLine("Bok!");
            }

            Console.ReadKey();
        }
    }
}
