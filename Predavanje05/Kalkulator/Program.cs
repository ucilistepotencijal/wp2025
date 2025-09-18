/* 
2. Napiši program kojim se izvode osnovne računske operacije. Traži se unos dva broja i unos
računske operacije. Nakon unosa ispisuje se rezultat i omogućuje ponovno računanje ili kraj
programa
*/


double brojA, brojB;
string operacija;

Console.Write("Unesi prvi broj: ");
brojA = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("hr-HR")); //ovo unesemo ako želimo da prepozna "," kao znak decimale (sama guglala)

Console.Write("Unesi drugi broj: ");
brojB = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("hr-HR"));

Console.WriteLine("Unesi računsku operaciju: ");
operacija = Console.ReadLine();

double rezultat = 0;

if (operacija == "+")
{
    rezultat = brojA + brojB;
    Console.WriteLine(rezultat);
}
else if (operacija == "-")
{
    rezultat = brojA - brojB;
    Console.WriteLine(rezultat);
}
else if (operacija == "*")
{
    rezultat = brojA * brojB;
    Console.WriteLine(rezultat);
}
else if (operacija == "/")
{
    rezultat = brojA / brojB;
    Console.WriteLine(rezultat);
}
else
{
    Console.WriteLine("Nepoznata računska operacija!");
}
   