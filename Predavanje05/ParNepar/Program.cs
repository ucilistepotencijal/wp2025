Console.Write("Unesi broj: ");
int broj = int.Parse(Console.ReadLine());

// trebam provjeriti je li broj djeljiv s 2
// operator koji daje ostatak pri dijeljenju je modulo (%)

//Ako je broj djeljiv sa 2 -> ispis "Broj je paran!"
if (broj % 2 == 0)
{
    Console.WriteLine("Broj je paran!");
}
else
{
    Console.WriteLine("Broj je neparan!");
}

//2. način - isti rezultat ispisa na konzolu
if (broj % 2 != 0)
{
    Console.WriteLine("Broj je neparan!");
}
else
{
    Console.WriteLine("Broj je paran!");
}