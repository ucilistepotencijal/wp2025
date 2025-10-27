/*
  Napiši program koji će za unesenu putanju ispisati sve datoteke i sve direktorije u toj mapi.
*/

Console.Write("Unesi putanju: ");
string putanja = Console.ReadLine();

string[] datoteke = Directory.GetFiles(putanja);
string[] direktoriji = Directory.GetDirectories(putanja);

Console.WriteLine("-------------- Popis datoteka s punom putanjom ------------------");
foreach (string d in datoteke)
{
    Console.WriteLine(d);
}

Console.WriteLine("-------------- Popis datoteka ------------------");
foreach (string d in datoteke)
{
    Console.WriteLine(Path.GetFileName(d));
}

Console.WriteLine("-------------- Popis direktorija s punom putanjom ------------------");
foreach (string d in direktoriji)
{
    Console.WriteLine(d);
}

Console.WriteLine("-------------- Popis direktorija ------------------");
foreach (string d in direktoriji)
{
    Console.WriteLine(Path.GetFileName(d));
}