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
            try
            {
                int suma = 0;
                float prosjek;

                for (int i = 1; i <= 5; i++)
                {
                    Console.Write("Unesite {0}. prirodni broj: ", i.ToString());
                    suma += int.Parse(Console.ReadLine());
                }

                prosjek = (float)suma / 5;

                Console.Write("Suma = {0} \nProsjek = {1}", suma, prosjek);
            }

            catch (FormatException fex)
            {
                Console.WriteLine("Greška: Nije unesen broj. " + fex.ToString());
            }

            catch (Exception ex)
            {
                Console.WriteLine("Greška " + ex.ToString());
            }




            Console.ReadKey();

        }
    }
}
