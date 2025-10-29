// . Napraviti metodu RijecUBroj() koja prima 1 string parametar riječ i vraća string
using System.Text;
using System.Threading.Channels;

sa pripadajućim telefonskim brojem. Unos može biti velikim ili malim slovima, a ako 
riječ sadrži brojeve 0 ... 9 ili znak + metoda ih ostavlja onakvima kakvi jesu.

using System;
using System.Text;

class program
{
    static void Main()
    {
        Console.Write("Unesi riječ: ");
        string rijec = Console.ReadLine();
        string broj = RijecUBroj(rijec);
        Console.WriteLine("Telefonski broj: + broj ");
    }
    static string RijecUBroj(string rijec)
    {
        if (rijec == null)
            return "";

        StringBuilder rezultat = new StringBuilder();

        foreach (char c in rijec.ToUpper())
        {
            if (char.IsDigit(c) || c == '+')
            {
                rezultat.Append(c);
            }
            else
            {
                switch (c)
                {
                    case 'A':
                    case 'B':
                    case 'C':
                        rezultat.Append('2'); break;
                    case 'D':
                    case 'E':
                    case 'F':
                        rezultat.Append('3'); break;
                    case 'G':
                    case 'H':
                    case 'I':
                        rezultat.Append('4'); break;
                    case 'J':
                    case 'K':
                    case 'L':
                        rezultat.Append('5'); break;
                    case 'M':
                    case 'N':
                    case 'O':
                        rezultat.Append('6'); break;
                    case 'P':
                    case 'Q':
                    case 'R':
                    case 'S':
                        rezultat.Append('7'); break;
                    case 'T':
                    case 'U':
                    case 'V':
                        rezultat.Append('8'); break;
                    case 'W':
                    case 'X':
                    case 'Y':
                    case 'Z':
                        rezultat.Append('9'); break;
                    default:
                        //ostali znakovi se mogu ignorirati ili dodati kakvi jesu

                        break;


                }

            }

        }
        return rezultat.ToString();
    }
}