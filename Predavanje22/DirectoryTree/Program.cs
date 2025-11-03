
Console.Write("Unesi putanju: ");
string putanja = Console.ReadLine();
DohvatiDirektorije(putanja);

partial class Program
{
    static void DohvatiDirektorije(string putanja)
    {
        Console.WriteLine("{0}{1}", new string(' ', DohvatiDubinu(putanja) * 3), Path.GetFileName(putanja));
        string[] direktoriji = Directory.GetDirectories(putanja);
        foreach (string item in direktoriji)
        {
            try
            {
                DohvatiDirektorije(item);
            }
            catch (Exception e)
            {
                Console.WriteLine("Greška: " + e.Message);
            }
        }
    }
    static int DohvatiDubinu(string putanja)
    {
        int dubina = 0;
        foreach (char c in putanja)
        {
            if (c == '\\')
            {
                dubina++;
            }
        }
        return dubina;
    }
}