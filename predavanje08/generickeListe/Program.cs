

using System.Collections;

int[] nekiNiz = new int[2];

ArrayList arrayLista = new ArrayList();
arrayLista.Add(0);
arrayLista.Add("neka rijec");
arrayLista.Add(true);
arrayLista.Add("c");
arrayLista.Add(3.5);
foreach (var element in arrayLista)
{
    Console.WriteLine(element);
}
Console.WriteLine("-------------------");

List<string> stringovi = new List<string>();

stringovi.Add("a");
stringovi.Add("b");
stringovi.Add("c");

foreach (string item in stringovi )
{
    Console.WriteLine(item);
}