using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje
{
    internal class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }

        public string PunoIme()
        {
            return string.Format("{0} {1}", Ime, Prezime);
        }
        public override string ToString()
        {
            return PunoIme();
        }
    }
}
