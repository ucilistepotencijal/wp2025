// Interface je referentni tip podatka. Nisu vrijednosni tip nego pokazuju na neku memorijsku lokaciju.
// Definira ugovor koji klase moraju poštivati
// class - Implementira metode i svojstva definirana u sučelju
// Interface je tko? a klasa je što?

partial class Program
{
    interface IMojInterfejs
    {
        //Svojstva
        int mojBroj {  get; set; }

        //Metode
        int vratiNesto();
        
    }

    public class Osoba : IMojInterfejs
    {
        public int mojBroj { get; set; }

        public int vratiNesto()
        {
            return 0;
        }
    }

    public class Student: IMojInterfejs
    {
        public int mojBroj { get; set; }

        public int vratiNesto()
        {
            return 5;
        }
    }

}