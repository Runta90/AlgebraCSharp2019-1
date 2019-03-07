using System;

namespace _8._1._2_zadaca_automobil
{
    internal class Automobil
    {
        public string MarkaAutomobila = "";
        public double KS = 0;
        public double OsnovnaCijena = 0;
        

        public double IznosPoreza()
        {
            double postotak = 0;

            if (KS < 50)
            {
                postotak = 0.05;
            }

            else if (KS < 150)
            {
                postotak = 0.01;
            }

            else
            {
                postotak = 0.15;
            }

            return OsnovnaCijena * postotak;

           
        }

        internal double UkupnaCijena()
        {
            double uc = 0;
            uc = (double)(OsnovnaCijena + IznosPoreza());

            return uc;

            
            //throw new NotImplementedException();
        }

    }
}