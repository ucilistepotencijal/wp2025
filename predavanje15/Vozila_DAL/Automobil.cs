using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila_DAL
{
    public class Automobil : Vozilo
    {
        public int Ccm { get; set; }

        public override string ToString()
        {
            return $"Automobil: {Naziv}, KS: {KS}, CCM: {Ccm}";
        }
    }
}
