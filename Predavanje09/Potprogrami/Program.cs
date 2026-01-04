Hello();
Hello();
Hello();
Hello();
Kraj();
Pozdrav("Igor");
Pozdrav();
Pozdrav("Igor", "Jakopiček");
Pozdrav("Pero", 5);
Console.WriteLine("------------- kraj  -----------------");

partial class Program
{
    static void Hello()
    {
        Console.WriteLine("Živjeli potprogrami!");
    }
    static void Kraj()
    {
        Console.WriteLine("Pritisnite bilo koju tipku za kraj...");
        Console.ReadKey();
        Console.WriteLine();
    }
    static void Pozdrav(string ime)
    {
        Console.WriteLine("Dobro jutro, {0}!", ime);
    }

    //prvi overload metode pozdrav
    static void Pozdrav()
    {
        Console.WriteLine("Pozdrav svijetu!");
    }

    //drugi overload metode pozdrav - prima 2 string parametra
    static void Pozdrav(string ime, string prezime)
    {
        Console.WriteLine("Dobro veče, {0} {1}!", ime, prezime);
    }
    static void Pozdrav(string ime, int broj)
    {
        for (int i = 0; i < broj; i++)
        {
            Pozdrav(ime);
        }
    }
}