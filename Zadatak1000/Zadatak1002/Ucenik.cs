using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1002
{
    public class Ucenik
    {
        public string Ime
        { get;
            set; 
        }
        public string Prezime 
        { 
            get
            {
                return Ime;
            }
            set
            {
                Ime = value;
            }
                }

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
            }

        }

        public double Prosjek 
        {
            get
            {
                return Prosjek;

            }
            set
            {
                Prosjek = value;
            }
        }

        public int Starost
        {
            get
            {
                TimeSpan starost = DateTime.Now.Subtract(GodinaRodjenja);
                return starost.Days / 365;
            }
        }

        public string ProsjekRijecima()
        {
            if (Prosjek < 1.5) return "nedovoljan";
            if (Prosjek < 2.5) return "dovoljan";
            if (Prosjek < 3.5) return "dobar";
            if (Prosjek < 4.5) return "vrlo dobar";
            return "odličan";
        }

        public override string ToString()
        {
            return $"Ime: {Ime}Prezime: {Prezime}" +
                $"Datum rođenja: {DatumRodjenja:dd.MM.yyyy}" +
                $"Starost: {Starost()} godina" +
                $"Prosjek: {Prosjek} ({ProsjekRijecima()})";
        }
    }

}












