using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila_DAL
{
    public class Zrakoplov:Vozilo
    {
        public string Tvrtka {  get; set; }

        public override string ToString()
        {
            return $"Naziv: {Naziv}, Tvrtka: {Tvrtka}";
        }
    }
}
