string datoteka = @"D:\Parni.txt";


FileStream fs = new FileStream(datoteka, FileMode.Create);
StreamWriter sw = new StreamWriter(fs);

for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
        sw.WriteLine(i);
}

sw.Flush();
sw.Close();
fs.Close();

FileStream fs2 = new FileStream(datoteka, FileMode.Open);
StreamReader sr = new StreamReader(fs2);

string sadrzaj = sr.ReadToEnd();
sr.Close();
fs2.Close();

Console.WriteLine("sadrzaj datoteke Parni.txt:\n");
Console.WriteLine(sadrzaj);
    