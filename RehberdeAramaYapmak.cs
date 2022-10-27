using System;
using System.Collections.Generic;
namespace telefon_rehberi_uygulaması
{
    public class RehberdeAramaYapmak:DefaultPerson
    {
        public void Arama()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine(" **********************************************");
            Console.WriteLine();
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            string secim = Console.ReadLine();
            if(secim == "1")
            {
                Console.WriteLine("Lütfen aramak istediğiniz kişinin isim veya soyismini giriniz:");
                string numara1 = Console.ReadLine();
                foreach (var item in defaultPerson)
                {
                    if(item.Value.Contains(numara1))
                    {
                        Console.WriteLine("İsim-Soyisim :" + item.Value);
                        Console.WriteLine("Telefon Numarası :" + item.Key);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if(secim == "2")
            {
                Console.WriteLine("Lütfen aramak istediğiniz kişinin isim veya soyismini giriniz:");
                string numara2 = Console.ReadLine();
                foreach (var item in defaultPerson)
                {
                    if(item.Key.Contains(numara2))
                    {
                        Console.WriteLine("İsim-Soyisim :" + item.Value);
                        Console.WriteLine("Telefon Numarası :" + item.Key);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}