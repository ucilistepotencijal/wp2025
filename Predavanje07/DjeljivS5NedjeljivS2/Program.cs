/* Napiši program koji će ispisati koliko ima brojeva djeljivih sa 5 a nedjeljivih sa 2 u segmentu
[1, 100]. */

using System.Collections;

List<int> nizBrojeva = new List<int>();

for (int i = 1; i <= 100; i++)
{
    if (i % 5 == 0 && i % 2 != 0)
    nizBrojeva.Add(i);
}

Console.WriteLine($"Broj brojeva djeljivih s 5, a nedjeljivih sa 2 u segmentu [1, 100] je {nizBrojeva.Count}");
