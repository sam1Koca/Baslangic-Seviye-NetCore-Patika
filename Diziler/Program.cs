using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aynı tip değişkenleri bellekte arka arkaya saklamak istediğimizde dizileri kullanırız.


            string[] renkler = new string[5]; // Boyutu belli olan dizi.

            string[] hayvanlar = {"Köpek","Kuş", "Kedi", "Aslan"}; // Elemanları atayarak tanımladığımız dizi.

            int[] dizi;
            dizi = new int[5]; // Bu şekilde de bir dizi tanımlayabilirim.



            // Dizilere Değer Atama ve Erişim

            renkler[0] = "Mavi";

            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);


            // Döngülerle Dizi Kullanımı


            // örn. Klavyeden girilen n tane sayının ortalamasını hesaplayan program.

            Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];
            
            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. Sayıyı Giriniz: ", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam +=sayi;
            }

            Console.WriteLine("Ortalama: " + toplam/diziUzunlugu);
        }
    }
}
