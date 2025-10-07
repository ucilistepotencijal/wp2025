using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enkaps
{
    internal class Proizvod
    {
        #region svojstva 
        private string naziv;

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        public double cijena;
        private double Cijena
        {
            get
            {
                return cijena;
            }
            set
            {
                if (value > 0)
                { cijena = value; }
                else { throw new Exception("cijena mora biti veca od nule"); }
               
            }
        }

        public double marza;
        private double Marza
        {
            get
            {
                return marza;
            }
            set
            {
                marza = value;
            }
        }

        private double porez;
        public double Porez
        {
            get
            {
                return porez;
            }
            set
            {
                porez = value;
            }
        }





        #endregion

        #region Metode

        public double MPC()
        {
            return Cijena + Marza + Porez;
        }
        #endregion
    }



}
