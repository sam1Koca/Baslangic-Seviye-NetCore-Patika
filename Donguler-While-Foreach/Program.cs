using System;

namespace Donguler_While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // While
            // 1'den başlayarak console'dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console'a yazdıran program. 

            /*
            Console.Write("Lütfen Bir Sayı Giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam+= sayac;
                sayac ++;
            }
            Console.WriteLine(toplam/sayi);
            */


            // 'a'dan 'z' ye kadar olan tüm harfleri console'a yazdıralım.

            char character = 'a';
            while (character<'z')
            {
                Console.Write(character);
                character++;
            }

            Console.WriteLine("\n\n****** FOREACH ******");

            string[] cars = {"Volvo", "Opel" , "Audi", "Renault"}; // Arabalar dizisi.

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

        }
    }
}
