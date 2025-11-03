/* Zadatak 2: Napravi program koji traži unos brojeva sve dok se ne unese broj 0.
Program ispisuje:
Brojevi djeljivi s 2 i 3: ...
Brojevi djeljivi s 2 ali ne sa 3: ...
Brojevi djeljivi s 3 ali ne s 2: ...
Ostali brojevi: ... */

int unos = -1;
List<int> spremnik = new List<int>(); 


while (unos != 0)
{
    Console.Write("Unesi broj (0 za kraj): ");

    try
    {
        unos = int.Parse(Console.ReadLine());
        if (unos != 0)
        {
            spremnik.Add(unos);
        }
    }
    catch (Exception e)
    {

        Console.WriteLine("Unos je pogrešan: " + e);
        continue;
    }
}

Console.Clear();
Console.Write("Brojevi djeljivi s 2 i 3 su: ");
foreach (int i in spremnik)
{
    if (i % 2 == 0 && i % 3 == 0 && i != 0)
    {
        Console.Write(i + " ");
    }
}
Console.Write("\nBrojevi djeljivi s 2 ali ne i s 3 su: ");
foreach (int i in spremnik)
{
    if (i % 2 == 0 && i % 3 != 0 && i != 0)
    {
        Console.Write(i + " ");
    }
}
Console.Write("\nBrojevi djeljivi s 3 ali ne i s 2 su: ");
foreach (int i in spremnik)
{
    if (i % 2 != 0 && i % 3 == 0 && i != 0)
    {
        Console.Write(i + " ");
    }
}
Console.Write("\nOstali brojevi su: ");
foreach (int i in spremnik)
{
    if (i % 2 != 0 && i % 3 != 0)
    {
        Console.Write(i + " ");
    }
}
