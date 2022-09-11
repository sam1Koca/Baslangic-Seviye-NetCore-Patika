using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.CollectionsGeneric

            //Key:int , value ise string olsun.
            Dictionary<int,string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(10, "Sayit Sami Koca");
            kullanicilar.Add(12, "Kevin Mitnick");
            kullanicilar.Add(18, "Bill Gates");
            kullanicilar.Add(20, "Mark Zuckerberg");


            // Dizinin Elemanlarına Erişim
            Console.WriteLine("********* Elemanlara Erişim ***********");

            Console.WriteLine(kullanicilar[12]); // Kullanıclar'dan key değeri 12 olan elemanı getir bana...
            
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }


            //Count;
            Console.WriteLine("********* Count ***********");
            Console.WriteLine(kullanicilar.Count);


            //Contains (true-false)
            Console.WriteLine("********* Contains ***********");
            Console.WriteLine(kullanicilar.ContainsKey(12)); // 12 key'ine ait eleman varmı.
            Console.WriteLine(kullanicilar.ContainsValue("Bill Gates")); // Bill Gates value'si varmı.


            //Remove
            Console.WriteLine("********* Remove ***********");
            kullanicilar.Remove(12); // 12 Key'ine ait elemanı kaldır.
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            //Keys
            Console.WriteLine("******** KEYS **************");
            foreach (var item in kullanicilar.Keys)
            {
                Console.WriteLine(item);
            }


            //Values
            Console.WriteLine("************* Values **********");
            foreach (var item in kullanicilar.Values)
            {
                Console.WriteLine(item);
            }

            // Values ve Keys ile Ayrı ayrı işlem yapabiliyorum.



        }
    }
}
