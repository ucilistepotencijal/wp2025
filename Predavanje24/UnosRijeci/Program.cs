List<string> rijeci = new List<string>();
string unos = "";
Console.WriteLine("Unesite riječ/rečenicu (x za kraj");
while (true)
{
    Console.Write("Unesi riječ/rečenicu: ");
    try
    {
        unos = Console.ReadLine();
        if (unos.ToLower() == "x")
        {
            break;
        }
        else
        {
            rijeci.Add(unos);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Pogrešan unos. Greška" + e.Message);
    }

}
while (true)
{
    Console.Clear();
    Console.WriteLine("Odaberi jednu od opcija: ");
    Console.WriteLine("a) Znakovi i njihova frekvencija");
    Console.WriteLine("b) Riječi napisane velikim slovom");
    Console.Write("Vaš odabir: ");
    string opcija = Console.ReadLine();
    switch (opcija)
    {
        case "a":
            ZnakoviFrekvencija(rijeci);
            break;
        case "b":
            RijeciVelikimSlovom(rijeci);
            break;
        case "x":
            Console.WriteLine("Zatvaranje programa");
            break;
        default:
            Console.WriteLine("Nepoznata opcija!");
            break;
    }
    Console.WriteLine("\nPritisni bilo koju tipku za nastavak.");
    Console.ReadKey();
    Console.Clear();
}

void RijeciVelikimSlovom(List<string> rijeci)
{
    throw new NotImplementedException();
}

void ZnakoviFrekvencija(List<string> rijeci)
{
    throw new NotImplementedException();
}