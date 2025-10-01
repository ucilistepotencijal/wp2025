/* Napiši program koji provjerava jeli unesena rijec ili recenica palindrom
Napomena: Treba zanemariti razmake, interpunkcijske znakove i velika i mala slova */

namespace Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void Palindrom(string unos)
        {
            string[] rijeci = unos.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        }
    }
}
