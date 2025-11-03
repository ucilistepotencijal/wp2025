using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvoljneKolekcije_DAL
{
    public class Polaznik: Osoba
    {
        public string ProgramiObrazovanja {  get; set; }

        public new string PunoIme()
        {
            return Prezime + " , " + Ime;
        }
        public override string ToString()
        {
                return PunoIme() + " , " + ProgramiObrazovanja;
        }
    }
}
