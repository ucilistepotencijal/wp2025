using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_događaji2
{
    public class Polaznik : Osoba
    {
        public delegate void NaPromjenuProgramaObrazovanjaDelegat(object sender, EventArgs e);
        public event NaPromjenuProgramaObrazovanjaDelegat NaPromjenuProgramaObrazovanja;

        private string programObrazovanja;
        public string ProgramObrazovanja
        {
            get
            {
                return programObrazovanja;
            }
            set
            {
                programObrazovanja = value;
                if (NaPromjenuProgramaObrazovanja != null)
                {
                    NaPromjenuProgramaObrazovanja(this, new EventArgs());

                }
            }
        }
    }
}
