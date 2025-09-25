

using System.Collections;

ArrayList lista = new ArrayList();

for (int i = 0; i < 10; i++)
{
    Console.Write("unesi broj {0}: ", i);
    lista.Add(Console.ReadLine());
}

Console.WriteLine("ispis unatrag:");

for (int i = lista.Count - 1; i >= 0; i--)
    Console.WriteLine(lista[i] + " ");