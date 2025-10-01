/* 3. Napiši program koji pretvara KS u KW i obrnuto, ovisno o odabiru korisnika.
1 KS = 0,736 KW
1 KW = 1,359 KS */

while (true)
{
	try
	{
		Console.Write("Upiši 'KS' za pretvorbu u 'KW' i obrnuto (ili 0 za izlaz): ");
		string unos = Console.ReadLine();

		if (unos == "0") break;

        if (unos.ToLower() == "ks")
        {
            Console.Write("Unesi vrijednost u KS: ");
            int KS = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} KS = {1} KW", KS, KSuKW(KS));
        }
        else if (unos.ToLower() == "kw")
        {
            Console.Write("Unesi vrijednost u KW: ");
            int KW = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} KW = {1} KS", KW, KWuKS(KW));
        }
        else
        {
            Console.WriteLine("Nepoznat odabir, molim ponovite!");
        }
    }
	catch (Exception)
	{

		Console.WriteLine("Pogrešan unos, molim ponovite!");
	}
}

partial class Program
{
    static int KSuKW(int KS)
    {
        {
            return (int)Math.Round(KS * 0.736, 0); // ako ne roundamo prvo onda će samo odrezati decimale
        }
    }
    static int KWuKS(int KW)
    {
        {
            return (int)Math.Round(KW * 1.359, 0); // ako ne roundamo prvo onda će samo odrezati decimale
        }
    }
}