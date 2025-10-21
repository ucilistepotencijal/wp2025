using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proizvojlneKolekcije_DAL
{
    public class Polaznik : Osoba 
    {
        public string programObrazovanja {  get; set; }
        public new string punoIme()
        {
            return Prezime + ", " + Ime;
        }
        public override string ToString()
        {
            return punoIme() + ", " + programObrazovanja;
        }
    }
}
