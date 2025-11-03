

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobili
{
    internal class Automobil
    {
        //Svojstva
        public string Marka { get; set; }
        public double KS { get; set; }
        public double OsnovnaCijena { get; set; }

        //Metode
        public double IznosPoreza()
        {
            double postotak = 0;
            if (KS < 50)
            {
                postotak = 0.05;
            }
            else if (KS < 150)
            {
                postotak = 0.1;
            }
            else
            {
                postotak = 0.15;
            }
            return OsnovnaCijena * postotak;
        }
        public double UkupnaCijena()
        {
            return OsnovnaCijena + IznosPoreza();
        }
    }
}