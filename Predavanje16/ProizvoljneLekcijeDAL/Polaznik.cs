using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProizvoljneLekcijeDAL
{
    public class Polaznik: Osoba
    {
    public string ProgramiObrazovanja {  get; set; }
        public new string PunoIme()
        {
            return Prezime + "," Ime;
        }
        public override string Tostring()
        {
            return PunoIme() + "," + ProgramiObrazovanja;
        }


    }    
}
