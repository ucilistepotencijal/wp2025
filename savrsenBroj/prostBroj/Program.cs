

bool bPonovi =true;
while (bPonovi)
{
    try
    {
        Console.WriteLine("unesi prirodni broj: ");
        int iBroj = int.Parse(Console.ReadLine());
        if (iBroj <= 0)
        {
            throw new Exception("niste unijeli prirodan broj");
        }
        string sProstSlozen = prost(iBroj) ? "prost" : "slozen";

        Console.WriteLine("broj je {0}", sProstSlozen);

        Console.Write("zelis li ponovo d/n");
        string unos = Console.ReadLine();
        if (unos.ToLower() == "n")
        {
            bPonovi=false;  
        }
    }
    catch (Exception e) 
    {
        Console.WriteLine("dogodila se greska: " + e.Message);
    }

}


partial class Program
{
    static bool prost(int broj)
    {
        int brojDj = 0;
        for (int i = 1; i <= broj; i++)
        {
            if (broj % i == 0)
            {
                brojDj++;
            }
        }
        if(brojDj == 2)
        {
            return true;

        }
        else
        {
            return false;
        }
    }

}