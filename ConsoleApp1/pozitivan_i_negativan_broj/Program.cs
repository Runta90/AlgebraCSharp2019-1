using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pozitivan_i_negativan_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj: ");
            int broj = int.Parse(Console.ReadLine());

            if (broj > 0)
            {
                Console.WriteLine("Broj je pozitivan");
            }

            else
            {
                if (broj == 0)

                {
                    Console.WriteLine("Broje je nula!!");
                }
                else
                {
                    Console.WriteLine("Broj je negativan");
                }

            }

            Console.ReadKey();
            
        
        }
    }
}
