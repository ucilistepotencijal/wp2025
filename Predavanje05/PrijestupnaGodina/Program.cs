/*
6. Napiši program u kojem se za unesenu godinu ispisuje je li ona prijestupna ili nije.
Napomena: Godina je prijestupna ako je djeljiva sa 4, ali nije prijestupna ako je djeljiva sa 100
osim ako je djeljiva sa 400.
*/

Console.Write("Unesi godinu: ");
int godina = int.Parse(Console.ReadLine());

if (godina % 400 == 0 || (godina % 4 == 0 && godina % 100 != 0))
{
    Console.WriteLine("Godina " + godina + " je prijestupna");
}
else
{
    Console.WriteLine("Godina " + godina + " nije prijestupna");
}