using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopDAL;

namespace WebShopApp
{
    internal class Datoteka
    {
        public static void KreirajDatoteku(Narudzba narudzba, string NazivDatoteke)
        {
            FileStream fs = new FileStream(NazivDatoteke, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("-----------------------Narudžba---------------------");
            sw.WriteLine("Datum narudžbe: {0}", narudzba.DatumKreiranja);
            sw.WriteLine("Dostavljeno {0}", (narudzba.DostavaIzvrsena ? "DA" : "ME"));
            sw.WriteLine("Proizvodi: ");
            foreach (Proizvod item in narudzba.Proizvodi)
            {
                sw.WriteLine("item.Naziv{0}: {1} EUR", item.Naziv, Math.Round(item.UkupnaCijena, 2));
            }
            sw.WriteLine("Ukupna cijana: {0} EUR", Math.Round(narudzba.UkupnaCijena,2));
            sw.Close();

            //kreiramo filestream  -> streamwriter
            //upisujemo narudžbu
            //upisujemo proizvode
            //zatvaramo streamwriter
        }

        public static string ProcitajDatoteku(string nazivDatoteke)
        {
            //kreiramo filestream -> streamreader
            //return "";//sadržaj
            FileStream fs = new FileStream(nazivDatoteke, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string sadrzaj = sr.ReadToEnd();
            sr.Close();
            return sadrzaj;
        }
    }
}
