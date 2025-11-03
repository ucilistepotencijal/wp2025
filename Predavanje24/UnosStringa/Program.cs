

/* Napiši program koji traži unos nekog stringa a zatim prema odabiru korisnika (npr.
prema upisanom slovu) izvršava jednu od dolje navedenih metoda. U programu je
potrebno korisniku omogućiti odabir funkcije sve dok ne odabere opciju za kraj, npr. slovo x. 

a) Znakovi i njihova frekvencija
Kreira LINQ upit koji sadrži sve znakove i njihovu frekvenciju i ispisuje ga na konzolu.

b) Riječi napisane velikim slovima
Kreira LINQ upit koji sadrži sve riječi napisane velikim slovima i ispisuje ih na konzolu
*/


List<string> rijeci = new List<string>();
string unos = "";
while (true)
{
    Console.Write("Unesite riječ/rečenicu (x za kraj): ");

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
while (true)
{
    Console.Clear();
    Console.WriteLine("Odaberi jednu od opcija: ");
    Console.WriteLine("a) Znakovi i njihova frekvencija");
    Console.WriteLine("b) Riječi napisane velikim slovom");
    Console.WriteLine("x) Kraj");
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
    public static void ZnakoviFrekvencija(List<string> listaRecenica)
    {
        foreach (var recenica in listaRecenica)
        {
            Console.WriteLine("Frekvencija znakova za riječ/rečenicu {0}:", recenica);
            var frekvencija = from r in recenica
                              group r by r into kvp
                              select kvp;
            foreach (var item in frekvencija)
            {
                Console.WriteLine("Znak {0} se pojavljuje {1} puta.", item.Key, item.Count());
            }
        }

    }
    public static void RijeciVelikimSlovom(List<string> listaRecenica)
    {
        var rijeciVelikimSlovom = listaRecenica.Where(r => r == r.ToUpper());
        Console.WriteLine("Riječi napisane velikim slovom: ");
        foreach (var r in rijeciVelikimSlovom)
        {
            Console.WriteLine(r);
        }
    }
}

