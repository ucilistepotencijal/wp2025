

Console.Write("unesi ime: ");
string ime = Console.ReadLine();

if (ime.ToLower() == "igor" || ime.ToUpper() == "HRVOJE")
{
    Console.WriteLine("dobar dan nastavnice!");
}
else
{
    Console.WriteLine("dobar dan polaznice!");
}