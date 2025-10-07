/*Napiši program u kojem se traži unos 10 prirodnih brojeva, a zaƟm se ispisuje najmanji i 
najveći od njih.
*/

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

Console.WriteLine("Maksimum je " + maximum);
Console.WriteLine("Minimum je " + minimum);
    