using System.Linq.Expressions;

List<int> lsParni = new List<int>();
List<int> lsNeparni = new List<int>();
int unos = -1;

// Fix: Change while (unos == 0); to while (true) and remove the stray semicolon
while (true)
{
    try
    {
        Console.WriteLine("Unesi prirodni broj:");
        unos = int.Parse(Console.ReadLine());

        if (unos == 0)
        {
            break; // Now inside a valid loop
        }
        if (unos < 0)
        {
            throw new Exception("Potrebno je unijeti prirodni broj");
        }
        if (unos % 2 == 0)
        {
            lsParni.Add(unos);
        }
        else
        {
            lsNeparni.Add(unos);
        }
    }
    // Fix: Correct catch syntax and exception type
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
