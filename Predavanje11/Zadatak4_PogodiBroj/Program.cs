/* Zadatak 4: Napravite program koji na početku generira slučajan broj između 1 i 100.
Korisnik pokušava pogoditi taj broj. Nakon svakog pokušaja, program treba reći
korisniku je li traženi broj veći ili manji od unesenog. Program završava kada korisnik
pogodi broj. */

Random rdn = new Random();
Console.Write("Pogodi broj između 1 i 100: ");
int broj = int.Parse(Console.ReadLine());

while (true)
{
	try
	{

	}
	catch (Exception e)
	{

        Console.WriteLine("Ups..dogodila se greška: " + e.Message + "Molimo da ponovno unesete riječ: ");
        continue;
    }
} 
