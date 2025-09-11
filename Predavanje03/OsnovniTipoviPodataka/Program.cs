//byte je brojna varijabla koja može imati vrijednosti od 0 do 255, unsignet znači da ne može biti negativna
byte b = 255;

//sbyte je brojna varijabla koja može imati vrijednosti od -128 do 127, signed znači da može biti negativna
sbyte sb = 127;

//short je brojna varijabla koja može imati vrijednosti od -32.768 do 32.767
short s = 32767;

//ushort je brojna varijabla koja može imati vrijednosti od 0 do 65.535
ushort us = 65535;

//int je brojna varijabla koja može imati vrijednosti od -2.147.483.648 do 2.147.483.647
int i = 2147483647;
Int32 i32 = 2147483647; //isto što i int

//uint je brojna varijabla koja može imati vrijednosti od 0 do 4.294.967.295, unsignet znači da ne može biti negativna
uint ui = 4294967295;

//long je brojna varijabla koja može imati vrijednosti od -9.223.372.036.854.775.808 do 9.223.372.036.854.775.807
//long je isto što i Int64
long l = 9223372036854775807;
Int64 i64 = 9223372036854775807; //isto što i long

//ulong je brojna varijabla koja može imati vrijednosti od 0 do 18.446.744.073.709.551.615, unsignet znači da ne može biti negativna
ulong ul = 18446744073709551615;

//float je brojna varijabla koja može imati vrijednosti od ±1.5 x 10−45 do ±3.4 x 1038, koristi se za pohranu decimalnih brojeva s preciznošću do 7 znamenki
float f = 3.40282347E+38f; //mora imati sufiks f

//double je brojna varijabla koja može imati vrijednosti od ±5.0 × 10−324 do ±1.7 × 10308, koristi se za pohranu decimalnih brojeva s preciznošću do 15-16 znamenki
double d = 1.7976931348623157E+308; //mora imati sufiks d 

//decimal je brojna varijabla koja može imati vrijednosti od ±1.0 x 10−28 do ±7.9 x 1028, koristi se za pohranu decimalnih brojeva s preciznošću do 28-29 znamenki
decimal dec = 79228162514264337593543950335m; //mora imati sufiks m

//char je varijabla koja može imati jednu Unicode znak, koristi se za pohranu pojedinačnih znakova
char c = 'A'; //za razliku od stringa koristi se jednostruki navodnik

string str = "Ovo je neki tekst"; //string je niz znakova, koristi se za pohranu teksta
bool bl = true; //bool je varijabla koja može imati vrijednosti true ili false, koristi se za logičke operacije

//object je osnovni tip podataka iz kojeg nasljeđuju svi ostali tipovi podataka, može pohraniti bilo koju vrstu podataka
object obj = "Ovo je neki tekst u object varijabli";

//var je implicitno tipizirana varijabla, kompajler automatski određuje njen tip na temelju dodijeljene vrijednosti
var v = "Tekst u var varijabli"; //u ovom slučaju v će biti string
var v2 = 5; //u ovom slučaju v2 će biti int

//DateTime je struktura koja predstavlja datum i vrijeme
DateTime dt = DateTime.Now; //trenutni datum i vrijeme

Console.WriteLine();