using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProizvoljneLekcijeDAL
{
    public class Osoba
    {
        #region Svojstva
        private string Ime;
        private string Prezime;

        public string Ime { get => ime; set => ime = value};

        public string Prezime { get => prezime; set => prezime = value; };
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

        #region Metode

        public string PunoIme()
        {
            return Ime + " "+ Prezime;  
        }
        public override string Tostring()
        {
            return PunoIme();
        }
        #region

    }
}
