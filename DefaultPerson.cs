using System;
using System.Collections.Generic;
namespace telefon_rehberi_uygulaması
{
    public class DefaultPerson
    {
        public Dictionary<string,string> defaultPerson = new Dictionary<string, string>();

        public DefaultPerson()
        {
            defaultPerson.Add("1234567891011","Naruto Uzumaki");
            defaultPerson.Add("1234567891012","MonkeyD Luffy");
            defaultPerson.Add("1234567891013","John Stark");
            defaultPerson.Add("1234567891014","Deamon Targaryen");
            defaultPerson.Add("1234567891015","John Wick");
        }

        public void RehberiListeleme()
        {
            foreach (var item in defaultPerson)
            {
                Console.WriteLine(item);
            }
        }
    }
}