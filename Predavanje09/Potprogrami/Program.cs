using System.Net.WebSockets;

Hello();
Hello();
Hello();
Kraj();
Pozdrav("Igor");
Pozdrav();
Pozdrav("Franjo", "Balog");
Pozdrav("Pero", 5);

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
    //Prvi overload metode pozdrav
    static void Pozdrav()
    {
        Console.WriteLine("Pozdrav svijetu!");
    }
    //Drugi overload metode pozdrav
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



