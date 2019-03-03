using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._12_suma_i_prosjek
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            float prosjek;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Unesite {0}. prorodni broj: ", i.ToString());
                suma += int.Parse(Console.ReadLine());
            }

            prosjek = (float)suma / 5;

            Console.Write("Suma = {0} \nProsjek = {1}", suma, prosjek);

            Console.ReadKey();

        }
    }
}
