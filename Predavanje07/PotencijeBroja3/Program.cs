// Napiši program u kojem se ispisuju sve potencije broja 3 manje od 1000.

Console.WriteLine("Potencije broja 3: ");
for (int i = 1; i < 1000; i*=3)
{
    Console.Write(i + ", ");
}
Console.WriteLine();

// bez zareza
for (int i = 1; i < 1000; i *= 3)
{
    if (i * 3 < 1000)
        Console.Write(i + ", ");
    else
        Console.Write(i); // zadnja potencija bez zareza
}

//2. način
int potencija = 1;
do
{
    Console.Write(potencija + " ");
    potencija *= 3; // ili: potencija = potencija *3
} while (potencija < 1000);