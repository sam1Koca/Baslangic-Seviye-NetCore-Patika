using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Koleksiyonlar_Soru_1
{ 
    class Program
    {
        static void Main(string[] args)
        {
            /* Soru-1 -> Klavyeden girilen 20 adet pozitif sayıyı asal ve asal olmayanlar olarak iki ayrı listeye atın.[ArrayList Kullanarak Yazınız]

               - Negatif ve numeric olmayan girişleri engelleyin.
               - Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
               - Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
               
            */

            ArrayList sayilar = new ArrayList();
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();
            Regex elemanKontrol = new Regex("^[0-9]*$");
 

            // Regex; Bir eleman yada ifadenin içerisinde rakam yada verilen değerler varmı, bunu kontrol eder.

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("{0}. Sayıyı Giriniz: ", i+1);
                string sayi = Console.ReadLine();

                if (!elemanKontrol.IsMatch(sayi) || int.Parse(sayi)<0)
                {
                    Console.WriteLine("Lütfen negatif ve numeric olmayan, değerleri giriniz..!");
                    break;
                }
                

                var kontrolSonuc = AsalSayiKontrol(int.Parse(sayi));

                if (kontrolSonuc == 1)
                {
                    asalSayilar.Add(sayi);
                }
                else
                {
                    asalOlmayanSayilar.Add(sayi);
                }
                
            }
            sayilar.AddRange(asalOlmayanSayilar);
            sayilar.AddRange(asalSayilar);

            Console.Write("\nGirilen Sayılar: ");
            foreach (var item in sayilar)
            {
                Console.Write(item + ",");
            }

            int asalTop = 0;

            Console.Write("\n\nAsal Sayılar: ");
            foreach (var item in asalSayilar)
            {
                Console.Write(item + ",");
                asalTop = asalTop + Convert.ToInt32(item);
               
            }

            int asalOlmayanTop = 0;
            Console.Write("\n\nAsal Olmayan Sayılar: ");
            foreach (var item in asalOlmayanSayilar)
            {
                Console.Write(item + ",");
                asalOlmayanTop = asalOlmayanTop + Convert.ToInt32(item);
            }


            // Asal Sayılar ve Asal Olmayan Sayılar Dizilerinin Büyükten küçüğe doğru sıralanışı....


            Console.Write("\nAsal Sayılar Büyükten Küçüğe Doğru Sıralama: ");

            asalSayilar.Sort(); // Küçükten-büyüğe doğru sıralar.
            asalSayilar.Reverse(); // Ters Çevirir 
            foreach (var item in asalSayilar)
            {
                Console.Write(item + ",");
                
            }


            Console.Write("\nAsal Olmayan Sayılar Büyükten Küçüğe Doğru Sıralama: ");

            asalOlmayanSayilar.Sort(); // Küçükten-büyüğe doğru sıralar.
            asalOlmayanSayilar.Reverse(); // Ters Çevirir 
            foreach (var item in asalOlmayanSayilar)
            {
                Console.Write(item + ",");
            }




            // Asal ve Asal Olmayan Dizilerin Eleman Sayısı ve Ortalamaları...
            
            Console.WriteLine($"\n\nAsal Sayılar Eleman Sayısı: {asalSayilar.Count}");
            Console.WriteLine($"Asal Sayılar Ortalama: {asalTop / asalSayilar.Count} ");


            Console.WriteLine($"\n\nAsal Olmayan Sayılar Eleman Sayısı: {asalOlmayanSayilar.Count}");
            Console.WriteLine($"Asal Olmayan Sayılar Ortalama: {asalOlmayanTop / asalOlmayanSayilar.Count} ");
        }

        public static int AsalSayiKontrol(int sayi)
        {
            int i = 2;
            for (i = 2; i <= sayi-1; i++)
            {
                if (sayi%2==0)
                {
                    return 0; // false
                }
            }

            if (i==sayi)
            {
                return 1; //true
            }
            return 0; 
        }
    }
}
