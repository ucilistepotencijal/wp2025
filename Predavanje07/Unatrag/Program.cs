//Napiši program u kojem se ispisuju svi prirodni brojevi iz intervala [1,n] unatrag.

Console.Write("Unesi prirodan broj: ");
int n = int.Parse(Console.ReadLine());

for (int i = n; i >= 1; i--)
{
    Console.Write(i + " ");
}