using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak3;

namespace Zadatak03
{
    internal class Macka : Zivotinja
    {
        private string boja;

        public string Boja
        {
            get
            {
                return boja;
            }
            set
            {
                boja = value;
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
            return "Mjau!";
        }
        public override string ToString()
        {
            return "mačka";
        }
    }
}
