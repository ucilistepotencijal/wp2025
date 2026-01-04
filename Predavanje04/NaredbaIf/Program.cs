Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

Console.Write("Unesi korisničko ime: ");
string username = Console.ReadLine();

if (username == "polaznik")
{
    Console.WriteLine("Dobro došao polazniče!");
}
else if (username == "predavač")
{
    Console.WriteLine("Dobro došao predavaču!");
}
else
{
    Console.WriteLine("Korisnik nije prepoznat.");
}


