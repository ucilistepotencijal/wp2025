/* 5. Napiši program koji ispisuje sve prijestupne godine od 1900. do 2007. (Godina je prijestupna
ako je djeljiva sa 4 i nije djeljiva sa 100 ili je djeljiva sa 400) */

Console.WriteLine("Sve prijestupne godine od 1900. do 2007. su: ");

List<int> prijestupneGodine = new List<int>();

for (int i = 1900; i <= 2007; i++)
{
    if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
    {
        prijestupneGodine.Add(i);
    }
}

Console.WriteLine(string.Join(", ", prijestupneGodine));