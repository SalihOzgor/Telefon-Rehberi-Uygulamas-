using System;

namespace Telefon_Rehberi_Uygulamas_
{
    public class NumaraGuncellemeEkran
    {
        public static void NumaraGuncellemeEkranGoster()
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string metin = Console.ReadLine();
            bool kontrol = true;
            foreach (Kisiler kisi in AnaEkran.KisiList)
            {
                if (kisi.Isim == metin || kisi.Soyisim == metin)
                {
                    GuncellemeTuruSec(metin,kisi);
                    kontrol = false;
                    break;
                }
            }
            if (kontrol)
            {
                KisiBulunamadi();
            }
        }

        public static void KisiBulunamadi()
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için      : (2)");
            string cevap = Console.ReadLine();
            switch (cevap)
            {
                case "1":
                    AnaEkran.AnaEkranGoster();
                    break;
                case "2":
                    NumaraGuncellemeEkranGoster();
                    break;
                default:
                    Console.WriteLine("Yanlış karakter girdiniz");
                    KisiBulunamadi();
                    break;
            }

        }

        public static void GuncellemeTuruSec(string metin,Kisiler kisi)
        {
            Console.WriteLine("* {0} kişisinin adını güncellemek için         : (1)",kisi.Isim+" "+kisi.Soyisim);
            Console.WriteLine("* {0} kişisinin soyadını güncellemek için      : (2)",kisi.Isim+" "+kisi.Soyisim);
            Console.WriteLine("* {0} kişisinin numarasını güncellemek için    : (3)",kisi.Isim+" "+kisi.Soyisim);
            string cevap = Console.ReadLine();
            switch (cevap)
            {
                case "1":
                    Console.Write("Yeni adı giriniz: ");
                    kisi.Isim = Console.ReadLine();
                    AnaEkran.KisiList.Sort((x,y)=> x.Isim.CompareTo(y.Isim));
                    Console.WriteLine("***İşlem başarıyla tamamlandı***.\n");
                    AnaEkran.AnaEkranGoster();
                    break;
                case "2":
                    Console.Write("Yeni soyadı giriniz: ");
                    kisi.Soyisim = Console.ReadLine();
                    AnaEkran.KisiList.Sort((x,y)=> x.Isim.CompareTo(y.Isim));
                    Console.WriteLine("***İşlem başarıyla tamamlandı.***\n");
                    AnaEkran.AnaEkranGoster();
                    break;
                case "3":
                    Console.Write("Yeni numarayı giriniz: ");
                    kisi.TelNo = Console.ReadLine();
                    Console.WriteLine("***İşlem başarıyla tamamlandı.***\n");
                    AnaEkran.AnaEkranGoster();
                    break;
                default:
                    Console.WriteLine("Yanlış karakter girdiniz");
                    KisiBulunamadi();
                    break;
            }
        }
    }
}