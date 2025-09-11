//Kalkulator

//unos podataka
int broj1;
Console.WriteLine("Unesi prvi broj: ");
broj1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Unesi drugi broj: ");
int broj2 = int.Parse(Console.ReadLine());

int zbroj = broj1 + broj2;
int razlika = broj1 - broj2;
int umnozak = broj1 * broj2;
decimal kolicnik = (decimal)broj1 / broj2; //ovo je castanje

//Ako sam unijela brojeve 2 i 3
//Želim da piše 2 + 3 = 5 
//Konkatenacija
Console.WriteLine(broj1 + " + " + broj2 + " = " + zbroj);
Console.WriteLine(broj1 + " - " + broj2 + " = " + razlika);
//Želim da piše 2*3 = 6
Console.WriteLine("{0} * {1} = {2}", broj1, broj2, umnozak);
Console.WriteLine($"{broj1} / {broj2} = {kolicnik}");


