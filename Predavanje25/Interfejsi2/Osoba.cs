using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsi2
{
    internal class Osoba : IDetalji, ICloneable, IComparable
    {
        public int Starost { get; set; } // ovo moramo imati jer smo nasljedili interface
        public string Ime { get; set; }
        public string Prezime {  get; set; }

        public object Clone()
        {
            Osoba klon = new Osoba();
            klon.Starost = Starost;
            klon.Ime = Ime;
            klon.Prezime = Prezime;
            return klon;
        }

        public int CompareTo(object? obj)
        {
            return Prezime.CompareTo(((Osoba)obj).Prezime);
        }

        public string Detalji() // ovo moramo imati jer smo nasljedili interface
        {
            return Ime + " " + Prezime;
        }
    }
}
