using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VozilkaAPP
{
    internal class Automobil: Vozilo
    {
        public double Ccm { get; set; }

        public override string ToString()
        {
            return string.Format("Naziv: {0}, KS: {1}", Naziv, KS);
        }
    }
}
