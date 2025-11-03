using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak3
{
    internal class pas : zivotinje
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
            get { return pasmina; }

            set { pasmina = value; }
        }

        public new string glasajSe()
        {
            return "vau";
        }
        public override string ToString()
        {
            return "pas";
        }
    }
}
