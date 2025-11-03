
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VozilaApp
{
    internal class Vozilo
    {
        public string Naziv { get; set; }
        public string Boja { get; set; }
        public int KS { get; set; }

        /// <summary>
        /// Pretvara konjske snage u kilovate
        /// </summary>
        /// <returns></returns>
        public double KSuKW()
        {
            return KS * 0.736;
        }
    }
}
