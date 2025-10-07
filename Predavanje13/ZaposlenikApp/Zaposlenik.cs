using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaposlenikApp
{
    internal class Zaposlenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string OIB { get; set; }
        public double BrojBodova { get; set; }
        public double VrijednostBoda { get; set; }
        public double Porez
        {
            get
            {
                if (NetoPlaca() <= 3000)
                {
                    return NetoPlaca() * 0.05;
                }
                else if (NetoPlaca() <= 6000)
                {
                    return NetoPlaca() * 0.1;
                }
                else
                {
                    return NetoPlaca() * 0.2;
                }
            }
        }

        public double NetoPlaca()
        {
            return BrojBodova * VrijednostBoda;
        }
        public double BrutoPlaca()
        {
            return NetoPlaca() + Porez;
        }

        public Zaposlenik() { }

        public Zaposlenik(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }

        public Zaposlenik (string ime, string prezime, string oIB)
        {
            Ime = ime;
            Prezime = prezime;
            OIB = oIB;
        }
    }
}
