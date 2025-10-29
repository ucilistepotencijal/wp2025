using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string putanja;
        Console.Write("Unesi putanju: ");
        putanja = Console.ReadLine();

        List<string> direktoriji = new List<string>();

        try
        {
            foreach (var entry in Directory.EnumerateDirectories(putanja))
            {
                direktoriji.Add(Path.GetFileName(entry));
            }

            if (direktoriji.Count == 0)
            {
                Console.WriteLine("Nije pronađen nijedan direktorij.");
            }
            else
            {
                // Sort descending (Z → A)
                direktoriji.Sort((a, b) => string.Compare(b, a, StringComparison.Ordinal));

                Console.WriteLine("Prvi direktorij po abecednom redu (silazno): " + direktoriji[0]);
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Greška pri pristupu putanji.");
        }
    }
}
