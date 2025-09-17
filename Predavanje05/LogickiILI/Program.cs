// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

Console.Write("Unesi ime: ");
string ime = Console.ReadLine();

if (ime.ToLower() == "igor" || ime.ToUpper() == "HRVOJE")
{
    Console.WriteLine("Dobrodošao nastavniče!");
}
else
{
    Console.WriteLine("Dobrodošao polazniče!");
}
