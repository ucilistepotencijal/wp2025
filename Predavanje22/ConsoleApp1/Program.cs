
/*
Napiši program koji će za unesenu putanju ispisati sve direktorije koje ta putanja sadrži te koliko
svaki direktorij sadrži datoteka a koliko poddirektorija
*/

Console.Write("Unesi putanju: ");
string putanja = Console.ReadLine();
if (!string.IsNullOrEmpty(putanja) && Directory.Exists(putanja))
{
    string[] direktoriji = Directory.GetDirectories(putanja);
    foreach (string d in direktoriji)
    {
        try
        {
            Console.WriteLine("Direktorij: {0}, broj datoteka: {1}, broj poddirektorija: {2}",
                Path.GetFileName(d), Directory.GetFiles(d).GetLength(0), Directory.GetDirectories(d).Length);
        }
        catch (Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Greška: " + e.Message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}