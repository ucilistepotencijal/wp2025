// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

Console.Write("unesi korisnicko ime: ");
string username = Console.ReadLine();

if (username == "polaznik") 
{
    Console.WriteLine("dobro došao polazniče");
}
else if (username == "predavač")
{
    Console.WriteLine("dobro došao predavaču ");
}
else
{
    Console.WriteLine("korisnik nije prepoznat");
}
