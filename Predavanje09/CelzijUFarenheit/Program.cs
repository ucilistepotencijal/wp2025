/* 4. Napiši program u kojem se stupnjevi Celzijeve ljestvice preračunavaju u stupnjeve
Fahrenheitove.
TF = (9/5)∗TC+32 */

while (true)
{
    try
    {
        Console.Write("Upiši temperaturu u \u00B0C (unesi 0 za izlaz): ");
        decimal TC = decimal.Parse(Console.ReadLine());

        if (TC == 0) break;

        if (TC != 0)
        {
            Console.WriteLine("{0}\u00B0C je {1}\u00B0F", TC, CelzijFahrenheit(TC));
        }
    }
    catch (Exception)
    {

        Console.WriteLine("Pogrešan unos, molim ponovite!");
    }
}

partial class Program
{
    static decimal CelzijFahrenheit(decimal TC)
    {
        return ((9m / 5m) * TC + 32);
    }
}