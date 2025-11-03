
/*Napiši program koji računa udaljenost između dvije točke P(x,y) i R(z,k).
d=√( x−z)2 +( y −k )2
Napomena: NapraviƟ posebnu metodu za unos koordinate točke i pozvaƟ ju dva puta unutar
glavne metode za svaku od točaka.
*/



using System;

while (true)
{
    try
    {
        var P = UnesiTocku("P");
        var R = UnesiTocku("R");

        if (P.x == 0 || P.y == 0 || R.x == 0 || R.y == 0)
        {
            Console.WriteLine("Unos ne može biti 0!");
            return;
        }

        double d = Math.Sqrt(Math.Pow(P.x - R.x, 2) + Math.Pow(P.y - R.y, 2));
        Console.WriteLine("Udaljenost između točaka: " + d);
    }
    catch (Exception)
    {
        Console.WriteLine("Pogrešan unos, molim ponovite!");
    }
}

partial class Program
{
    static (double x, double y) UnesiTocku(string tocka)
    {
        Console.WriteLine($"Unesite koordinate točke {tocka}:");
        Console.Write("Prva koordinata: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Druga koordinata: ");
        double y = double.Parse(Console.ReadLine());
        return (x, y);
    }
}


