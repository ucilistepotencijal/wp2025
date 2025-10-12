using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Student : Osoba //klasa student nasljeđuje klasu osoba
    {
        public double Matematika { get; set; }
        public double Kemija { get; set; }
        public double Fizika { get; set; }
        public double VratiProsjek()
        {
            return ((double)(Matematika + Kemija + Fizika))/3;
        }
    }
}
