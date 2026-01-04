// Definicija putanje do datoteke
string datoteka = @"D:\proba.txt";

//kreiram novu tekstualnu datoteku
FileStream fs = new FileStream(datoteka, FileMode.Create);

//kreirati kanal prema navedenoj datoteci u sustavu
StreamWriter sw = new StreamWriter(fs);

// upisujem novi sadržaj u datoteku
sw.WriteLine("Prva linija teksta");
sw.WriteLine("Druga linija teksta");
sw.WriteLine("Treća linija teksta");
sw.WriteLine("Četvrta linija teksta");

//eksplicitno pozvati upis svih buffer
sw.Flush();

// zatvaramo Streamwriter objekt
sw.Close();

//Zatvaramo tok bajtova
fs.Close();

FileStream fs2 = new FileStream(datoteka, FileMode.Append);
StreamWriter sw2 = new StreamWriter(fs2);
sw2.WriteLine("Nadodani tekst");

sw2.Close();

//čitanje datoteke u jednu string varijablu

FileStream fs3 = new FileStream(datoteka, FileMode.Open);
StreamReader sr3 = new StreamReader(fs3);

string sadrzaj = sr3.ReadToEnd();
sr3.Close();

//ispis na konzolu
Console.WriteLine(sadrzaj);

//Čitanje datoteke liniju po liniju
FileStream fs4 = new FileStream(datoteka, FileMode.Open);
StreamReader sr4 = new StreamReader(fs4);

while (!sr4.EndOfStream)
{
    string linija = sr4.ReadLine();
    Console.WriteLine(linija + "; ");
}
sr4.Close();