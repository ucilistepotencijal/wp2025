

Console.WriteLine("potencije broja 3: ");

for (int i = 1; i < 1000; i*= 3)
{
    Console.WriteLine(i);
}
Console.WriteLine();

int potencija = 1;
do
{
    Console.Write(potencija + " ");
    potencija *= 3;
}while(potencija < 1000);