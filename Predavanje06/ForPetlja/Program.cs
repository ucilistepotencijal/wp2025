//1. Ispis teksta na konzolu 10 puta
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("{0}. put prolazim kroz petlju", i);
}
Console.WriteLine();

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("{0}. put prolazim kroz petlju", i);
}
Console.WriteLine();

//2. a) Ispis neparnih brojeva većih od 1, a manjih od 20
for (int i = 3; i < 20; i = i + 2)
{
    Console.WriteLine(i);
}
Console.WriteLine();

//2. b) Ispis neparnih brojeva do 20 sa operatorom modulo (%)
for (int i = 1; i <= 20; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}
Console.WriteLine();

// 3. Ispiši brojeve u intervalu od 1 do 100 koji su djeljivi sa 5
for (int i = 1; i <= 100; i = i++)
{
    if (i % 5 == 0)
    {
        Console.WriteLine(i);
    }
}
Console.WriteLine();