
//Deklariraj i inicijaliziraj dva cijela broja Ɵpa int na početku programa i napiši program koji
ispisuje rezultat vrijednosƟ svih matemaƟčkih operacija (+,-,*,/), npr.: „2 + 3 = 5“.



int a = 6;
int b = 4;

int zbroj = a + b;  
int razlika = a - b;
int umnozak = a * b;
int kolicnik = a / b; 
//decimal kolicnik = (decimal)a / b;


Console.WriteLine("{0} + {1} = {2}", a, b, zbroj);
Console.WriteLine("{0} - {1} = {2}", a, b, razlika);
Console.WriteLine("{0} * {1} = {2}", a, b, umnozak);
Console.WriteLine("{0} / {1} = {2}", a, b, kolicnik);
