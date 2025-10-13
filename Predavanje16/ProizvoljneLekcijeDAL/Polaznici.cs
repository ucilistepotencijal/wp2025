using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProizvoljneLekcijeDAL
{
    public class Polaznici : CollectionBase
    {
        public int Add(object polaznik)
        {
            return InnerList.Add(polaznik);
        }

        public int Add(string Ime, string Prezime)
        {
            Polaznik p = new Polaznik();
            p.Ime = Ime;
            p.Prezime = Prezime;
            return InnerList.Add(p);
        }

        // implementacija indexera
        public object this[int index]
        {
            get
            {
                return (Polaznik)InnerList[index];
            }
        }
    }
}