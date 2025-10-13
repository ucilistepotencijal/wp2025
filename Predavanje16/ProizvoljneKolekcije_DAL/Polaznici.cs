using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvoljneKolekcije_DAL
{
    public class Polaznici: CollectionBase
    {
        public int Add(object polaznik)
        {
            return InnerList.Add(polaznik);
        }
        public int Add(string ime, string prezime)
        {
            Polaznik p = new Polaznik();
            p.Ime = ime;
            p.Prezime = prezime;
            return InnerList.Add(p);
        }

        //Implementacija indexera
        public object this[int index]
        {
            get
            {
                return (Polaznici)InnerList[index];
            }
        }
    }
}
