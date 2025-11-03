using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Dogadjaji2
{
    public class Polaznik : Osoba
    {
        public delegate void NaPromjenuProgramaObrazovanjaDelegat(object sender, EventArgs eventArgs);
        public event NaPromjenuProgramaObrazovanjaDelegat NaPromjenuProgramaObrazovanja;

        private string programOBrazovanja;
        public string ProgramOBrazovanja
        {
            get
            {
                return programOBrazovanja;
            }
            set
            {
                programOBrazovanja = value;
                if (NaPromjenuProgramaObrazovanja != null)
                {
                    NaPromjenuProgramaObrazovanja(this, new EventArgs());
                }
            }
        }
    }
}