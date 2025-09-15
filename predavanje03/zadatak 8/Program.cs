// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


/*
 Prethodni program napiši tako da inicijaliziraš dva decimalna broja pa umjesto varijabli pa 
int koristiš varijable pa float, double i decimal (pronađi na koji način se zapisuje vrijednost 
decimal tipova varijabli ). Koja je razlika u vrijednosma ispisanim kao rezultat operacije 
dijeljenja
 */

decimal a = 2;
decimal b = 3;

decimal zbroj = a + b;
decimal razlika = a - b;
decimal umnozak = a * b;
decimal djeljenje = a / b;

Console.WriteLine("{0} + {1} = {2}", a, b, zbroj);
Console.WriteLine("{0} - {1} = {2}", a, b, razlika);
Console.WriteLine("{0} * {1} = {2}", a, b, umnozak);
Console.WriteLine("{0} / {1} = {2}", a, b, djeljenje);

double a2 = 2;
double b2 = 3;

double zbroj2 = a2 + b2;
double razlika2 = a2 - b2;
double umnozak2 = a2 * b2;
double djeljenje2 = a2 / b2;

Console.WriteLine("{0} + {1} = {2}", a2, b2, zbroj2);
Console.WriteLine("{0} - {1} = {2}", a2, b2, razlika2);
Console.WriteLine("{0} * {1} = {2}", a2, b2, umnozak2);
Console.WriteLine("{0} / {1} = {2}", a2, b2, djeljenje2);

float a3 = 2;
float b3 = 3;

float zbroj3 = a3 + b3;
float razlika3 = a3 - b3;
float umnozak3 = a3 * b3;
float djeljenje3 = a3 / b3;

Console.WriteLine("{0} + {1} = {2}", a3, b3, zbroj3);
Console.WriteLine("{0} - {1} = {2}", a3, b3, razlika3);
Console.WriteLine("{0} * {1} = {2}", a3, b3, umnozak3);
Console.WriteLine("{0} / {1} = {2}", a3, b3, djeljenje3);