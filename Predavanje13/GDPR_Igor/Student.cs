using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDPR
{
    internal class Student
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int GodinaRodenja { get; set; }
        public string MjestoStudiranja { get; set; }
        public string OIB { get; set; }

        public string Inicijali()
        {
            return $"{Ime[0].ToString().ToUpper()}.{Prezime[0].ToString().ToUpper()}.";
        }
        public int Starost()
        {
            return DateTime.Now.Year - GodinaRodenja;
        }
        public bool ProvjeriOIB()
        {
            if (OIB.Length != 11 || !ulong.TryParse(OIB, out ulong iOB))
            {
                return false;
            }
            int iOstatak = 10;
            for (int i = 0; i < OIB.Length - 1; i++)
            {
                int iZnamenka = int.Parse(OIB[i].ToString());

                iOstatak = iZnamenka + iOstatak; // prvom koraku zbraja se s 10

                iOstatak = iOstatak % 10;

                if (iOstatak == 0)
                {
                    iOstatak = 10;
                }

                iOstatak = iOstatak * 2;

                iOstatak = iOstatak % 11;
            }
            int iKontrolnaZnamenka = 11 - iOstatak;
            if (iKontrolnaZnamenka == 10)
            {
                iKontrolnaZnamenka = 0;
            }
            if (int.Parse(OIB[10].ToString()) != iKontrolnaZnamenka)
            {
                return false;
            }
            return true;
        }

    }
}