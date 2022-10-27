using System;
using System.Collections.Generic;
namespace telefon_rehberi_uygulaması
{
    public class TelefonRehberiGüncelleme:DefaultPerson
    {
        public void TelGüncelleme()
        {
            Güncelleme:
            Console.WriteLine("Lüften numarasını güncelleme isteğiniz kişinin adını yada soyadını giriniz :");
            string ad = Console.ReadLine();
            int say = 0;
            foreach (var item in defaultPerson)
            {
                if (item.Value.Contains(ad))
                {
                    Console.WriteLine("Lütfen yeni numara giriniz :");
                    string newNumara = Console.ReadLine();
                    string newAd = item.Value;
                    defaultPerson.Remove(item.Key);
                    defaultPerson.Add(newNumara,newAd);
                    break;
                }
                else
                {
                    continue;
                }              
            }
            
            if (say == defaultPerson.Count)
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı.Lütfen seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için    : (1)");
                Console.WriteLine("* Yeniden denemek için              : (2)");

                string secim1 = Console.ReadLine();
                if (secim1 == "1")
                {
                    Console.WriteLine("Çıkış yapıldı.");
                }
                else if(secim1 == "2")
                {
                    goto Güncelleme;
                } 
            }

            foreach (var item in defaultPerson)
            {
                Console.WriteLine(item);
            }
        }
    }
}