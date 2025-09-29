//Napiši program u kojem se ispisuju sve potencije broja 3 manje od 1000.

Console.WriteLine("Potencija broja 3: ");
for (int i = 1; i < 1000; i*=3)
{
    Console.Write(i + " ");
}

Console.WriteLine();

//2. način

int potencija = 1;
do
{
    Console.Write(potencija + " ");
    potencija *= 3;    //ili potencija = potencija * 3 
} while (potencija < 1000);


