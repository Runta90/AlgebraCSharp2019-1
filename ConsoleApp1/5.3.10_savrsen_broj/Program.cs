using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._10_savrsen_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prirodan broj:");
            int a = int.Parse(Console.ReadLine());

            int broj = 0;

            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    broj += i;

                }
            }

            if (a == broj)
            {
                Console.WriteLine("Unešeni broj je savršen.");
            }

            else
            {
                Console.WriteLine("Unešeni broj nije savršen.");
            }

            Console.ReadKey();
        }
    }
}
