double rezultat = Kvadrat(5);
Console.WriteLine(rezultat);

int nekiBroj = UcitajCijeliBroj();
Console.WriteLine(nekiBroj);

Console.WriteLine(Kvadrat(UcitajCijeliBroj()));

partial class Program
{
    static double Kvadrat (double broj)
    {
        return broj * broj;
    }
    static int UcitajCijeliBroj()
    {
        Console.Write("Unesi cijeli broj: ");
        int broj = int.Parse(Console.ReadLine());
        return broj;
    }

}