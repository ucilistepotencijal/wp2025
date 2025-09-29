/* 3. Napiši program koji pretvara KS u KW i obrnuto, ovisno o odabiru korisnika.
1 KS = 0,736 KW
1 KW = 1,359 KS */

while (true)
{
	try
	{
		Console.WriteLine("Upiši 'KS' za pretvorbu u 'KW' i obrnuto (ili 0 za izlaz): ");
		string unos = Console.ReadLine();

		if (unos == "0") break;

        if (unos.ToLower() == "ks")
        {
            Console.Write("Unesi vrijednost u KS: ");
            decimal KS = decimal.Parse(Console.ReadLine());
            decimal KW = KS * 0.736m;
            Console.WriteLine("{0} KS = {1} KW", KS, KW);
        }
        else if (unos.ToLower() == "kw")
        {
            Console.Write("Unesi vrijednost u KW: ");
            decimal KW = decimal.Parse(Console.ReadLine());
            decimal KS = KW * 1.359m;
            Console.WriteLine("{0} KS = {1} KW", KW, KS);
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