using System;
using System.Collections.Generic;
namespace telefon_rehberi_uygulaması
{
    public class TelefonNumarasınıSil:DefaultPerson
    {
        public void Sil()
        {
            Sil:
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string adSoyad = Console.ReadLine();
            int say1 = 0;

            foreach (var item in defaultPerson)
            {
                if (item.Value.Contains(adSoyad))
                {
                    defaultPerson.Remove(item.Key);
                    Console.WriteLine(item.Value + "Başarıyla silindi.");
                    break;
                }
                else
                {
                    say1++;
                    continue;
                }
            }

            if (say1 == defaultPerson.Count)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");

                string seçim2 = Console.ReadLine();
                if(seçim2 == "1")
                {
                    Console.WriteLine("Çıkış yapıldı.");
                }
                else if (seçim2 == "2")
                {
                    goto Sil;
                }
            }

            foreach (var item in defaultPerson)
            {
                Console.WriteLine(item);
            }
        }
    }
}