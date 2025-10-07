using System;
using System.Text; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseObjekti
{
    internal class osoba
    {
        public string ime;
        public string prezime;
        public int godine;
        public void PredstaviSe()
        {
            Console.WriteLine($"Zdravo, ja sam {ime} {prezime} i imam {godine} godina.");
        }
        // Entferne oder korrigiere die fehlerhafte using-Direktive
        // using System.Threading.Task;
    }
}


