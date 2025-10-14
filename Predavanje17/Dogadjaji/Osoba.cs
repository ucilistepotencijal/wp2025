using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji
{
    public class Osoba
    {
        //1. Deklaracija događaja
        public delegate void NaPromjenuImenaDelegat(object sender, EventArgs e);
        //delegat je tip koji reprezentira referencu na metodu koja ima specifićan potpis
        //koristi se za definiranje događaja kojem predajemo ovaj delegat
        //sender je objekt koji nam šalje događaje a EventArgs su dodatni događaji (za sad ih ostavljamo prazno)

        public event NaPromjenuImenaDelegat NaPromjenuimena; //deklarirali smo event NaPromjenuImena 
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
                //2. Moramo provjeriti da je događaj implementiran
                if (NaPromjenuimena != null)
                {
                    NaPromjenuimena(this, new EventArgs());
                }
            }
        }
    }
}
