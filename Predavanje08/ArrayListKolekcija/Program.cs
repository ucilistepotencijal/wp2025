using System.Collections; //dodan je namespace System.Collections

ArrayList nizBrojeva = new ArrayList();

//unos brojeva
for (int i = 0; i < 3; i++)
{
    Console.Write("Unesi {0}. broj: ", i + 1);
    int broj = int.Parse(Console.ReadLine());
    nizBrojeva.Add(broj);
}

nizBrojeva.Add(40);
nizBrojeva.Add(50);

nizBrojeva.Sort();
nizBrojeva.Reverse();

nizBrojeva.Add("a");

Console.WriteLine("Ispis članova niza: ");
for (int i = 0; i < nizBrojeva.Count; i++)
{
    Console.WriteLine(nizBrojeva[i]);
}

