/* Zadatak 2:Napravi program koji traži unos brojeva od korisnika dok zbroj svih
unesenih brojeva ne premaši 100. Kada se to dogodi, program treba ispisati konačni
zbroj. */

int zbroj = 0; //deklariram izvan petlje da pamti stanje

while (true)
{
    try
    {
        Console.Write("Unesite broj: ");
        int broj = int.Parse(Console.ReadLine());
        zbroj += broj;
       
        if (zbroj > 100)
        {
            Console.Write("Zbroj unesenih brojeva je: " + zbroj);
            break;
        }
    }
    catch (Exception e)
    {

        Console.WriteLine("Ups..dogodila se greška: " + e.Message + "Molimo ponovno unesite broj: ");
        continue;
    }
}