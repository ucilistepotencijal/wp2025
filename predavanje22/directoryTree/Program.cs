Console.WriteLine("unesi putanju: ");
string putanja = Console.ReadLine();
DohvatiDitrktorije(putanja);


partial class Program
{
    static void DohvatiDitrktorije(string putanja)
    {
        Console.WriteLine("{0}{1}",DohvatiDubinu(putanja), Path.GetFileName(putanja));
        string[] direktoriji = Directory.GetDirectories(putanja);
        foreach(string item in direktoriji)
        {
            try
            {
                DohvatiDitrktorije(item);
            }
            catch (Exception e)
            {

                Console.WriteLine("greska: "+ e.Message);
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