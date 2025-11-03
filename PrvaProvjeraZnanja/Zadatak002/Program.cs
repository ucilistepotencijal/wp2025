
//Napravi program koji traži unos prirodnog broja sve dok se ne upiše 0.
//Program ispisuje koji je najmanji, a koji najveći od unesenih brojeva

int minimum = int.MaxValue;
int maximum = int.MinValue;
int unos = -1;

while (true)
{
    Console.Write("Unesi prirodan broj: ");
    if (int.TryParse(Console.ReadLine(), out unos))
    {
        if (unos == 0)
        {
            break;
        }
        if (unos > maximum)
        {
            maximum = unos;
        }
        if (unos < minimum)
        {
            minimum = unos;
        }
    }
    else
    {
        Console.WriteLine("Kriva vrijednost! Ponovite unos. ");
    }
}

Console.WriteLine("Minimum je {0}, a maksimum {1}", minimum, maximum);