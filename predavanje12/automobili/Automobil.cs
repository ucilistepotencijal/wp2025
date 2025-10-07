using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automobili
{
    internal class Automobil
    {
        public string Marka {  get; set; }
        public double KS { get; set; }
        public double osnovnaCijena { get; set; }

        public double iznosPoreza()
        {
            double postotak = 0; 
            if (KS < 50 )
            {
                postotak = 0.05;
            }
            else if (KS <150)
            {
                postotak = 0.1;
            }
            else
            {
                postotak = 1.5;
            }
            return osnovnaCijena * postotak;
        }

        public double ukupnaCijena()
        {
            return osnovnaCijena + iznosPoreza();
        }

    }
}
