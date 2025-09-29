/* 13. Napiši program koji traži unos prirodnih brojeva dok se ne unese 0, a zaƟm ispisuje koliko je
bilo parnih, a koliko neparnih brojeva. */

int broj;
int parni = 0;
int neparni = 0;

Console.WriteLine("Unosi prirodne brojeve (unesi 0 za izlaz): ");

do
{
    broj = int.Parse(Console.ReadLine());

    if (broj == 0)
        break;

    if (broj % 2 == 0)
        parni++;
    else
        neparni++;

} while (true);

Console.WriteLine("Broj parnih brojeva: {0}", parni);
Console.WriteLine("Broj neparnih brojeva: {0}", neparni);

