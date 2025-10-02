
int brojač = 0;


for (int i = 1; i <= 100; i++)
{
	if (i % 5 == 0 && i % 2 != 0)
	{
		brojač++;
	}
}

Console.WriteLine("Broj prirodnih brojeva djeljivih s 5, a nedjeljivih s 2 u intervalu [1,100] je " + brojač);