// See https://aka.ms/new-console-template for more information
Console.Write("Unesi korisničko ime: ");
string username = Console.ReadLine();

Console.Write("Unesi lozinku: ");
string password = Console.ReadLine();

if (username.ToLower() == "admin" && password == "admin")
{
    Console.WriteLine("Logiranje uspješno!");
}
else
{
    Console.WriteLine("Upisali ste krive vjerodajnice!");
}