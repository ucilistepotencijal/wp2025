
Console.WriteLine("Sve prijestupne godine od 1900. do 2007. su: ");
for (int i = 1900; i <= 2007; i++)
{
	if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
	{
        Console.WriteLine(i);
	}

}