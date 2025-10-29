
Console.Write("Unesi putanju: ");
string putanja = Console.ReadLine();

string[] datoteke = Directory.GetFiles(putanja);
string [] direktorij = Directory.GetDirectories(putanja);

Console.WriteLine("----------Popis datoteka sa punom putanjom---------");
foreach (string d in datoteke)
{
    Console.WriteLine(d);
}
Console.WriteLine("-------------Popis datoteka------------");
foreach
