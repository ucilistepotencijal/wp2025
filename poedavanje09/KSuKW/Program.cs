Console.WriteLine("Odaberi pretvorbu:");
Console.WriteLine("1 - KS u KW");
Console.WriteLine("2 - KW u KS");
Console.Write("Tvoj odabir: ");
int izbor = int.Parse(Console.ReadLine());

Console.Write("Unesi vrijednost: ");
double vrijednost = double.Parse(Console.ReadLine());

pretvori(izbor, vrijednost);

partial class Program
{
    static void pretvori(int izbor, double vrijednost)
    {
        if (izbor == 1)
        {
            // 1 KS = 0.736 KW
            double rezultat = vrijednost * 0.736;
            Console.WriteLine($"{vrijednost} KS = {rezultat:F2} KW");
        }
        else if (izbor == 2)
        {
            // 1 KW = 1.359 KS
            double rezultat = vrijednost * 1.359;
            Console.WriteLine($"{vrijednost} KW = {rezultat:F2} KS");
        }
        else
        {
            Console.WriteLine("Neispravan odabir!");
        }
    }
}
