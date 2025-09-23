

using System.Collections;
using System.Net.WebSockets;

ArrayList nizBrojeva = new ArrayList();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("unesi {0}. broj: ",i +1);
    int broj = int.Parse(Console.ReadLine());
    nizBrojeva.Add(broj);
}

nizBrojeva.Add(40);
nizBrojeva.Add(50);

nizBrojeva.Sort();
nizBrojeva.Reverse();

nizBrojeva.Add("a");

Console.WriteLine("ispis clanova niza: ");
for(int i = 0; i< nizBrojeva.Count; i++)
{
    Console.WriteLine(nizBrojeva[i]);
}
