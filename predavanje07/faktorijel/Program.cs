Console.Write("Unesi broj kojem želiš izračunati faktorijel: ");

int broj = int.Parse(Console.ReadLine());

ulong faktorijel = 1;

for (int i = 1; i <= broj; i++)

    faktorijel *= (ulong)i; // isto; faktorijel = faktorijel * i;

Console.WriteLine("Faktorijel broja {0} je {1}", broj, faktorijel);