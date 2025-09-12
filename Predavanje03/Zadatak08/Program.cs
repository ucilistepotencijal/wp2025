// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
decimal broj1 = 5.883543535346346336M;
double broj2 = 1.2336346353465E+308;



decimal zbroj = broj1 + broj2;
decimal razlika = broj1 - broj2;
float umnožak = (float)(broj1 * broj2);
decimal količnik = broj1 / broj2;


Console.WriteLine("{0} + {1} = {2}", broj1, broj2, zbroj);
Console.WriteLine("{0} - {1} = {2}", broj1, broj2, razlika);
Console.WriteLine("{0} * {1} = {2}", broj1, broj2, umnožak);
Console.WriteLine("{0} / {1} = {2}", broj1, broj2, količnik);