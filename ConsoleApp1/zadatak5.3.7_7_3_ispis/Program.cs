using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak5._3._7_7_3_ispis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brojevi djeljivi sa 7 i nedjeljivi s 3 u intervalu [1,100] su:");

            for (int i = 1; i < 100; i++)
            {
                if (i % 7 == 0 && !(i % 3 == 0))
                {
                    Console.WriteLine("{0} ", i);
                }
            }

            Console.ReadKey();






        }
    }
}
