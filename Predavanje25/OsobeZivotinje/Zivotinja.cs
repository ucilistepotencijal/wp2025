using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsobeZivotinje
{
    internal class Zivotinja : IComparable, IMojInterface
    {

        #region Maticna svojstva klase
        public string NarodniNaziv { get; set; }
        public string LatinskiNaziv { get; set; }
        #endregion
        public int CompareTo(object? obj)
        {
            return LatinskiNaziv.CompareTo(((Zivotinja)obj).LatinskiNaziv);
        }

        public string PunoIme()
        {
            return string.Format("{0} ({1})", NarodniNaziv, LatinskiNaziv);
        }
    }
}
