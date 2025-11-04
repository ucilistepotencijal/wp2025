using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopDAL
{
    public class Proizvod
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public double JedCijena { get; set; }
        public bool Dostupan {  get; set; }
        public double UkupnaCijena
        {
            get
            {
                return IzracunajPDV();
            }
        }
        public double IzracunajPDV()
        {
            return JedCijena * 1.25;
        }
    }
}
