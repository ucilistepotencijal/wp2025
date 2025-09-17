
Console.Write("Unesi bilo koji broj: ");
int broj = int.Parse(Console.ReadLine());

if (broj >= 100 && broj <=200)
{
    Console.WriteLine("Broj " + broj + " je u segmentu [100,200]");
}
else
{
    Console.WriteLine("Broj " + broj + " nije u segmentu [100,200]");
}
