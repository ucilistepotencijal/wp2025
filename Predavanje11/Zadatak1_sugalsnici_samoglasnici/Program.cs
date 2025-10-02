/* Zadatak 1: Napravi program koji traži unos rečenice od korisnika, a zatim ispisuje
koliko samoglasnika i koliko suglasnika rečenica sadrži. Program treba biti otporan
na greške pri unosu. */

while (true)
{
	try
	{
		List<char> samoglasnici = new List<char>();
		List<char> suglasnici = new List<char>();
        Console.Write("\nUnesi rečenicu: ");
		string recenica = Console.ReadLine();
        
        foreach (char slovo in recenica.ToLower())
		{
            if (slovo == 'a' || slovo == 'e' || slovo == 'i' || slovo == 'o' || slovo == 'u')
			{
				samoglasnici.Add(slovo);
			}
			else if (char.IsLetter(slovo))
			{
				suglasnici.Add(slovo);
            }
        }
        Console.Write("U rečenici se nalazi {0} samoglasnika i {1} suglasnika.", samoglasnici.Count(), suglasnici.Count());
    }
	catch (Exception e)
	{

		Console.WriteLine("Ups..dogodila se greška: " + e.Message + "Molimo da ponovno unesete rečenicu: ");
		continue;
	}
}