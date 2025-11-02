//Zadatak 1: Napravi program koji traži unos teksta, a zatim ispisuje taj tekst naopako


using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.Write("Unesi tekst: ");
        string tekst = Console.ReadLine();

        // Pretvaramo string u niz znakova, obrnemo ga i pretvorimo nazad u string
        char[] znakovi = tekst.ToCharArray();
        Array.Reverse(znakovi);
        string naopako = new string(znakovi);

        Console.WriteLine("Tekst naopako: " + naopako);
    }
}
