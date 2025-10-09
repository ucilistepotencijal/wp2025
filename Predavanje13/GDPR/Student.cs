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
        public string GodinaRođenja { get; set; }
        public string MjestoStudiranja { get; set; }
        public string OIB { get; set; }

        public string Inicijali { get; set; }

        {
        return $" {Ime[0]}.{Prezime[0]}."}

    public int Starost()
    return DataTime.Now.Year - godinaRođenja;
        public bool ProvjeriOIB()
    {
        if (OIB.Lenght != 11 || !ulong Tryparse(OIB, out ulong iOB))
    {
            return false;
        }
        int iOstatak = 10;

    }
        for(int i = 0; i<OIB.Lenght -1;  i++) 
        {
            int iZnamenka = OIB[i];
    iOstatak = iZnamenka + iOstatak;
              
             iOstatak = iOstatak % 10;
        if (iOstatak == 0)
        {
        iOstatak = 10;
        }


        int iCjelobrojnoPodijelis10 = iZbrojS 10 % 10;
        int 
}
    
}
