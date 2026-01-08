
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Interfejsi3
{
    internal class Osoba : ICloneable, IDisposable, IMojInterface, IComparable
    {
        #region Matična svojstva klase
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Osoba Partner { get; set; }
        #endregion

        #region Implementacija interfacea
        public object Clone()
        {
            Osoba klon = new Osoba();
            klon.Ime = Ime;
            klon.Prezime = Prezime;
            klon.Partner = Partner;
            return klon;
        }

        public int CompareTo(object? obj)
        {
            Osoba o = obj as Osoba; // (Osoba)obj
            return Prezime.CompareTo(o.Prezime);
        }

        public void Dispose()
        {
            //trebamo se riješiti svih refernci koje sadrži naša klasa
            Partner = null;
        }

        public string PunoIme()
        {
            return Ime + " " + Prezime;
        }

        #endregion
    }
}