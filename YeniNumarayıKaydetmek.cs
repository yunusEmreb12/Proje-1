using System;
using System.Collections.Generic;
namespace telefon_rehberi_uygulaması
{
    public class YeniNumarayıKaydetmek:DefaultPerson
    {
        public void Kaydetmek()
        {
            Console.WriteLine("Lütfen isim giriniz :");
            string ad = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz :");
            string soyisim = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz :");
            string numbara = Console.ReadLine();

            defaultPerson.Add(ad,soyisim + " " + numbara);
            Console.WriteLine(ad + " " + soyisim + " Başarıyla Eklendi.");  
        }
    }
}