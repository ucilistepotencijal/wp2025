using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zadatak3
    {
        internal class Zivotinja
        {
            private string vlasnik;
            public string Vlasnik
            {
                get
                {
                    return vlasnik;
                }
                set
                {
                    vlasnik = value;
                }
            }
            private DateTime godinaRodjenja;
            public DateTime GodinaRodjenja
            {
                get
                {
                    return godinaRodjenja;
                }
                set
                {
                    godinaRodjenja = value;
                }
            }
            private double masa;
            public double Masa
            {
                get
                {
                    return masa;
                }
                set
                {
                    masa = value;
                }
            }
            private Spol spol;

            public Spol Spol
            {
                get
                {
                    return spol;
                }
                set
                {
                    spol = value;
                }
            }

            private int vrijemebudjenja;
            public int VrijemeBudjenja
            {
                get
                {
                    return vrijemebudjenja;
                }
                set
                {
                    vrijemebudjenja = value;
                    if (Budjenje != null)
                    {
                        Budjenje(this, new EventArgs());
                    }
                }
            }
            private int vrijemespavanja;
            public int VrijemeSpavanja
            {
                get
                {
                    return vrijemespavanja;
                }
                set
                {
                    vrijemespavanja = value;
                    if (NaSpavanje != null)
                    {
                        NaSpavanje(this, new EventArgs());
                    }
                }
            }

            public string Spavaj()
            {
                return "Zzzz...";
            }
            public string GlasajSe()
            {
                return "Grrr...";
            }
            public int Starost
            {
                get
                {
                    TimeSpan starost = DateTime.Now.Subtract(GodinaRodjenja);
                    return starost.Days / 365;
                }
            }

            public delegate void NaSpavanjeDelegat(object sender, EventArgs e);
            public event NaSpavanjeDelegat NaSpavanje;

            public delegate void BudjenjeDelegat(object sender, EventArgs e);
            public event BudjenjeDelegat Budjenje;
        }
        public enum Spol
        {
            Muški,
            Ženski
        }
    }
