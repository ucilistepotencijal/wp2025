﻿

Console.Write("Unesi broj: ");
int broj = int.Parse(Console.ReadLine());

if (broj % 2 == 0)
{
    Console.WriteLine("Broj je paran!");
}
else
{
    Console.WriteLine("Broj je neparan!");
}

//2.način - isti rezultat ispisa na konzolu
if (broj % 2 != 0)
{
    Console.WriteLine("Broj je neparan!");
}
else
{
    Console.WriteLine("Broj je paran!");
}

