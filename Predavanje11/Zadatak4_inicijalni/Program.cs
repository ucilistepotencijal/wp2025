

/*Napravite program koji na početku generira slučajan broj između 1 i 100.
Korisnik pokušava pogoditi taj broj. Nakon svakog pokušaja, program treba reći
korisniku je li traženi broj veći ili manji od unesenog. Program završava kada korisnik
pogodi broj. */


using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int trazeniBroj = rnd.Next(1, 101); // 1 do 100 uključivo
        int pokusaj;

        Console.WriteLine("Pogodi broj između 1 i 100!");

        while (true)
        {
            Console.Write("Unesite svoj pokušaj: ");
            string unos = Console.ReadLine();

            if (!int.TryParse(unos, out pokusaj))
            {
                Console.WriteLine("Greška: unesite ispravan cijeli broj.");
                continue;
            }

            if (pokusaj < trazeniBroj)
            {
                Console.WriteLine("Traženi broj je veći.");
            }
            else if (pokusaj > trazeniBroj)
            {
                Console.WriteLine("Traženi broj je manji.");
            }
            else
            {
                Console.WriteLine("Čestitamo! Pogodili ste broj.");
                break;
            }
        }
    }
}
