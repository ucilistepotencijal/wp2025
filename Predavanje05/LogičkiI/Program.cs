Console.Write("Unesi korisničko ime: ");
string username = Console.ReadLine();

Console.Write("Unesi lozinku: ");
string  password = Console.ReadLine();

if (username.ToLower() == "admin" && password =="admin")
{
    Console.WriteLine("Uspješno logiranje!");
}
else
{
    Console.WriteLine("Upisao si krive vjerodajnice!");
}