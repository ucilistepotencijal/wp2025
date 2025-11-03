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
            Domagoj(rijeci);
            break;
        case "b":
            Franjo(rijeci);
            break;
        case "c":
            //Karlo(rijeci);
            break;
        case "d":
            Meri(rijeci);
            break;
        case "e":
            Valerio(rijeci);
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

//Console.WriteLine("d) Poredaj stringove po duljini pa po imenu");
partial class Program
{
    public static void Meri(List<string> rijeci)
    {
        var sortiranje = rijeci.OrderBy(r => r);
        var sortiranje1 = sortiranje.OrderBy(r => r.Length);
        Console.WriteLine("\nRiječi poredane po duljini su:");
        foreach (var item in sortiranje1)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nRiječi poredane po abecedi su:");
        foreach (var item in sortiranje)
        {
            Console.WriteLine(item);
        }

    }

    public static void Valerio(List<string> rijeci)
    {
        Console.WriteLine("Unesite više stringova (odvojene razmakom ili Enterom):");
        string unos = Console.ReadLine();

        string[] dijelovi = unos.Split(new[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

        List<string> jedinstveni = dijelovi
           .Distinct()        
           .OrderBy(s => s)   
           .ToList();
        Console.WriteLine("\nJedinstveni stringovi po abecedi:");
        foreach (string item in jedinstveni)
        {
            Console.WriteLine(item);
        }
    }



    public static void Franjo(List<string> rijeci)
    {
        string niz = string.Join(", ", rijeci);
        Console.WriteLine(niz);
    }
 
}
public static void Domagoj(List<string> rijeci)
{
    Console.Write("unesi pocetno slovo: ");
    string pocetno = Console.ReadLine().ToLower();

    Console.Write("unesi zavrsno slovo: ");
    string zavrsno = Console.ReadLine().ToLower();

    var rezultat = from r in rijeci
                   where r.ToLower().StartsWith(pocetno) && r.ToLower().EndsWith(zavrsno)
                   select r;

    Console.WriteLine("\nrijeci koje počinju s '{0}' i završavaju s '{1}':", pocetno, zavrsno);
    foreach (var rijec in rezultat)
    {
        Console.WriteLine(rijec);
    }
}

