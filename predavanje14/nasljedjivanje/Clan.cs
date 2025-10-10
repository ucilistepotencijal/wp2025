using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasljedjivanje
{
    internal class Clan : Osoba
    {
        public Clan(string ime, string prezime) : base(ime, prezime)
        {

        }

        public string clanskiBroj
        {
            get; set;
        }
        public string detalji()
        {
            return punoIme()+ "id: " + clanskiBroj;
        }

        public new string punoIme()
        {
            return Prezime + " " + Ime;
        }

        public override string ToString()
        {
            return detalji();
        }
    }
}
