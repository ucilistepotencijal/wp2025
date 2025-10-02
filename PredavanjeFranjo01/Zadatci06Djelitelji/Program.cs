

Console.Write("Unesi prirodni broj: ");
int broj = int.Parse(Console.ReadLine());
int brojač = 0;

for (int i = 1; i <= broj; i++)
{
	if (broj % i == 0)
	{
		brojač++;
        Console.WriteLine(i);

	}
}

if (brojač == 2)
{
    Console.WriteLine("Prost broj"); 
}
else 
{
    Console.WriteLine("Nije prost broj.");
}