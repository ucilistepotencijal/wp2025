List<int> brojevi = new List<int>();
int broj = -1;
Console.WriteLine("Unesite brojeve (0 za kraj) ");
while (true)
{
    Console.Write("Unesi broj: ");
    try
    {
        broj = int.Parse(Console.ReadLine());
        if (broj == 0)
        {
            break;
        }
        else
        {
            brojevi.Add(broj);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Pogrešan unos. Greška" + e.Message);
    }

}
Console.Clear();
Console.WriteLine("Odaberi jednu od opcija: ");
Console.WriteLine("a) Brojevi iz intervala[1,11]");
Console.WriteLine("b) Brojevi i njihovi kvadrati");
Console.WriteLine("c) Brojevi i njihova frekvencija");
Console.WriteLine("d) brojevi veći od 80");
Console.WriteLine("e) Tri najveća broja");
Console.Write("Vaš odabir: ");
string opcija = Console.ReadLine();
switch (opcija)
{
    case "a":
        IntervalBrojevi(brojevi);
        break;
    case "b":
        BrojeviKvadrati(brojevi);
        break;
    case "c":
        BrojeviFrekvencija(brojevi);
        break;
    case "d":
        BrojeviVeciOd80(brojevi);
        break;
    case "e":
        TriNajvecaBroja(brojevi);
        break;
    default:
        Console.WriteLine("Nepoznata opcija!");
        break;
}

partial class Program
{
    public static void IntervalBrojevi(List<int> brojevi)
    {
        List<int> intervalBrojevi = brojevi.Where(b => b >= 1 && b <= 11).ToList();
        for (int i = 0; i < intervalBrojevi.Count(); i++)
        {
            if (i == 0)
            {
                Console.Write(intervalBrojevi[i]);
            }
            else
            {
                Console.Write(", " + intervalBrojevi[i]);
            }
        }
        Console.WriteLine();
    }
    public static void BrojeviKvadrati(List<int> brojevi)
    {
        var brojKvadrat = from b in brojevi let brKv = b * b where brKv > 20 select new { b, brKv };
        foreach (var item in brojKvadrat)
        {
            Console.WriteLine(item);
        }
    }
    public static void BrojeviFrekvencija(List<int> brojevi)
    {
        var brojFrekvencija = from b in brojevi group b by b into c select c;
        foreach (var item in brojFrekvencija)
        {
            Console.WriteLine("Broj " + item.Key + " se pojavljuje " + item.Count() + " puta.");
        }
    }
    public static void BrojeviVeciOd80(List<int> brojevi)
    {
        var brojeviVeciOd80 = brojevi.FindAll(x => x > 80);
        Console.WriteLine("Brojevi veći od 80: ");
        foreach (int item in brojeviVeciOd80)
        {

            Console.WriteLine(item);
        }
    }
    public static void TriNajvecaBroja(List<int> brojevi)
    {
        brojevi.Sort();
        brojevi.Reverse();
        var triNajvecaBroja = brojevi.Take(3);
        Console.WriteLine("Tri najveća broja: ");
        foreach (int item in triNajvecaBroja)
        {
            Console.WriteLine(item);
        }
    }
}