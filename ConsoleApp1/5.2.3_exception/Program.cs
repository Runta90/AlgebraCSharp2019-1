using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._3_exception
{
    class Program
    {
        static void Main(string[] args)

            
        {
            try
            {

                Console.WriteLine("Unesite cijeli broj: ");
                int a = int.Parse(Console.ReadLine());

                if (a > 0)
                {
                    Console.WriteLine("Uneseni broj je pozivan");
                }

                else
                {
                    if (a < 0)
                    {
                        Console.WriteLine("Uneseni broj je negativan");
                    }

                    else
                    {
                        Console.WriteLine("Uneseni broj je jednak 0");
                    }
                }
            }




            catch (FormatException fex)
            {
                Console.WriteLine("GREŠKA, pogrešan format:" + fex.Message);


            }
        

            Console.ReadKey();

        }
    }
}
