using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Dogadjaji2
{
    public class Osoba
    {
        //Deklaracija dogadjaja
        public delegate void NaPromjenuImenaDelegat(object sender, EventArgs);
        public event NaPromjenuImenaDelegat NaPromjenuImena;

        public delegate void NaPozivMetodePunoImeDelegat(object sender, EventArgs);
        public event NaPozivMetodePunoImeDelegat NaPozivMetodePunoIme;

        private string ime;
        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                ime = value;
                if (NaPromjenuImena != null)
                {
                    NaPromjenuImena(this, EventArgs());

                }
            }
        }

        public string Prezime { get }