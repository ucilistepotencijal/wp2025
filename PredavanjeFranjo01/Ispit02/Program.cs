/*Napravi program koji traži unos prirodnog broja sve dok se ne upiše 0.
Program ispisuje koji je najmanji, a koji najveći od unesenih brojeva*/

int najmanji = int.MaxValue;
int najveći = int.MinValue;
int broj = -1;

try
{
    while (broj != 0)
    {
        Console.Write("Unesi prirodan broj ili 0 za kraj: ");
        broj = int.Parse(Console.ReadLine());

        if (broj == 0)
        {
            break;
        }
        if (broj > najveći)
        {
            najveći = broj;
        }
        if (broj < najmanji)
        {
            najmanji = broj;
        }
        
    }
    Console.WriteLine("Najveći uneseni broj je " + najveći);
    Console.WriteLine("Najmanji uneseni broj je " + najmanji);
}
catch (Exception)
{

    Console.WriteLine("Krivi unos!");
}