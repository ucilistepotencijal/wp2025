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
        public int GodinaRodjenja { get; set; }
        public string MjestoStudiranja { get; set; }
        public string OIB {  get; set; }

        //Metode
        public string[] Inicijali()
        {
            string[] slova = Ime.Split(' ');
            return slova;
        }
        public int Starost(int starost)
        {
            starost = 2025 - GodinaRodjenja;
            return starost;
        }
    }
}
