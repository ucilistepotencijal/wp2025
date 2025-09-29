
/*Napiši program koji će u funkciji na temelju unesene prosječne ocjene ispisaƟ poruku o
uspjehu.
Primjer: Za unesenu prosječnu ocjenu 3,4 program ispisuje „Prosjek je dobar“.
*/

decimal broj = 1;
decimal razlika = 1;
Console.Write("Unesi količinu prirodnih brojeva kojoj će se izračunati prosjek: ");
decimal n = decimal.Parse(Console.ReadLine());




for (decimal i = 1; i <= n; i++)
{
    Console.Write("Unesi prirodne brojeve za računanje prosjeka: ");
    broj = decimal.Parse(Console.ReadLine());

    broj += i;

}

razlika = (decimal)broj / n;

Console.WriteLine("Prosjek je {0}!", razlika);
