
//Nizovi
using System.Collections;

int[] nekiNiz = new int[2];

//Arraylist
ArrayList arrayList = new ArrayList();
arrayList.Add(0);
arrayList.Add("neka riječ");
arrayList.Add(true);
arrayList.Add("c");
arrayList.Add(3.5);
foreach (var element in arrayList)
{
    Console.WriteLine(element);
}

Console.WriteLine("-------------------------------------");


//Generička lista
List<string> stringovi = new List<string>();

stringovi.Add("a");
stringovi.Add("b");
stringovi.Add("c");

foreach(string item in stringovi)
{
    Console.WriteLine(item);
}
