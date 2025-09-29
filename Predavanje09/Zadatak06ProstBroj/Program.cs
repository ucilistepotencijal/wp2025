bool bPonovi = true;
while (bPonovi)
{
    try
    {
        Console.Write("Unesi prirodni broj: ");
        int iBroj = int.Parse(Console.ReadLine());
        if (iBroj <= 0)
        {
            throw new Exception("Niste unijeli prirodan broj!");
        }
        string sProstSlozen = Prost(iBroj) ? "prost" : "slozen";
        Console.WriteLine("Broj je {0}", sProstSlozen);

        Console.WriteLine("Želiš li ponovno (D/N)?");
        string unos = Console.ReadLine();
        if (unos.ToLower() == "n")
        {
            bPonovi = false;
        }
    }
    catch (Exception e)
    {

        Console.WriteLine("Dogodila se greška. " + e.Message);
    }


}






partial class Program
{
    static bool Prost(int broj)
    {
        int brojDjelitelja = 0;
        for (int i = 1; i <= broj; i++)
        {
            if (broj % i == 0)
            {
                brojDjelitelja++;
            }
        }
        if (brojDjelitelja == 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}



