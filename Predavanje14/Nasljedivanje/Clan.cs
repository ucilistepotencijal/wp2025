using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje
{
    internal class Clan : Osoba //Clan ce naslijediti osobu. Imat će ime i prezime i neke dodatne propertije.
    {
        //konstruktor nije moguce naslijediti. nego moramo napraviti svoj konstruktor
        public Clan(string ime, string prezime) : base(ime, prezime) // ovo znači: konstruiraj mi člana s imenom i prezimenom koji nasljeđuje iz bazne klase a bazna klasa je osoba. 
        {
        }

        public string ClanskiBroj {  get; set; }

        public string Detalji()
        {
            return PunoIme() + ", id: " + ClanskiBroj;
        }

        //skrivanje metohe (hide) - Kad pozovemo metodu Punoime na našem članu, ona neče pozvati metodu iz klase "Osoba" 
        //nego će pozvati metodu koja nasljeđuje iz klase osoba a zove se - "Clan"
        public new string PunoIme()
        {
            return Prezime + " " + Ime;
        }
      
        public override string ToString()
        {
            return Detalji();
        }
    }
}
