/* Zadatak 3: Napravite program koji traži unos riječi od korisnika. Program treba
nastaviti tražiti unos dok korisnik ne unese riječ koja je već prethodno unesena.
Nakon toga, program treba ispisati riječ koja se ponovila i završiti izvršavanje. */

List<string> uneseneRijeci = new List <string>();
while (true)
{
	try
	{
		Console.Write("Unesi riječ: ");
		string rijec = Console.ReadLine();

		if (uneseneRijeci.Contains(rijec)) 
		{
			Console.WriteLine("Ponovljena riječ: " + rijec);
			break;
		}
		else
		{
			uneseneRijeci.Add(rijec);
		}
		
	}
	catch (Exception e)
	{

        Console.WriteLine("Ups..dogodila se greška: " + e.Message + "Molimo da ponovno unesete riječ: ");
        continue;
    }
}