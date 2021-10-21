using System;

namespace Telefon_Rehberi_Uygulamas_
{
    public class NumaraSilmeEkran
    {
        public static void NumaraSilmeEkranGoster()
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string metin = Console.ReadLine();
            bool kontrol = true;
            foreach (Kisiler kisi in AnaEkran.KisiList)
            {
                if (kisi.Isim == metin || kisi.Soyisim == metin)
                {
                    SilmeOnay(metin,kisi);
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
                    NumaraSilmeEkranGoster();
                    break;
                default:
                    Console.WriteLine("Yanlış karakter girdiniz");
                    KisiBulunamadi();
                    break;
            }

        }

        public static void SilmeOnay(string metin,Kisiler kisi)
        {
            Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)",kisi.Isim+" "+kisi.Soyisim);
            
            string cevap = Console.ReadLine();

            switch (cevap)
            {
                case "y":
                    AnaEkran.KisiList.Remove(kisi);
                    Console.WriteLine("***{0} {1} kişisi başarıyla silinmiştir.***\n",kisi.Isim,kisi.Soyisim);
                    AnaEkran.AnaEkranGoster();
                    break;
                case "n":
                    AnaEkran.AnaEkranGoster();
                    break;
                default:
                    Console.WriteLine("Yanlış karakter girdiniz");
                    SilmeOnay(metin,kisi);
                    break;
            }

        }
    }
}