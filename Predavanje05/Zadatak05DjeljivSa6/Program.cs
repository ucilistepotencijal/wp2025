
Console.Write("Upiši bilo koji broj: ");
int broj = int.Parse(Console.ReadLine());

if (broj % 3 == 0 && broj % 2  == 0)
{
    Console.WriteLine("Broj {0} je djeljiv sa 6!", broj);
}
else
{
    Console.WriteLine("Broj {0} nije djeljiv sa 6!", broj);
}




