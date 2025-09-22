


int min = int.MaxValue;
int max = int.MinValue;

for (int i = 0; i<10; i++)
{
    Console.WriteLine("unesi prirodan broj: ");
    int broj = int.Parse(Console.ReadLine());
    if (broj > max)
    {
        max = broj;
    }
    if (broj < min)
    {
        min = broj;
    }
}
Console.WriteLine("maximum je: "+ max);
Console.WriteLine("minimum je: "+ min);