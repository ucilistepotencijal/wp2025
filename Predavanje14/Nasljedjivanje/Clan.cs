using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje
{
    internal class Clan : Osoba
    {
        //konstruktor nije moguće naslijediti, nego moramo napraviti svoj konstruktor
        public Clan(string ime, string prezime) : base(ime, prezime)
        {
        }

        public string ClanskiBroj { get; set; }

        public string Detalji()
        {
            return PunoIme() + ", id: " + ClanskiBroj;
        }

        //skrivanje metode (hide)
        public new string PunoIme()
        {
            return Prezime + " " + Ime;
        }

        public override string ToString()
        {
            return Detalji();
        }
    }
}
