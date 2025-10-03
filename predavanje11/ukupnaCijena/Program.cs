
bool unosJeIspravan = false;
double ulaznaCijena = -1;

while (true)
{
	try
	{
		Console.Write("unesi ulaznu cijenu: ");
		ulaznaCijena = double.Parse(Console.ReadLine());
        Console.WriteLine("unijeli ste cijenu: "+ ulaznaCijena + "eur");
		if (ulaznaCijena < 0.04 )
		{
			throw new Exception("mora biti veca od 0.04e");
		}
		unosJeIspravan = true;
	}
	catch (Exception e)
	{

        Console.WriteLine("greska" + e.Message);
	}
    double marza = -1;
    double porez = -1;

    if (ulaznaCijena <= 100)
    {
        marza = 5.5;
        porez = ulaznaCijena * 0.02;

    }
    else if (ulaznaCijena <= 250)
    {
        marza = 9.5;
        porez = ulaznaCijena * 0.03;
    }
    else if (ulaznaCijena <= 500)
    {
        marza = 15;
        porez = ulaznaCijena * 0.04;
    }
    else if (ulaznaCijena <= 1000)
    {
        marza = 25;
        porez = ulaznaCijena * 0.05;
    }
    else
    {
        marza = 50;
        porez = ulaznaCijena * 0.10;
    }
    double ukupnaCijena = ulaznaCijena + marza + porez;
    ukupnaCijena = ukupnaCijena * 1.25;
    Console.WriteLine("ukupna cijena: " + Math.Round( ukupnaCijena,2));
}
