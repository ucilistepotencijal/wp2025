using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klaseObjekti2
{
    internal class Osoba
    {
        private static int brojOsoba = 0;

        public static int dohvatiBrojOsoba()
        {
            return brojOsoba;
        }

       public Osoba()
        {
            brojOsoba++;
        }

        public Osoba (string ime, string prezime)
        {
            brojOsoba++;
        }

        public string ime {  get; set; }

        public string prezime { get; set; }

        public string punoIme()
        {
            return ime + " " + prezime;
        }

    }
}
