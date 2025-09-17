//1. Tražiti od korisnika unos broja i spremiti ga u cjelobrojnu varijablu.

//2. Ispitati je li broj u intervalu od 100 do 200
// [100,200] npr. 100 jest, 99 nije, 150 jest, 200 jest, 201 nije
// 100 <= x <= 200
// "Broj 105 je u intervalu [100,200]" ili "Broj 5 nije u intervalu [100,200]"

// I je isto kao množenje
// ILI je isto kao zbrajanje


Console.Write("Unesi broj: ");
int broj = int.Parse(Console.ReadLine());

if (broj >= 100 && broj <= 200)
{
    Console.WriteLine("Broj " + broj + " je u intervalu [100,200]");
}
else
{
    Console.WriteLine("Broj " + broj + " nije u intervalu [100,200]");
}







