using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                -> Klavyeden Girilen 20 adet sayının en büyük ve en küçük 3 tanesini bulan,
                    -> Her İki grubun kendi içerisinde ortalamasını alan, bu ortalamaları ve ortalamaların toplamlarını Console Yazdıran Program. (ArrayList Kullanarak yapınız) 

            */

            ArrayList sayilar = new ArrayList();
            ArrayList enBuyukSayilar = new ArrayList();
            ArrayList enKucukSayilar = new ArrayList();

           
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}. Sayıyı Giriniz: ", i+1);
                int sayi = Convert.ToInt32(Console.ReadLine());

                sayilar.Add(sayi);
            }

            sayilar.Sort(); // Küçükten büyüğe doğru sıraladım.

            Console.Write("Girilen Sayılar: ");
            foreach (var item in sayilar)
            {
                Console.Write(item + ",");
            }



            Console.Write("\n\nGirilen En Küçük 3 Sayı: ");

            for (int i = 0; i < 3; i++) // En Küçük Sayıları Alıp diziye ekliyorum
            {
                enKucukSayilar.Add(sayilar[i]);
            }

            int enKucukToplam = 0;
            foreach (var item in enKucukSayilar)
            {
                Console.Write(item + ",");
                enKucukToplam = enKucukToplam+Convert.ToInt32(item);

            }




            sayilar.Reverse();

            Console.Write("\n\nGirilen En Büyük 3 Sayı: ");

            for (int i = 0; i < 3; i++)
            {
                enBuyukSayilar.Add(sayilar[i]);
            }

            int enBuyukToplam = 0;
            foreach (var item in enBuyukSayilar)
            {
                Console.Write(item + ",");
                enBuyukToplam = enBuyukToplam + Convert.ToInt32(item);
            }



            //Her iki grubunda ortalamaları ve ortalamaların toplamları



            Console.Write($"\n\nEn Büyük 3 Sayının Ortalaması: {enBuyukToplam / enBuyukSayilar.Count}");

            Console.Write($"\nEn Küçük 3 Sayının Ortalaması: {enKucukToplam / enKucukSayilar.Count}");

            Console.Write($"\n\nEn Büyük ve En Küçük Dizelerin Ortalamalarının Toplamları: {(enBuyukToplam / enBuyukSayilar.Count) + (enKucukToplam / enKucukSayilar.Count) }");

        }
    }
}
