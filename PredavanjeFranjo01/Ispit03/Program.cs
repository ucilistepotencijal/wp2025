/*Napravi program koji traži unos 10 brojeva. Program ispisuje koliko je
uneseno brojeva djeljivih sa 3 i koliki je njihov umnožak.*/

int brojač = 0;
int umnožak = 1;

try
{
	for (int i = 0; i < 10; i++)
	{
		Console.Write("Unesi prirodni broj: ");
		int broj = int.Parse(Console.ReadLine());

		if (broj % 3 == 0)
		{
			umnožak *= broj;
			brojač++;
		}
	}
    Console.WriteLine("Broj prirodnih brojeva dijeljivih s 3 je {0}!", brojač);
    Console.WriteLine("Umnožak prirodnih brojeva dijeljivih s 3 je {0}!", umnožak);
}
catch (Exception)
{
    Console.WriteLine("Ups... krivi unos!");
}

