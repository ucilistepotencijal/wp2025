


Console.WriteLine("Prijestupne godine između 1900. i 2007. su: ");
for (int i = 1900; i <= 2007; i++)
{
	if (i % 4 == 0 && i % 100 != 0 || i % 100 == 0)
	{
        Console.WriteLine(i);
	}
}
