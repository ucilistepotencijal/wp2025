
Console.Write("Unesi prirodan broj: ");
int broj = int.Parse(Console.ReadLine());



int suma = 0;
Console.WriteLine("Djelitelji broja {0} su: ", broj);

for (int i = 1; i < broj; i++)
{
    if (broj % i == 0)
    {
        Console.WriteLine(i);
        
        suma += i;
       
        
    }
    
}

if (broj == suma)
{
    Console.WriteLine("Broj {0} je savršen broj!", broj);
}
else
{
    Console.WriteLine("Broj {0} nije savršen broj!", broj);
}