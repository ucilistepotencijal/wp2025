

int minimum = int.MaxValue;
int maximum = int.MinValue;


for (int i = 0; i < 10; i++)
{
    Console.Write("Unesi prirodan broj: ");
    int broj = int.Parse(Console.ReadLine());
    if (broj > maximum)
    {
    maximum = broj;
    }
    if (broj < minimum)
    {
        minimum = broj;
    }
}

Console.WriteLine("Najveći broj je " + maximum);
Console.WriteLine("Najmanji broj je " + minimum);
