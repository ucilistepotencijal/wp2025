using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDPR
{
    internal class Student
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int GodinaRodenja { get; set; }
        public string MjestoRodenja { get; set; }
        public string OIB { get; set; }
        public string Inicijali()
        {
            return $"{Ime[0]}.{Prezime[0]}.";
        }
        public int Starost()
        {
            return DateTime.Now.Year - GodinaRodenja;
        }
        public bool ProvjeriOIB()
        {
            if (OIB.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string FormatiranjeGodina(int godine)
        {
            int zadnjaZnamenka = godine % 10;
            int zadnjeDviZnamenke = godine % 100;

            if (zadnjaZnamenka == 1 && zadnjeDviZnamenke != 11)
            {
                return $"{godine} godina";
            }
            else if ((zadnjaZnamenka >= 2 && zadnjaZnamenka <= 4) &&
                     (zadnjeDviZnamenke < 12 || zadnjeDviZnamenke > 14))
            {
                return $"{godine} godine";
            }
            else
            {
                return $"{godine} godina";
            }
        }

    }
}
