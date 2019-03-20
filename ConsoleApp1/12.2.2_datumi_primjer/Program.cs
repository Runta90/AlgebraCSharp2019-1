using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2._2_datumi_primjer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Učitavamo datumski podatak
            Console.Write("Unesite podatak tipa DateTime:");
            DateTime d1 = DateTime.Parse(Console.ReadLine());

            // Ispisujemo datume
            Console.WriteLine("Datum: ");
            Console.WriteLine(d1);
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToShortDateString());

            // Ispisujemo vrijeme
            Console.WriteLine("Vrijeme: ");
            Console.WriteLine(d1.ToShortTimeString());

            // Ispis dana u tjednu (0 = nedjelja)
            Console.WriteLine("Dan u tjednu: ");
            // Ako ne "kastamo", ispisuje se slovima
            Console.WriteLine(d1.DayOfWeek);
            Console.WriteLine((int)d1.DayOfWeek);

            //Korisničko formatiranje
            //Sistemsko vrijeme ispisujemo na preciznost
            //tisućinke sekunde
            Console.WriteLine("Sada je točno:");
            d1 = DateTime.Now;

            Console.WriteLine(d1.ToString("MMMM, dddd yyyy HH:mm:ss fff"));

            Console.ReadKey();
        }
    }
}
