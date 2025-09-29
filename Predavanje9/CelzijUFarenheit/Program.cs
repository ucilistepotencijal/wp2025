/* 4. Napiši program u kojem se stupnjevi Celzijeve ljestvice preračunavaju u stupnjeve
Fahrenheitove.
TF = (9/5)∗TC+32 */

while (true)
{
    try
    {
        Console.WriteLine("Upiši temperaturu u \u00B0C (unesi 0 za izlaz): ");
        decimal TC = decimal.Parse(Console.ReadLine());

        if (TC == 0) break;

        if (TC != 0)
        {
            decimal TF = ((9m / 5m) * TC + 32); //obavezno staviti m! da ne bi uzimao int
            Console.WriteLine("{0}\u00B0C je {1}\u00B0F", TC, TF);
        }
    }
    catch (Exception)
    {

        Console.WriteLine("Pogrešan unos, molim ponovite!");
    }
}