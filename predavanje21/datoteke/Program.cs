
using System.Net.Http.Headers;

string datoteka = @"D:\proba.txt";

FileStream fs = new FileStream(datoteka, FileMode.Create);

StreamWriter sw = new StreamWriter(fs);
sw.WriteLine("prva linija teksta");
sw.WriteLine("druga linija teksta");
sw.WriteLine("treca linija teksta");
sw.WriteLine("cetvrta linija teksta");

sw.Flush();
sw.Close();
fs.Close();

FileStream fs2 = new FileStream(datoteka, FileMode.Append);
StreamWriter sw2 = new StreamWriter(fs2);
sw2.WriteLine("nadodani tekst");

sw2.Close();

FileStream fs3 = new FileStream(datoteka, FileMode.Open);
StreamReader sr3 = new StreamReader(fs3);

string sadrzaj  = sr3.ReadToEnd();
sr3.Close();

Console.WriteLine(sadrzaj);


FileStream fs4= new FileStream(datoteka, FileMode.Open);
StreamReader sr4 = new StreamReader(fs4);

while(!sr4.EndOfStream)
{
    string linija = sr4.ReadLine();
    Console.WriteLine(linija +"; ");
}
sr4.Close();