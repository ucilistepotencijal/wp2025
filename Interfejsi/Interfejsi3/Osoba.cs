using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsi3
{
    internal class Osoba : ICloneable, IDisposable, IMojInterface, IComparable
    {
        #region Matična svojstva klase
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Osoba Partner { get; set; }
        public string PunoIme { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion

        #region Implementacija interfacea

        public Object Clone()
        {

            Osoba klon = new Osoba();
            klon.Ime = Ime;
            klon.Prezime = Prezime;
            klon.Partner = Partner;
            return klon;
        }
        int IComparable.CompareTo(object? obj)
        {
            Osoba osoba = obj as Osoba; // (Osoba)obj
            return Prezime.CompareTo(osoba.Prezime);

        }
        public void Dispose()
        {
            //Trebamo se riješiti svih referenci koje sadrži naša klasa
            Partner = null;
        }
        public string PunoIme()
        {
            return Ime + " " + Prezime;
        }

    }
}
