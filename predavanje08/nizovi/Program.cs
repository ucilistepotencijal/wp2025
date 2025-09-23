

int[] nizBrojeva = new int[3];

nizBrojeva[0] = 10;  
nizBrojeva[1] = 20;
nizBrojeva[2] = 30;

Console.WriteLine(nizBrojeva);
Console.WriteLine(nizBrojeva[1]);

Console.WriteLine("------------------------");

for (int i = 0; i < nizBrojeva.Length; i++)
{
    Console.WriteLine(nizBrojeva[i]);

}

string[] nizStringova = new string[]; {"prvi", "drugi", "treci", "cetvrti" };

for(int i = 0;i < nizStringova.Length;i++)
{
    Console.WriteLine("rijec s indeksom {0} je {1}", i, nizStringova);
}





