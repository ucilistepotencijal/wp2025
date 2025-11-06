using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopDAL
{
    public class Narudzba
    {

        public bool DostavaIzvrsena { get; set; }
        public Proizvodi Proizvodi { get; set; }
        public double UkupnaCijena { get; set; }

        public delegate void NarudzbaKreiranaDelegat(object sender, EventArgs e);
        public event NarudzbaKreiranaDelegat NarudzbaKreirana;

        private DateTime datumKreiranja;
        public DateTime DatumKreiranja
        {
            get
            {
                return datumKreiranja;
            }
            set
            {
                datumKreiranja = value;

                if(NarudzbaKreirana != null)
                {
                    NarudzbaKreirana(this, new EventArgs());
                }
            }
        }
    }
}