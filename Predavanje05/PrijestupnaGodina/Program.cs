/*
Napiši program u kojem se za unesenu godinu ispisuje je li ona prijestupna ili nije.
Napomena: Godina je prijestupna ako je djeljiva sa 4, ali nije prijestupna ako je djeljiva sa 100
osim ako je djeljiva sa 400.
*/

Console.Write("godinu: ");
int godina = int.Parse(Console.ReadLine());

if (godina % 4 == 0)
{
    Console.WriteLine("Godina" + godina + " je prijestupna");
}
else if (godina % 100 == 0)
{
   
}