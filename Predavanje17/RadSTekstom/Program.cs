string recenica = "Danas radimo sa stringovima";
Console.WriteLine(recenica);

//ToLower() - vraća nam string ispisan malim slovima
Console.WriteLine(recenica.ToLower());

//ToUpper() - vraća nam string ispisan velikim slovima
Console.WriteLine(recenica.ToUpper());

//Substring() - vraća nam dio stringa
//prvi parametar je index od kojeg kreće ispis
//drugi parametar je broj znakova koje vraćamo
Console.WriteLine(recenica.Substring(6));
Console.WriteLine(recenica.Substring(0, 5));

//Length daje  duljinu stringa - to nije metoda nego property
Console.WriteLine(recenica.Length);

//izvlačenje chara s određenim indeksom iz stringa
Console.WriteLine(recenica[13]);

//IndexOf() - vraća poziciju znaka u tekstu - prvog na koji naiđe
Console.WriteLine(recenica.IndexOf(" "));
Console.WriteLine(recenica.IndexOf("."));
Console.WriteLine(recenica.IndexOf("!"));
//LastIndexOf() - vraća poziciju zadnjeg znaka u tekstu
Console.WriteLine(recenica.LastIndexOf(" "));

//Replace() - vraća niz znakova u kojem je string iz prvog parametra zamijenjem stringom iz drugog parametra
Console.WriteLine(recenica.Replace("Danas", "Sutra"));
Console.WriteLine(recenica.Replace(" ", "\t"));
Console.WriteLine(recenica.Replace(" ", "\n"));

//Split() - vrraća niz razdvojen po nekom chau
string[] rijeci = recenica.Split(' ');
foreach (string r in rijeci)
{
    Console.WriteLine(r);
}

for (int i = recenica.Length - 1; i >= 0; i--)
{
    Console.Write(recenica[i]);
}