using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rodjendan
{
    public class Osoba
    {
        public delegate void RodjendanDelegat(object sender, EventArgs e);
        public event RodjendanDelegat Rodjendan;
        public string Ime { get; set; }
        public string Prezime { get; set; }
        private DateTime datumRodjenja;
        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenja;
            }
            set
            {
                datumRodjenja = value;
                if (Rodjendan != null)
                {
                    Rodjendan(this, new EventArgs());
                }
            }
        }
        public string Spol { get; set; }
        public int Starost
        {
            get
            {
                TimeSpan starost  = DateTime.Now.Subtract(datumRodjenja);
                return starost.Days / 365;
            }
            
        }

        public Osoba(string ime, string prezime)
        {
            this.Ime = ime;
            this.Prezime = prezime;
        }


    }
}
