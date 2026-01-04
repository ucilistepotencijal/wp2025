//Napravi program koji traži unos 10 brojeva. Program ispisuje koliko je
//uneseno brojeva djeljivih sa 3 i koliki je njihov umnožak.

int brojac = 0;
decimal umnozak = 1;

for (int i = 0; i < 10; i++)
{
	bool dobarUnos = false;
	while (!dobarUnos)
	{
		Console.Write("Unesi broj: ");
		try
		{
			decimal unos = decimal.Parse(Console.ReadLine());
			dobarUnos = true;
			if (unos % 3 == 0)
			{
				brojac++;
			}
			umnozak *= unos;
		}
		catch (Exception e)
		{
			Console.WriteLine($"Dogodila se greška: {e.Message}. Ponovi unos!");
		} 
	}
}
Console.WriteLine("Uneseno je {0} brojeva djeljivih sa 3.", brojac);
Console.WriteLine("Umnožak unesenih brojeva je {0}", umnozak);