//1. Tražiti od korisnika unos broja i spremiti ga u cijelobrojnu varijablu
//2. Ispitati je li broj u segmentu od 100 do 200

Console.Write("Unesi broj: ");
int broj = int.Parse(Console.ReadLine());

if (broj >= 100 && broj <= 200)
{
    Console.WriteLine("Broj " + broj + " je u segmentu od 100 do 200");
}
else
{
    Console.WriteLine("Broj nije u segmentu!");
}
