using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._2._6_dobar_broj_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite cijeli broj:");

            int a = int.Parse(Console.ReadLine());

            if (a % 5 == 0 || a % 3 == 0)
            {
                Console.Write("Broj je dobar");
            }

            else
            {
                Console.Write("Broj nije dobar");
            }

            Console.ReadKey();
        }
    }
}
