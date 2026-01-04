using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    internal class Macka: Zivotinja
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
        public new string GlasajSe()
        {
            return "Mijau";
        }
        public override string ToString()
        {
            return "mačka";
        }
    }
}
