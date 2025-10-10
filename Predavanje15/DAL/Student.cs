using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Student: Osoba
    {
        public double Matemaika { get; set; }
        public double Kemija { get; set; }
        public double Fizika { get; set; }

        public double VratiProsjek()
        {
            return ((double)(Kemija + Fizika + Matemaika)) / 3;
        }
    }
}
