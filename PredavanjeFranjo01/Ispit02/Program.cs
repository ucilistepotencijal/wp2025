/*Napravi program koji traži unos prirodnog broja sve dok se ne upiše 0.
Program ispisuje koji je najmanji, a koji najveći od unesenih brojeva*/





int maximum = int.MaxValue;
int minimum = int.MinValue;
int broj = 1;


try
{
    for (int i = 1; i > 0; i++)
    {
        Console.Write("Unesi prirodan broj: ");
        broj = int.Parse(Console.ReadLine());

        if (broj < minimum)
        {
            minimum = broj;
        }
        if (broj > maximum)
        {
            maximum = broj;
        }
    }
}
catch (Exception)
{
    Console.WriteLine("Ups... krivi unos!");
}

Console.WriteLine("Maksimum je {0}!", maximum);
Console.WriteLine("Minimum je {0}!", minimum);

