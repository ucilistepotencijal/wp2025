
/*Napravi program koji traži unos prirodnog broja sve dok se ne upiše 0.
Program ispisuje koji je najmanji, a koji najveći od unesenih brojeva
*/



int unos = -1;
int minimum = int.MaxValue;
int maximum = int.MinValue;

while (unos != 0)
{
    Console.Write("Unesi prirodni broj: ");
    unos  = int.Parse(Console.ReadLine());
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
Console.WriteLine("Maksimum je " + maximum);
Console.WriteLine("Minimum je " + minimum);

























