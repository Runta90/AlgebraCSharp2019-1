using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._2_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b = 0;
                string operacija = "";

            Console.WriteLine("Unesite 1. prirodan broj: ");
             a = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite 2. prirodni broj: ");
             b = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite operaciju (+,-,*,/,): ");
            operacija = Console.ReadLine();



            switch (operacija)
            {
                case "+":Console.WriteLine("Zbroj je {0} + {1} = {2}", a, b, (a + b));
                    break;

                case "-":
                    Console.WriteLine("Razlika je {0} - {1} = {2}", a, b, (a - b));
                    break;

                case "*":
                    Console.WriteLine("Umnožak je {0} * {1} = {2}", a, b, (a * b));
                    break;

                case "/":
                    Console.WriteLine("Kvocijent je {0} / {1} = {2}", a, b, (a / b));
                    break;

            }
            Console.ReadLine();
        }
    }
}
