List<string> rijeci = new List<string>();
string unos = "";
while (true)
{
    Console.Write("Unesite riječi ('kraj' za kraj): ");

    unos = Console.ReadLine();
    if (unos.ToLower() == "kraj")
    {
        break;
    }
    else
    {
        rijeci.Add(unos);
    }
}
while (true)
{
    Console.Clear();
    Console.WriteLine("Odaberi jednu od opcija: ");
    Console.WriteLine("a) Rijeci koje počinju i završavaju određenim slovima");
    Console.WriteLine("b) Niz stringova konvertira u jedan");
    Console.WriteLine("c) Stringovi minimalne duljine");
    Console.WriteLine("d) Poredaj stringove po duljini pa po imenu");
    Console.WriteLine("e) Poredaj jedinstvene stringove po abecedi");
    Console.WriteLine("x) Kraj");
    Console.Write("Vaš odabir: ");
    string opcija = Console.ReadLine();
    switch (opcija)
    {
        case "a":
            //Domagoj(rijeci);
            break;
        case "b":
            //Franjo(rijeci);
            break;
        case "c":
            Karlo(rijeci);
            break;
        case "d":
            //Meri(rijeci);
            break;
        case "e":
            //Valerio(rijeci);
            break;        
        case "x":
            Console.WriteLine("Zatvaranje programa");
            return;
        default:
            Console.WriteLine("Nepoznata opcija!");
            break;
    }
    Console.WriteLine("\nPritisni bilo koju tipku za nastavak.");
    Console.ReadKey();
    Console.Clear();
}

partial class Program
{
    public static void Karlo(List<string>rijeci)
{
        Console.Write("Unesite minimalnu duljinu: ");
        if (int.TryParse(Console.ReadLine(), out int minDuljina))
        {
            var rezultat = rijeci
                .Where(r => r.Length >= minDuljina)
                .ToList();

            Console.WriteLine("Riječi minimalne duljine {0}:", minDuljina);
            rezultat.ForEach(Console.WriteLine);
        }
        else
        {
            Console.WriteLine("Neispravan unos duljine.");
        }
    }

}








