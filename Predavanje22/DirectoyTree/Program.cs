using System.Threading.Channels;

Console.Write("Unesi putanju: ");
string Putanja= Console.ReadLine();

partial class Program
{
    static void DohvatiDirektorije(string putanja)
    {
        Console.WriteLine("{0}{1}", new string(' ', DohvatiDubinu(putanja) * 3) Path.GetFileName(putanja));
        string[] direktoriji = Directory.GetDirectories(putanja);
        foreach (string item in direktoriji)
        {
            try
            {
                DohvatiDirektorije(item);
            }


        }