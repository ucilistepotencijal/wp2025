using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak3;

namespace Zadatak03
{
    internal class Pas : Zivotinja
    {
        private string ime;

        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                ime = value;
            }
        }
        private string pasmina;

        public string Pasmina
        {
            get
            {
                return pasmina;
            }
            set
            {
                pasmina = value;
            }
        }
        public new string Glasajse()
        {
            return "Vau!";
        }
        public override string ToString()
        {
            return "pas";
        }

    }
}
