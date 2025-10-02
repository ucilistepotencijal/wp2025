/* Zadatak 4: Napravite program koji na početku generira slučajan broj između 1 i 100.
Korisnik pokušava pogoditi taj broj. Nakon svakog pokušaja, program treba reći
korisniku je li traženi broj veći ili manji od unesenog. Program završava kada korisnik
pogodi broj. */

Random rdn = new Random();
int j = rdn.Next(1, 101);


while (true)
{
	try
	{
        Console.Write("\nPogodi broj između 1 i 100: ");
        int broj = int.Parse(Console.ReadLine());

        if (broj > j)
		{
			Console.Write($"Broj je manji od {broj}.");
		}
		else if (broj < j)
		{
            Console.Write($"Broj je veći od {broj}.");
        }
		else
		{
            Console.Write($"Broj {broj} je točan broj!");
			break;
        }
	}
	catch (Exception e)
	{

        Console.WriteLine("Ups..dogodila se greška: " + e.Message + "Molimo da ponovno unesete riječ: ");
        continue;
    }
} 
