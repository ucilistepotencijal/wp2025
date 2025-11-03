

//Putanja izvršavanja aplikacije
Console.WriteLine(Environment.CurrentDirectory);

string datoteka = Path.Combine(Environment.CurrentDirectory, "proba.txt");

Console.WriteLine(datoteka);

Console.WriteLine("Ime datoteke: {0}", Path.GetFileName(datoteka));

Console.WriteLine("Naziv mape u kojoj je smještena datoteka: {0}", Path.GetDirectoryName(datoteka));

Console.WriteLine(Path.GetDirectoryName(Environment.CurrentDirectory));

if (File.Exists(datoteka))
{
    Console.WriteLine("Datoteka postoji!");
}
else
{
    Console.WriteLine("Datoteka ne postoji!");
    StreamWriter sw = File.CreateText(datoteka);
    sw.WriteLine("Ovaj tekst kreirali smo kroz kod...");
    sw.Close();
}

//Lista podmapa u tekućoj mapi
Console.WriteLine("Podmape(puna putanja) :");
string[] podmape = Directory.GetDirectories(Environment.CurrentDirectory);
foreach (string mapa in podmape)
{
    Console.WriteLine("Putanja do mape: {0}", mapa);
}

//Lista datoteka u tekućem direktoriju
Console.WriteLine("Datoteke u tekućem direktoriju (samo imena): ");
string[] datoteke = Directory.GetFiles(Environment.CurrentDirectory);
foreach (string d in datoteke)
{
    Console.WriteLine("Naziv datoteke je: {0}", Path.GetFileName(d));
}
Console.WriteLine("drugi način ...");
foreach (string d in datoteke)
{
    FileInfo fi = new FileInfo(d);
    Console.WriteLine("Naziv datoteke je: {0}", fi.Name);
}
