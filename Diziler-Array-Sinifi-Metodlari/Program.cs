using System;

namespace Diziler_Array_Sinifi_Metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort - Sıralama İşlemi
            int[] sayiDizisi = {23, 12, 4, 86, 72, 3, 11, 17};
            
            Console.WriteLine("****** Sırasız Dizi ******\n");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);


            Console.WriteLine("****** Sıralı Dizi ******\n");
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);



            // Clear    
            // Verdiğimiz indexten başlar, verdiğimiz eleman sayısına kadar temizler.

            Console.WriteLine("****** Array Clear ******\n");
            Array.Clear(sayiDizisi, 2, 2); 

            // İlk dizi adi, kaçıncı indexten başla, 2 tane elemanı temizle..
            // sayiDizisi elemanlarını kullanarak 2. indexten itibaren 2 tane elemanı 0'lar.

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            
            // Reverse - Diziyi Tersine Çevirme İşlemi

            Console.WriteLine("****** Array Reverse ******\n");
            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);



            // IndexOf - Verilen eleman, dizinin içinde varsa index'ini döner

            Console.WriteLine("****** Array IndexOf ******\n");
             
            Console.WriteLine(Array.IndexOf(sayiDizisi,23)); // sayiDizisi isimli dizide 23 elemanı kaçıncı indexte..


            // Resize - Dizi Boyutunu Yeniden Boyutlandırma
            Console.WriteLine("****** Array Resize ******\n");
            Array.Resize<int>(ref sayiDizisi,9); 
            // <int> ile array tipi, ref olarak dizi adı, sonrasında kaç elemanlı bir dizi olacağını yazıyoruz..

            sayiDizisi[8] = 99;

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

        }
    }
}
