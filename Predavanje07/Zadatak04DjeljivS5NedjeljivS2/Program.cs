int brojac = 0;

for (int i = 1; i <= 100; i++)
{
    if (i % 5 == 0 && i % 2 != 0)
    {
        brojac++;
    }

   
}
Console.WriteLine("U intervalu [1,100] je {0} brojeva djeljivih s 5, a nedjeljivih sa 2!", brojac);