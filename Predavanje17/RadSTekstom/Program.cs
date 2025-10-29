using Microsoft.CSharp.RuntimeBinder;

string recenica = "Danas radimo sa stringovima.";
Console.WriteLine(recenica);

//ToLower() - vraća nam string ispisan malim slovima
Console.WriteLine(recenica.ToLower());

//ToUpper() - vraća nam string ispisan VELIKIM SLOVIMA  
Console.WriteLine(recenica.ToUpper());

//Substring() - vraća nam dio stringa
// prvi parametar je indeks od kojeg kreće ispis
// drugi parametar je broj znakova koje vraćamo
Console.WriteLine(recenica.Substring(6));
Console.WriteLine(recenica.Substring(0, 5));

// Length daje duljinu stringa
Console.WriteLine(recenica.Length);

//izvlačenje chara s određenim indeksom iz string
Console.WriteLine(recenica[13]);

//IndexOf() - vraća poziciju znaka u tekstu - prvog na koji naiđe
Console.WriteLine(recenica.IndexOf(" "));
Console.WriteLine(recenica.IndexOf("."));
Console.WriteLine(recenica.IndexOf("!"));
//LastIndexOf() - vraća poziciju zadnjeg znaka u tekstu
Console.WriteLine(recenica.LastIndexOf(" "));

Console.WriteLine("-----------------");
//Replace() - vraća niz znakova u kojem je string iz prvog parametra zamijenjen stringom iz drugog parametra
Console.WriteLine(recenica.Replace("Danas", "Sutra"));
Console.WriteLine(recenica.Replace(" ", "\t"));
Console.WriteLine(recenica.Replace(" ", "\n"));

Console.WriteLine("------------------");

//Split() - vraća niz razdvojen po nekom charu
string[] rijeci = recenica.Split(' ');
foreach (var item in rijeci)
{
    Console.WriteLine(item);
}

for (int i = recenica.Length - 1; i >= 0; i--)
{
    Console.Write(recenica[i]);
}