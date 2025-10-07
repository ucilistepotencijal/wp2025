using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaposlenikZadatak03
{
    internal class Zaposlenik
    {
        //Svojstva
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
        // Metode
        public double NetoPlaca()
        { 
            return BrojBodova * VrijednostBoda; 
        }
        public double BrutoPlaca()
        {
            return NetoPlaca() + Porez;
        }
        // Konstruktori:
        //default
        public Zaposlenik() { }
        //ostali
        public Zaposlenik(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }
        public Zaposlenik(string ime, string prezime, string oIB)
        {
            Ime = ime;
            Prezime = prezime;
            OIB = oIB;
         }
    }
}
