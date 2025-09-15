
Console.OutputEncoding =    System.Text.Encoding.UTF8;
Console.InputEncoding =    System.Text.Encoding.UTF8;   


Console.Write("Unesi korisničko ime: ");
string username = Console.ReadLine();   

if (username =="polaznik")
{
    Console.WriteLine("Dobrodošao polazniče! ");
}
else if (username == "predavač")
{
    Console.WriteLine("Dobrodošao predavaču! ");
}
else
{
    Console.WriteLine("Korisničko ime nije ispravno. ");
}
