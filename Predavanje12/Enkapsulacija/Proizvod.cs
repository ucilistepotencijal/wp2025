using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Enkapsulacija
{
    internal class Proizvod
    {
        //Svojstva
        #region Svojstva
        private string naziv;

        public string Naziv
        {
            get
            {
                return naziv;
            }
            set
            {
                naziv = value;
            }
        }

        private double cijena;
        public double Cijena
        {
            get
            {
                return cijena;
            }
            set
            {
                if (value > 0)
                {
                    cijena = value;
                }
                else
                {
                    throw new Exception("Cijena mora biti veća od nule!");
                }
            }
        }

        private double marza;
        public double Marza
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

        //Metode
        #region Metode

        public double MPC()
        {
            return Cijena + Marza + Porez;
        }

        #endregion

    }
}
