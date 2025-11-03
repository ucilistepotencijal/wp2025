
/*:Napravi program koji traži unos brojeva od korisnika dok zbroj svih
unesenih brojeva ne premaši 100. Kada se to dogodi, program treba ispisati konačni
zbroj.*/



using System;

class Program
{
    static void Main()
    {
        int suma = 0;

        while (suma <= 100)
        {
            Console.Write("Unesite broj: ");
            string unos = Console.ReadLine();

            if (!int.TryParse(unos, out int broj))
            {
                Console.WriteLine("Greška: unesite ispravan cijeli broj.");
                continue;
            }

            suma += broj;
        }

        Console.WriteLine($"Konačni zbroj je: {suma}");
    }
}