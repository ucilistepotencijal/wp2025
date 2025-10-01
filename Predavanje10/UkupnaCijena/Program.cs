/* 8. Napiši program koji traži unos ulazne cijene i tada računa ukupnu cijenu prema sljedećoj
formuli:
Ukupna cijena = Ulazna cijena + marža + Porez + PDV (25%) gdje se Marža i Porez određuju prema sljedećoj tablici:
+------------------+---------+---------------------------+
| Ulazna cijena    | Marža   | Porez                     |
+------------------+---------+---------------------------+
| < 100            | 5,5 kn  | 2% od ulazne cijene       |
| 100 – 250        | 9,5 kn  | 3% od ulazne cijene       |
| 250 – 500        | 15 kn   | 4% od ulazne cijene       |
| 500 – 1000       | 25 kn   | 5% od ulazne cijene       |
| > 1000           | 50 kn   | 10% od ulazne cijene      |
+------------------+---------+---------------------------+
*/


bool bIspravno = false;

while (!bIspravno)
{
    try
    {
        Console.Write("Unesi cijenu u eurima: ");
        double ulaznaCijena = double.Parse(Console.ReadLine());

        if (ulaznaCijena < 0.04)
        {
            throw new Exception("Cijena ne može biti manja od 0");
        }

        double ukupnaCijena = IzracunUkupneCijene(ulaznaCijena);
        Console.WriteLine($"Ukupna cijena je: {ukupnaCijena} kn");

        bIspravno = true;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Greška: " + ex.Message);
    }
}


partial class Program
{
    static double IzracunUkupneCijene(double cijena)
    {
        double marza, porez;

        if (cijena < 100)
        {
            marza = 5.5;
            porez = cijena * 0.02;
        }
        else if (cijena < 250)
        {
            marza = 9.5;
            porez = cijena * 0.03;
        }
        else if (cijena < 500)
        {
            marza = 15;
            porez = cijena * 0.04;
        }
        else if (cijena < 1000)
        {
            marza = 25;
            porez = cijena * 0.05;
        }
        else
        {
            marza = 50;
            porez = cijena * 0.10;
        }
        double cbPDV = cijena + marza + porez;
        double csPDV = cbPDV * 0.25;
        return cbPDV + csPDV;
    }
}



