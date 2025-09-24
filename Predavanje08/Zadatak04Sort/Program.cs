

using System;
using System.Collections;

ArrayList nizElemenata = new ArrayList();




foreach (int broj in nizElemenata)
{

    
    if (broj == 0)
        Console.WriteLine(nizElemenata[broj]);
}

try
{
    Console.Write("Unesi {0}. broj: ", i);
    int broj = int.Parse(Console.ReadLine());
    nizElemenata.Add(broj);

    if (broj == 0)
    {
        break;
    }



}
catch (Exception)
{

	throw;
}













