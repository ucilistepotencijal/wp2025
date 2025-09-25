double rezultat = Kvadrat(5);
Console.WriteLine(rezultat);

int broj = UcitajCijeliBroj();
Console.WriteLine(broj);

Console.WriteLine(Kvadrat(UcitajCijeliBroj()));
partial class Program
{
    static double Kvadrat(double broj)
    {
        return broj * broj;
    }

    static int UcitajCijeliBroj()
    {
        Console.WriteLine("Unesi cijeli broj: ");
        int broj = int.Parse(Console.ReadLine());
        return broj;
    }
}