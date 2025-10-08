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
    }
}
