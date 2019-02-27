using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak5._3._9_djeljitelji
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi prirodan broj");
            int broj = int.Parse(Console.ReadLine());

            Console.WriteLine("Djeljitelji broja {0} su:", broj);

            for (int i = 1; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    Console.WriteLine("{0}", i);
                }
            }
            Console.ReadKey();



        }
    }
}
