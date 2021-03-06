﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak5._3._4_faktorijel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molim unesite cijeli pozitivan broj");
            // 5! = 120 (5*4*3*2*1 = 120)
            try
            {
                int a = int.Parse(Console.ReadLine());
                if (a <= 0)
                {
                    throw new Exception("Negativni broj!");
                }
                if (a >= 20)
                {
                    throw new Exception("Broj veći od 20!");
                }
                int fact = 1;
                for (int i = a; i > 0; i--)
                {
                    //Console.WriteLine(i);
                    fact *= i;
                }

                Console.WriteLine(fact);
            }

            catch (NegativeNumberException ex)
            {
                Console.WriteLine("Dozvoljeni brojevi su u intervalu [1, 19]" + ex.ToString());
            }

            catch (VeciOdDvajstException ex)
            {
                Console.WriteLine("Dozvoljeni brojevi su u intervalu [1, 19]" + ex.ToString());
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException()
        {
        }

        public NegativeNumberException(string message)
            : base(message)
        {
            Console.WriteLine("Dodatno custom pojašnjenje klase NegativeNumberException");
        }

        public NegativeNumberException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
    public class VeciOdDvajstException : Exception
    {
        public VeciOdDvajstException()
        {
        }

        public VeciOdDvajstException(string message)
            : base(message)
        {
        }

        public VeciOdDvajstException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}