using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktori
{
    internal class Osoba
    {
        //1.Svojstva

        public string Ime { get; set; }
        public string Prezime { get; set; }

        //2. Konstruktori
        public Osoba() { }

        public Osoba(string ime)
        {
            Ime = ime;
        }

        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }

        public Osoba(string naziv, bool prezime)
        {
            if (prezime) //ekvivalent prezime == true
            {
                Prezime = naziv;
            }
            else
            {
                Ime = naziv;
            }
        }
    }
}
