using System;

namespace Telefon_Rehberi_Uygulamas_
{
    public class AramaYapmaEkran
    {
        public static void AramaYapmaEkranGoster()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************\n");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            string cevap = Console.ReadLine();
            switch (cevap)
            {
                case "1":
                    Console.Write("Lütfen isim veya soyisim giriniz: ");
                    KisiBulma(Console.ReadLine());
                    break;
                case "2":
                    Console.Write("Lütfen telefon numarasını giriniz: ");
                    NumaraBulma(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Yanlış karakter girdiniz");
                    AramaYapmaEkranGoster();
                    break;
            }
        }

        public static void KisiBulma(string metin)
        {
        
            bool ilkSatirKontrol = true;
            foreach (Kisiler kisi in AnaEkran.KisiList)
            {
                if (kisi.Isim == metin || kisi.Soyisim == metin)
                {   
                    if (ilkSatirKontrol)
                    {
                        Console.WriteLine("Arama Sonuçlarınız:");
                        Console.WriteLine("**********************************************");
                    }
                    Console.WriteLine("İsim: {0}",kisi.Isim);
                    Console.WriteLine("Soyisim: {0}",kisi.Soyisim);
                    Console.WriteLine("Telefon Numarası: {0}",kisi.TelNo);
                    Console.WriteLine("-----------");
                    ilkSatirKontrol = false;
                }
                
            }
            if (ilkSatirKontrol)
            {
                KisiBulunamadi();
            }
        }

        public static void NumaraBulma(string numara)
        {
        
            bool ilkSatirKontrol = true;
            foreach (Kisiler kisi in AnaEkran.KisiList)
            {
                if (kisi.TelNo == numara )
                {   
                    if (ilkSatirKontrol)
                    {
                        Console.WriteLine("Arama Sonuçlarınız:");
                        Console.WriteLine("**********************************************");
                    }
                    Console.WriteLine("İsim: {0}",kisi.Isim);
                    Console.WriteLine("Soyisim: {0}",kisi.Soyisim);
                    Console.WriteLine("Telefon Numarası: {0}",kisi.TelNo);
                    Console.WriteLine("-----------");
                    ilkSatirKontrol = false;
                }
                
            }
            if (ilkSatirKontrol)
            {
                KisiBulunamadi();
            }
            Console.WriteLine("\n* Ana ekrana dönmek için herhangi bir tuşa basınız...");
            Console.ReadLine();
            AnaEkran.AnaEkranGoster();
        }

        public static void KisiBulunamadi()
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Aramayı sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için      : (2)");
            string cevap = Console.ReadLine();
            switch (cevap)
            {
                case "1":
                    AnaEkran.AnaEkranGoster();
                    break;
                case "2":
                    AramaYapmaEkranGoster();
                    break;
                default:
                    Console.WriteLine("Yanlış karakter girdiniz");
                    KisiBulunamadi();
                    break;
            }

        }
    }
}