using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsi2
{
    internal interface IDetalji
    {
        //Metoda
        string Detalji();
        //Svojstvo

        int Starost {  get; set; }
    }
}
