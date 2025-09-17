Console.Write("Unesi ime: ");
string ime = Console.ReadLine();

if (ime.ToLower() == "igor" || ime.ToUpper() == "HRVOJE")
{
    Console.WriteLine("Dobar dan nastavniče!");
}
else
{
    Console.WriteLine("Dobar dan polazniče!");
}