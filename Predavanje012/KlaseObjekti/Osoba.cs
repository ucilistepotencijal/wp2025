using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseObjekti
{
    

    internal class Osoba
    {
        public string Ime {  get; set; }

        public string Prezime { get; set; }

        public string VratiPunoIme ()

        {
            return Ime + " " + Prezime;
        }
    }
}