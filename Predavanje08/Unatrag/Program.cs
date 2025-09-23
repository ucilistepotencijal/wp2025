/* Napiši program u kojem se traži unos 10 elemenata i koji se spremaju u objekt ArrayList, a
zatim se ispisuju unatrag. */

using System.Collections; //dodan je namespace System.Collections

ArrayList nizElemenata = new ArrayList(10);

for (int i = 0; i < 10 ; i++)
{
    Console.Write("Unesi {0}. element: ", i + 1);
    string unos = Console.ReadLine();
    nizElemenata.Add(unos);
}

nizElemenata.Reverse();

Console.WriteLine("Ispis unatrag: ");
foreach (string element in nizElemenata)
{

    Console.WriteLine(element);
}
