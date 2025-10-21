using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila_DAL
{
    public class Zrakoplov : Vozilo
    {

        public string Tvrtka { get; set; }
        private List<string> zrakopovi = new List<string>();

        public override string ToString()
        {
            return $"Zrakoplov: {Naziv}, Tvrtka: {Tvrtka}";
        }
    }   
}
