

while(true)
{
    Console.Write("unesi ime: ");
    string ime = Console.ReadLine();
    
    if (ime.ToLower() != "kraj")
    {
        break;
    }
    Console.WriteLine("dobar dan, {0}", ime);
    

}
Console.WriteLine();
string ime2 = "";

bool ponovi = true;

while (ponovi)
{
    Console.Write("unesi ime: ");
    ime2 = Console.ReadLine();

   if (ime2.ToLower() != "kraj")
    {
        ponovi = false; 
    }
   
    Console.WriteLine("dobar dan, {0}", ime2);
}
Console.WriteLine();

