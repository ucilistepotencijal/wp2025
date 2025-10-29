using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Student: Osoba
    {
        public double Matematika { get; set; }
        public double Kemija { get; set; }
        public double Fizika { get; set; }
        public double Vratiprosjek()
        {
            return (Matematika + Kemija + Fizika) / 3.0;
        }
    }

            Console.WriteLine();
            var student = new Student
            {
                Ime = " Marko",
                Prezime = "Marković",
                Matematika = 5,
                Fizika = 4,
                Kemija = 4
            };
            Console.WriteLine("Prosjek: " + Math.Round(student.Vratiprosjek(), 2));

        public double VratiProsjek()
        {
            return ((double)(Matematika + Fizika + Kemija)) / 3;
        }
    }
}
