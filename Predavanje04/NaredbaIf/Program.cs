Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

Console.Write("Unesi korisničko ime: "); //stavili smo Write umjesto WriteLine da bi kursor ostao u istom retku
string username = Console.ReadLine(); 

if (username == "polaznik") //dvaput == znači usporedi, a jedan = znači dodijeli
{
    Console.WriteLine("Dobrodošao polazniče!");
}
else if (username == "predavač") //međukorak
{
    Console.WriteLine("Dobrodošao predavaču!");
}
else
{
    Console.WriteLine("Korisnik nije prepoznat.");
}
//Uvijek se izvršava samo jedna grana if naredbe

