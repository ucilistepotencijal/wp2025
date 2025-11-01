/* Napravi klasu Ucenik:
1) Svojstva: 
a.Ime(string)
b.Prezime(string)
c.DatumRodjenja(DateTime)
d.Prosjek(double)
2) Metode:
a.Starost() – računa se u godinama pomoću datuma rođenja i tekućeg
datuma
b. ProsjekRijecima() - određuje se pomoću brojčanog podatka spremljenog u
svojstvu Prosjek (nedovoljan, dovoljan, dobar, vrlo dobar, odličan)
3) Događaji:
a. NaPromjenuDatumaRodjenja – događaj se podiže kad se promijeni
vrijednost svojstva DatumRodjenja. Na konzoli se tada ispisuje starost
učenika. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak03
{
    public class Ucenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public double Prosjek { get; set; }

        public int Starost()
        {
           TimeSpan starost = DateTime.Now.Subtract(DatumRodjenja);
            return starost.Days / 356;
        }
        public string ProsjekRijecima()
        {
            if (Prosjek >= 4.5)
            {
                return "Odličan";
            }
            else if (Prosjek >= 3.5)
            {
                return "Vrlo dobar";
            }
            else if (Prosjek > 2.5)
            {
                return "Dobar";
            }
            else if (Prosjek > 1.5) 
            {
                return "Dovoljan";
            }
            else
            {
                return "Nedovoljan";
            }

            //nisam još naučila događaje :(
        }
    }

   
}
