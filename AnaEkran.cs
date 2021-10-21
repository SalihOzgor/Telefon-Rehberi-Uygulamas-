using System;
using System.Collections.Generic;
using System.Linq;

namespace Telefon_Rehberi_Uygulamas_
{
    public class AnaEkran
    {
        public static List<Kisiler> KisiList;
        
        static AnaEkran()
        {
            KisiList = new List<Kisiler>()
            {
                new Kisiler("Recep","Şahin","3055651620"),
                new Kisiler("Recep","Karapınar","3065412345"),
                new Kisiler("İsmail","Sönmez","3512152014"),
                new Kisiler("Onur","Alper","3012411932"),
                new Kisiler("Ömer","Reis","5078484953")
            };

            KisiList.Sort((x,y)=> x.Isim.CompareTo(y.Isim));
        }
        public static void AnaEkranGoster()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            int number = int.Parse(Console.ReadLine());
            TuslamaFonk(number);
        }

        public static void TuslamaFonk(int number)
        {
            switch (number)
            {
                case 1:
                    NumaraKaydetmeEkran.NumaraKaydetmeEkranGoster();
                    break;
                case 2:
                    NumaraSilmeEkran.NumaraSilmeEkranGoster();
                    break;
                case 3:
                    NumaraGuncellemeEkran.NumaraGuncellemeEkranGoster();
                    break;
                case 4:
                    RehberListelemeEkran.RehberListelemeEkranGoster();
                    break;
                case 5:
                    AramaYapmaEkran.AramaYapmaEkranGoster();
                    break;
                default:
                    Console.WriteLine("Yanlış Karakter Tuşladınız");
                    AnaEkranGoster();
                    break;
            }
        }

        

        
    }
}