
Hello();
Hello();
Hello();
Hello();
Hello();
Kraj();
poz("domagoj");
poz();
poz("domagoj", "plecic");
poz("pero", 5);
Console.WriteLine("kraj");

partial class Program
{
    static void Hello()
    {
        Console.WriteLine("zivjeli potprogrami");
    }

    static void Kraj()
    {
        Console.WriteLine("pritisnite bilo koju tipku za kraj..");
        Console.ReadKey();
        Console.WriteLine();
    }
    static void poz(string ime)
    {
        Console.WriteLine("dobro vece, {0}",ime);
    }
    static void poz()
    {
        Console.WriteLine("poz svijetu ");
    }

    static void poz(string ime, string prezime)
    {
        Console.WriteLine("dobro vece, {0} {1}",ime , prezime);
    }
    static void poz(string ime, int broj)
    {
        for (int i = 0; i < broj; i++)
        {
            poz(ime);
        }
    }

}
