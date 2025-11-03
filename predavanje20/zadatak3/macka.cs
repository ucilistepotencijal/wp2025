using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak3
{
    internal class macka : zivotinje
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

        public new string glasajSe()
        {
            return "mijau";
        }

        public override string ToString()
        {
            return "mačka";
        }
    }
}
