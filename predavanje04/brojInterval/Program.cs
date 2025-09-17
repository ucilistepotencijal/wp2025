

Console.Write("Unesite cijeli broj: ");
int broj = int.Parse(Console.ReadLine());

if (broj >= 100 && broj <= 200)
{
    Console.WriteLine("Broj " + broj + " je u intervalu [100,200]");
}
else
{
    Console.WriteLine("Broj " + broj + " nije u intervalu [100,200]");
}