using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticSaInstancom
{
    internal class Broj
    {
        public bool Savrsen(int broj)
        {
            int suma = 0;
            for (int i = 1; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    suma += i;
                }
            }
            if (broj == suma)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Prost(int broj)
        {
            int brojDjelitelja = 0;
            for (int i = 1; i <= broj; i++)
            {
                if (broj % i == 0)
                {
                    brojDjelitelja++;
                }
            }
            if (brojDjelitelja == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}