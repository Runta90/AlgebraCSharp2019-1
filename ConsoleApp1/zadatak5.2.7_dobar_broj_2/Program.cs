using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak5._2._7_dobar_broj_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite cijeli broj:");
            int broj = 0;
            try

            {
             broj = int.Parse(Console.ReadLine());
            }

            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            if (broj % 4 == 0 && broj >= 100)
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
