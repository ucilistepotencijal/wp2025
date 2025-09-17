

Console.Write("unesi korisnicko ime: ");
string username = Console.ReadLine();

Console.Write("unesi lozinku: ");
string password = Console.ReadLine();

if (username.ToLower() == "admin" && password == "admin")
{
    Console.WriteLine("uspjesno logiranje");

}
else
{
    Console.WriteLine("upisao si krive vjerodajnice!");
}
