using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_3
{
    public class Ucenik
    {
        public delegate void PromjenaDatumaDelegat(object sender, EventArgs e);
        public event PromjenaDatumaDelegat NaPromjenuDatumaRodjenja;

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
                if (NaPromjenuDatumaRodjenja != null)
                {
                    NaPromjenuDatumaRodjenja(this, new EventArgs());
                }
            }
        }

        public double Prosjek { get; set; }

        public Ucenik(string ime, string prezime)
        {
            this.Ime = ime;
            this.Prezime = prezime;
        }

        public int Starost()
        {
            TimeSpan starost = DateTime.Now.Subtract(DatumRodjenja);
            return starost.Days / 365;
        }

        public string ProsjekRijecima()
        {
            if (Prosjek < 1.5) return "nedovoljan";
            else if (Prosjek < 2.5) return "dovoljan";
            else if (Prosjek < 3.5) return "dobar";
            else if (Prosjek < 4.5) return "vrlo dobar";
            else return "odličan";
        }
    }
}
