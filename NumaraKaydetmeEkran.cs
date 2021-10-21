using System;
using System.Collections.Generic;

namespace Telefon_Rehberi_Uygulamas_
{
    public class NumaraKaydetmeEkran
    {
        
        
        public static void NumaraKaydetmeEkranGoster()
        {
            Console.Write("Lütfen isim giriniz: ");
            string isim = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz: ");
            string soyisim = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz: ");
            string telno = Console.ReadLine();

            KisiEkle(isim,soyisim,telno);
            
            
        }

        public static void KisiEkle(string isim , string soyisim, string telNo)
        {
            
            
            AnaEkran.KisiList.Add(new Kisiler(isim,soyisim,telNo));
            Console.WriteLine("***{0} {1} kişisi başarıyla eklenmiştir.***\n",isim,soyisim);
            AnaEkran.KisiList.Sort((x,y)=> x.Isim.CompareTo(y.Isim));
            AnaEkran.AnaEkranGoster();
            
            
            
        }
    }
}