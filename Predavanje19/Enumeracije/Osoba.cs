

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracije
{
    public class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Spol Spol { get; set; }
        public void IspisiDetalje()
        {
            Console.WriteLine("Ime: {0}, Prezime: {1}, Spol: {2}", this.Ime, this.Prezime, this.Spol);
        }

    }
    public enum Spol
    {
        Muski,
        Zenski,
        Nepoznato
    }
    public enum Tjedan
    {
        ponedjeljak = 1,
        utorak,
        srijeda,
        četvrtak,
        petak,
        subota,
        nedjelja
    }
}