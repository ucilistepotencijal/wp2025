
//Deklaracija niza cijelih brojeva koji ima 3 elementa
int[] nizBrojeva = new int [3];

//inicijalizacija niza
nizBrojeva[0] = 10; //1. element s indeksom 0
nizBrojeva[1] = 20; //2. element s indeksom 1
nizBrojeva[2] = 30; //3. element s indeksom 2

Console.WriteLine(nizBrojeva); //ne ispisuje cijeli niz, nego ispisuje tip niza
Console.WriteLine(nizBrojeva[1]);

Console.WriteLine("-------------------");

for (int i = 0; 1 < nizBrojeva.Length; i++)
{
    Console.WriteLine(nizBrojeva[i]);
}


//Deklaracija i inicijalizacija članova niza stringova
string[] nizStringova = new string[] { "prvi", "drugi", "treći", "četvrti" };

for  (int i = 0; i < nizStringova.Length; i++)
{
    Console.WriteLine("Riječ s indeksom {0} je {1}", i , nizStringova[1]);
}