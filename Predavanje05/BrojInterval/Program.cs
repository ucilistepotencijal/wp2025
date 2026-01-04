// 1. Tražiti od korisnika unos broja i spremiti ga u cjelobrojnu varijablu

// 2. Ispitati je li broj u segmentu od 100 do 200
// [100,200] npr. 100 jest, 99 nije, 150 jest, 200 jest, 201 nije
// 100 <= x <= 200
// "Broj 105 je u segmentu [100,200]" ili "Broj 5 nije u segmentu [100,200]"

// I je isto kao množenje
// ILI je isto kao zbrajanje

// A, B, C
// A && B && C => A * B * C
// true = 1; false = 0
//Za AND vrijedi da svi moraju  biti istiniti


// A || B || C => A + B + C
// true = 1; false = 0
// 0 + 1 = 1
// 1 + 1 = 1
// 1 + 1 + 1 = 1
// Za OR vrijedi da samo jedan mora biti istinit


Console.Write("Unesi broj: ");
int broj = int.Parse(Console.ReadLine());

if (broj >= 100 && broj <= 200)
{
    Console.WriteLine("Broj " + broj + " je u segmentu [100,200]!");
}
else
{
    Console.WriteLine("Broj " + broj + " nije u segmentu [100,200]!");
}
