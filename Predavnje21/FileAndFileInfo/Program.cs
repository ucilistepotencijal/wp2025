//Putanja izvršavanja aplikacije
using System.ComponentModel.Design;

Console.WriteLine(Environment.CurrentDirectory);

string datoteka = Path.Combine(Environment.CurrentDirectory, "da vidimo ovo\\proba.txt");

Console.WriteLine(datoteka);

Console.WriteLine("Ime datoteke: {0}" , Path.GetFileName(datoteka));

Console.WriteLine("Naziv mape u kojoj smještena datoteka: {0}", Path.GetDirectoryName(datoteka));

Console.WriteLine(Path.GetDirectoryName(Environment.CurrentDirectory));

// FIX: Remove the semicolon after the if statement to properly associate the else block
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

    //Lista podmapa u tekućoj mapi
    Console.WriteLine("Podmape(puna putanja): ");
    string[] podmape = Directory.GetDirectories(Environment.CurrentDirectory);
    foreach (string mapa in podmape)
    {
        Console.WriteLine("Putanja do mape je: {0}", mapa);
    }
    //Lista datoteka u tekućem direktoriju
    Console.WriteLine("Datoteke u tekućem direktoriju ( samo imena): ");
    string[] datoteke = Directory.GetFiles(Environment.CurrentDirectory);
    foreach (string d in datoteke)
    {
        Console.WriteLine("Naziv datoteke je: {0}", Path.GetFileName(d));
    }
    Console.WriteLine("drugi način...");
    foreach (string d in datoteke)
    {
        FileInfo fi = new FileInfo(d);

        Console.WriteLine("Naziv datoteke je: {0}", fi.Name);
    }
}
