string recenica = "Danas radimo sa stringovima";
Console.WriteLine(recenica);

//ToLower - vraća nam string ispisan
Console.WriteLine(recenica.ToLower());

//ToUpper - vraća nam string ispisan VELIKIM slovima
Console.WriteLine(recenica.ToUpper());

//Substring()-vraća nam dio stringa
// prvi paramatar je index od kojeg kreće ispis
// drugi parametar je broj znakova koje vraćamo
Console.WriteLine(recenica.Substring(6));
Console.WriteLine(recenica.Substring(0, 5));

// Lenght daje duljinu stringa
Console.WriteLine(recenica.Length);

//Izvlačenje chara s određenim indexom iz stringa
Console.WriteLine(recenica[13]);

//IndexOf()-vraća poziciju znaka u textu -prvi na koji naiđe
Console.WriteLine(recenica.IndexOf(""));
Console.WriteLine(recenica.IndexOf(","));
Console.WriteLine(recenica.IndexOf("!"));

//Last indexOf-vraća pozicju zadnjeg znaka u tekstu
Console.WriteLine(recenica.LastIndexOf(" "));

Console.WriteLine("---------");

//Replace- vraća niz znakova u kojem je string iz prvog parametra zamijenjen stringom iz drugog parametra
Console.WriteLine(recenica.Replace("Danas" ,"Sutra"));
Console.WriteLine(recenica.Replace(" ", " \t"));
Console.WriteLine(recenica.Replace(" "," \n");

Console.WriteLine("__________");

// Split-vraća niz razdvojen po nekom charu
string[]rijeci=recenica.Split(' ');
foreach (var item in rijeci)
{
    Console.WriteLine(item);
}
for (int i = recenica.Length - 1; i >= 0; i--)
{
    Console.Write(recenica[i]);
}



