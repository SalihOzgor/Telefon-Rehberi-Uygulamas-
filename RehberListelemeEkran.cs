using System;

namespace Telefon_Rehberi_Uygulamas_
{
    public class RehberListelemeEkran
    {
        public static void RehberListelemeEkranGoster()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            

            foreach (Kisiler kisi in AnaEkran.KisiList)
            {
                Console.WriteLine("İsim: {0}",kisi.Isim);
                Console.WriteLine("Soyisim: {0}",kisi.Soyisim);
                Console.WriteLine("Telefon Numarası: {0}",kisi.TelNo);
                Console.WriteLine("-----------");
            }

            Console.WriteLine("\n* Ana ekrana dönmek için herhangi bir tuşa basınız...");
            Console.ReadLine();
            AnaEkran.AnaEkranGoster();
        }
    }
}