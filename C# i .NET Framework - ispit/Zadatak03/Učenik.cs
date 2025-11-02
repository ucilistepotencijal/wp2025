using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using System;

namespace Zadatak03
{
    public class Učenik
    {
        public event Action NaPromjenuDatumaRodjenja;

        public string Ime { get; set; }
        public string Prezime { get; set; }

        private DateTime _datumRodjenja;
        public DateTime DatumRodjenja
        {
            get => _datumRodjenja;
            set
            {
                if (_datumRodjenja != value)
                {
                    _datumRodjenja = value;
                    NaPromjenuDatumaRodjenja?.Invoke();
                }
            }
        }

        public double Prosjek { get; set; }

        public int Starost()
        {
            var today = DateTime.Today;
            int age = today.Year - DatumRodjenja.Year;
            if (DatumRodjenja > today.AddYears(-age)) age--;
            return age;
        }

        public string ProsjekRijecima()
        {
            switch ((int)Math.Round(Prosjek))
            {
                case 1: return "nedovoljan";
                case 2: return "dovoljan";
                case 3: return "dobar";
                case 4: return "vrlo dobar";
                case 5: return "odličan";
                default: return "nepoznat";
            }
        }
    }
}