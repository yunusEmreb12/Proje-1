using System;
namespace telefon_rehberi_uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");

            string sonSecim = Console.ReadLine();

            switch (sonSecim)
            {
                case "1":
                    YeniNumarayıKaydetmek yeniNumKaydet = new YeniNumarayıKaydetmek();
                    yeniNumKaydet.Kaydetmek();
                    yeniNumKaydet.RehberiListeleme();
                    break;

                case "2":                   
                    TelefonNumarasınıSil TelSil = new TelefonNumarasınıSil();
                    TelSil.Sil();
                    break;

                case "3":                   
                    TelefonRehberiGüncelleme TelGüncelleme = new TelefonRehberiGüncelleme();
                    TelGüncelleme.TelGüncelleme();
                    break;

                case "4":
                    DefaultPerson Kisiler = new DefaultPerson();
                    Kisiler.RehberiListeleme();
                    break;

                case "5":
                    RehberdeAramaYapmak rehberArama = new RehberdeAramaYapmak();
                    rehberArama.Arama();
                    break;
            }

            Console.ReadLine();
        }
    }
}