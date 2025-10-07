using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktori
{
    internal class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

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
            if (prezime )
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
