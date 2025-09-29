//Napiši program u kojem se traži unos 10 brojeva koji se zatim ispisuju,ali najvećem i 
//najmanjem treba zamjeniti mjesta.

using System.Collections;

ArrayList nizBrojeva = new ArrayList();
int minimum = int.MaxValue;
int maximum = int.MinValue;
for (int i = 0; i < 10; i++)
{
    Console.Write("Unesi {0}. broj: ", i + 1);
    int broj = int.Parse(Console.ReadLine());
    nizBrojeva.Add(broj);
    if (broj < minimum)
    {
        minimum = broj;
    }
    if (broj > maximum)
    {
        maximum = broj;
    }
}

Console.WriteLine("Ispis članova niza: ");
for (int i = 0; i < nizBrojeva.Count; i++)
{
    if ((int)nizBrojeva[i] == minimum)
    {
        Console.WriteLine(maximum);
    }
    else if ((int)nizBrojeva[i] == maximum)
    {
        Console.WriteLine(minimum);
    }
    else
    {
        Console.WriteLine(nizBrojeva[i]);
    }


}









