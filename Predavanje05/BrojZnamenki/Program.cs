/*
Napiši program u kojem se traži unos cijelog broja (može biti i negativan) pa se ispisuje je li
broj jednoznamenkast, dvoznamenkast, troznamenkast ili višeznamenkast.*/

Console.Write("Unesi broj: ");
int broj = int.Parse(Console.ReadLine());

int apsBroj = Math.Abs(broj);

if (apsBroj > 0 && broj < 10)
{
    Console.WriteLine("Broj " + broj + " je jednoznamenkast");
}
else if (apsBroj >= 10 && apsBroj < 100)
{
    Console.WriteLine("Broj " + broj + " je dvoznamenkast");
}else if (apsBroj >= 100 && apsBroj < 1000)
{
    Console.WriteLine("Broj " + broj + " je troznamenkast");
}
else if (apsBroj == 0)
{
    Console.WriteLine("Broj " + broj + " je nula");
}
else
{
    Console.WriteLine("Broj" + broj + "je višeznamenkast");
}