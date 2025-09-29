double rez = Kvadrat(5);
Console.WriteLine(rez);

int nekiBroj = ucitajCijeliBroj();
Console.WriteLine(nekiBroj);

Console.WriteLine(Kvadrat(ucitajCijeliBroj()));

partial class Program
{
    static double Kvadrat (double broj)
    {
        return broj * broj;    
    }
    static int ucitajCijeliBroj()
    {
        Console.Write("unesi cijeli broj: ");
        int broj = int.Parse(Console.ReadLine());
        return broj;
    }
}

