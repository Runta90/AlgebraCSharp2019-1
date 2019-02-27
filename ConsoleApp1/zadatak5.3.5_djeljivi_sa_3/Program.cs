using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak5._3._5_djeljivi_sa_3
{
    class Program
    {
        static void Main(string[] args)


         
        {
            Console.WriteLine("Unesi prvi broj intervala:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi prvi drugi intervala:");
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i < b; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("{0} ", i);
                }
            }

            Console.ReadKey();

            












        }
    }
}
