using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Student : Osoba
    {
        public double Mat { get; set; }
        public double Kem { get; set; }
        public double Fiz { get; set; }

        public double VratiProsjek()
        {
            return ((double)(Mat + Fiz + Kem)) /3;
        }
    }
}
