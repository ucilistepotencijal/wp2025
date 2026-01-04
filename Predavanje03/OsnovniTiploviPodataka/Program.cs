// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//byte je brojevna varijabla koja može sadržavati vrijednosti od 0 do 255
byte b = 255;

//sbyte može sadržavati vrijednosti od -128 do 127
sbyte sb = -128;

//short može sadržavati vrijednosti od -32,768 do 32,767
short s = -32768;

//ushort može sadržavati vrijednosti od 0 do 65,535
ushort us = 65535;

//int može sadržavati vrijednosti od -2,147,483,648 do 2,147,483,647
int i = -2147483648;
Int32 i2 = 2147483647;

//uint može sadržavati vrijednosti od 0 do 4,294,967,295
uint ui = 4294967295;

//long može sadržavati vrijednosti od -9,223,372,036,854,775,808 do 9,223,372,036,854,775,807
long l = -9223372036854775808;
Int64 l2 = 9223372036854775807;

//ulong može sadržavati vrijednosti od 0 do 18,446,744,073,709,551,615
ulong ul = 18446744073709551615;

//float može sadržavati vrijednosti od ±1.5 x 10^−45 do ±3.4 x 10^38 s preciznošću od 7 znamenaka
float f = 3.40282347E+38F;

//double može sadržavati vrijednosti od ±5.0 × 10^−324 do ±1.7 × 10^308 s preciznošću od 15-16 znamenaka
double d = 1.79769313486231E+308;

//decimal može sadržavati vrijednosti od ±1.0 x 10^-28 do ±7.9 x 10^28 s preciznošću od 28-29 znamenaka
decimal dec = 79228162514264337593543950335M;

//char može sadržavati jedan Unicode znak
char c = 'A'; // za razliku od stringa koji može sadržavati više znakova, char može sadržavati samo jedan znak
//string se piše sa 2 navodnika, a char sa jednim

//string može sadržavati niz znakova
string str = "Ovo je string varijabla";

//bool može sadržavati vrijednosti true ili false
bool bo = true;

//object može sadržavati bilo koju vrijednost
object o = "Ovo je object varijabla";

//var je implicitno tipizirana varijabla, što znači da kompajler automatski određuje njen tip na osnovu dodijeljene vrijednosti
var v = "Ovo je var varijabla";
var v2 = 5; //ovdje će kompajler zaključiti da je v2 tipa int

//DateTime može sadržavati datum i vrijeme
DateTime dt = DateTime.Now;

Console.WriteLine();





