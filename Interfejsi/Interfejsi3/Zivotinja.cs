using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsi3
{
    internal class Zivotinja : IComparable, IMojInterface
    {
        #region Matična svojstva klase

        public string NarodniNaziv{ get; set;}
        public string LatinskiNaziv { get; set; }
        #region

        public int CompareTo(object? obj)
        {
            return LatinskiNaziv.CompareTo(((Zivotinja)obj).LatinskiNaziv)
        }

        public string PunoIme { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}
