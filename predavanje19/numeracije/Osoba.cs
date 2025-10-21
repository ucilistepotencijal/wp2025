using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeracije
{
    internal class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Spol Spol { get; set; }
        public void IspisiDetalje()
        {
            Console.WriteLine("ime: {0}, prezime: {1}, spol: {2}", this.Ime, this.Prezime, this.Spol);
        }
    }
    public enum Spol
    {
        Muski,
        Zenski,
        nepoznato
    }
    public enum Tjedan
    {
        pon = 1,
        uto,
        sri,
        cet,
        pet,
        sub,
        ned
    }
}
