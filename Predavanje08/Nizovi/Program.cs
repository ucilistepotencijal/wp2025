// Nizovi / Arrays

// Deklaracija niza cijelih brojeva koji ima 3 elementa

int[] nizBrojeva = new int[3];

// Inicijalizacija niza

nizBrojeva[0] = 10;
nizBrojeva[1] = 20;
nizBrojeva[2] = 30;

Console.WriteLine(nizBrojeva); 
Console.WriteLine(nizBrojeva[1]);

Console.WriteLine("____________");

for (int i = 0; i < nizBrojeva.Length; i++)
{
    Console.WriteLine(nizBrojeva[i]);
}

Console.WriteLine("______________");

// Deklaracija i inicijalizacija članova iza stringova

string[] nizStringova = new string[] {"prvi", "drugi","treći","četvrti"};

for (int i = 0; i < nizStringova.Length; i++)
{
    Console.WriteLine("Riječ s indeksom {0} je {1}", i, nizStringova[i]);
}