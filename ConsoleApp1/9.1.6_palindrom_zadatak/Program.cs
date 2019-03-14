using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1._6_palindrom_zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi tekst: ");
            string tekst = Console.ReadLine();

            // Prvo ukloniti razmake
            tekst = tekst.Replace(" ", "");

            // Zatim u novu string varijablu učitati zdesna na lijevo sve znakove
            string obrnuto = "";
            for (int i = tekst.Length - 1; i >= 0; i--)
            {
                obrnuto += tekst[i];
            }

            // Ako je početni i obrnuti niz znakova isti, imamo palindrom
            if (tekst == obrnuto)
            {
                Console.WriteLine("To je PALINDROM.");
            }
            else
            {
                Console.WriteLine("To NIJE palindrom.");
            }

            Console.ReadKey();
        }
    }
}
