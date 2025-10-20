using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracija
{
    public class Osoba
    {
        public string Ime {  get; set; }
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
        Zenski
    }
}
