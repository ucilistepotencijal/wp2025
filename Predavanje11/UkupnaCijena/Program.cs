//Napiši program koji traži unos ulazne cijene i tada računa ukupnu cijenu prema sljedećoj
//formuli:
//Ukupna cijena = Ulazna cijena + marža + Porez + PDV(25 %)

bool unosJeIspravan = false;
double ulaznaCijena = -1;

while (!unosJeIspravan)
{
	try
	{
		Console.Write("Unesi ulaznu cijenu u EUR: ");
		ulaznaCijena = double.Parse(Console.ReadLine());
		Console.WriteLine("Unijeli ste cijenu: " + ulaznaCijena + " EUR");
		if (ulaznaCijena < 0.04)
		{
			throw new Exception("Cijena mora biti veća ili jednaka 0.04 EUR");
		}
		unosJeIspravan = true;
	}
	catch (Exception e)
	{
		Console.WriteLine("Dogodila se greška: " + e.Message);
	}
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
double ukupnaCijena = ulaznaCijena + marza + porez; // + PDV?
ukupnaCijena = ukupnaCijena * 1.25; // PDV = ukupnaCijena * 0.25 => ukupnaCijena = ukupnaCIjena + PDV 
Console.WriteLine("Ukupna cijena: " + Math.Round(ukupnaCijena, 2));