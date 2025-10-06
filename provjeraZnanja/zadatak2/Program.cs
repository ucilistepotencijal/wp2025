
try
{
    List<int> brojevi = new List<int>();
    while (true)
    {
        Console.Write("unesi prirodan broj: ");
        int broj = int.Parse(Console.ReadLine());
        if (broj == 0) break;               
        else if (broj < 0)  //jos se moze napravit exception ako se ne unese nista ali to ne znam jesmo radili pa nisam stavio 
        {
            throw new Exception("broj mora biti prirodan (veći od 0).");
        }
        brojevi.Add(broj);
    }

    if (brojevi.Count > 0)
    {
        Console.WriteLine("min broj: " + brojevi.Min());
        Console.WriteLine("max broj: " + brojevi.Max());
    }
    else
    {
        throw new Exception ("nisi unio niti jedan broj ili je krivi format");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Greška: " + ex.Message);
}