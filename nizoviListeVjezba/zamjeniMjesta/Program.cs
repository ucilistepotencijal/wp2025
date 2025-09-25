int[] brojevi = new int[10];
for (int i = 0; i < 10; i++)
{
    Console.Write($"Unesi broj {i + 1}: ");
    brojevi[i] = int.Parse(Console.ReadLine());
}

int maxIndex = Array.IndexOf(brojevi, brojevi.Max());
int minIndex = Array.IndexOf(brojevi, brojevi.Min());

// zamjena
int temp = brojevi[maxIndex];
brojevi[maxIndex] = brojevi[minIndex];
brojevi[minIndex] = temp;

Console.WriteLine("Rezultat nakon zamjene:");
foreach (var b in brojevi)
    Console.Write(b + " ");
        