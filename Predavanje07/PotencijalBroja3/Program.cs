

Console.WriteLine("Potencije broja 3: ");
for (int i = 1; i < 1000; i*=3)
{
    Console.Write(i + " ");
}
Console.WriteLine();

//2. način
int potencija = 1;
do
{
    Console.WriteLine(potencija + " ");
    potencija *= 3; // ili potencija = potencija * 3
} while (true);