List<int> uneseniBrojevi = new List<int>();
int unos;

while (true)
{

	Console.Write("Unesi prirodan broj (0 za kraj): ");
	string unos1 = Console.ReadLine();

	try
	{
		unos = int.Parse(unos1);

		if (unos == 0)
			break;

		if (unos < 0)
		{
			Console.WriteLine("Unesi prirodan broj veći od 0: ");
			continue;
		}
		uneseniBrojevi.Add(unos);

	}
	catch (Exception e)
	{

		Console.WriteLine("Dogodila se greška {0}, unosite samo prirodne brojeve!", e.Message);
	}
}
    uneseniBrojevi.Sort();
	uneseniBrojevi.Reverse();
    Console.WriteLine("Uneseni brojevi od većeg prema manjem su: ");
    foreach (int broj in uneseniBrojevi)
    {
        Console.Write(broj + " ");
    }



    