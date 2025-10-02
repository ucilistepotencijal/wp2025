/* Zadatak 5: Napravi program koji traži unos riječi sve dok se ne unese riječ "kraj".
Program prevodi upisanu riječ u telefonski broj prema mapiranju standardne
tipkovnice navedene u nastavku te ispisuje telefonski broj na konzolu.

 1. Napraviti metodu RijecUBroj() koja prima 1 string parametar riječ i vraća string
sa pripadajućim telefonskim brojem. Unos može biti velikim ili malim slovima, a ako
riječ sadrži brojeve 0 ... 9 ili znak + metoda ih ostavlja onakvima kakvi jesu.
 2. U glavnom programu omogućiti višestruki unos te za svaki unos pozvati
metodu RijecUBroj(). Ukoliko upisana riječ sadrži nepoznate znakove, program treba
vratiti Exception sa odgovarajućom porukom i tražiti ponovni unos. Riječ „kraj” ne
treba prevoditi u telefonski broj. 
 */


while (true)
{
    try
    {
        Console.WriteLine("\nUnesi riječ (upiši kraj za izlaz): ");
        string rijec = Console.ReadLine();
        
        if (rijec == "kraj")
        {
            break;
        }

        foreach (char slovo in rijec)

        {
            if (rijec == "kraj")
            {
                break;
            }
            else if (slovo == 'a' || slovo == 'b' || slovo == 'c')
            {
                Console.Write("2");
            }
            else if (slovo == 'd' || slovo == 'e' || slovo == 'f')
            {
                Console.Write("3");
            }
            else if (slovo == 'g' || slovo == 'h' || slovo == 'i')
            {
                Console.Write("4");
            }
            else if (slovo == 'j' || slovo == 'k' || slovo == 'l')
            {
                Console.Write("5");
            }
            else if (slovo == 'm' || slovo == 'n' || slovo == 'o')
            {
                Console.Write("6");
            }
            else if (slovo == 'p' || slovo == 'r' || slovo == 's')
            {
                Console.Write("7");
            }
            else if (slovo == 't' || slovo == 'u' || slovo == 'v')
            {
                Console.Write("8");
            }
            else if (slovo == 'z' || slovo == 'x' || slovo == 'y')
            {
                Console.Write("9");
            }
            
        }

    }
    catch (Exception)
    {

        throw;
    }
}