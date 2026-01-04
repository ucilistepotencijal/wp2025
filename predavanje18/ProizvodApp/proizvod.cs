using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodApp
{
    internal class Proizvod
    {
        public delegate void NaizracunCijeneDelegat(object sender, EventArgs e);
        public event NaizracunCijeneDelegat NaizracunCijene;
        public string Naziv { get; set; }
        public double OsnovnaCijena { get; set; }
        private double marza;
        public double Marza
        {
            get { 
                return marza;
            
            } set
            {
                if (value >= 0 && value <= 1)
                {
                    marza = value;
                }
                else
                {
                    throw new Exception("Vrijednost mora biti u segmentu [0,1]");
                }
            }
        }
        public double IzracunajCijenu()
        {
            if (NaizracunCijene != null)
            {
                NaizracunCijene(this, new EventArgs());
            }
            return OsnovnaCijena + OsnovnaCijena * Marza;
        }
    }
}
