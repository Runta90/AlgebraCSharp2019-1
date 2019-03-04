using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._1_primjer
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklaracija niza od 3 elementa
            int[] niz = new int[3];

            //init
            niz[0] = 55;
            niz[2] = 77;
            niz[1] = 22;

            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine((i+1) + ": " + niz[i]);
            }

            Console.ReadKey();

 


        }
    }
}
