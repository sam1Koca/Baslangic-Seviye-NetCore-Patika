using System;

namespace Recursive_Extension_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recursive - Öz Yinelemeli(Kendi Kendini Çağıran Metotlar)

            // 3^4 = 3*3*3*3

            int result = 1;

            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);

            Islemler islemler = new Islemler();
            Console.WriteLine(islemler.Expo(3,4));


            // Extension Metotlar - Bu metotlar static olmalı...

            string nameAndSurname = "Sayit Sami Koca";
            bool sonuc = nameAndSurname.CheckSpaces();
            Console.WriteLine(sonuc);

            if (sonuc)
            {
                Console.WriteLine(nameAndSurname.RemoveWhiteSpaces());
            }

            Console.WriteLine(nameAndSurname.MakeUpperCase());

            Console.WriteLine(nameAndSurname.MakeLowerCase());


            int[] sayiDizisi = {9, 3, 6, 2, 1, 5, 0};

            sayiDizisi.SortArray();
            sayiDizisi.PrintToScreen();

            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber());


            Console.WriteLine(nameAndSurname.GetFirstCharacter());
            
        }
    }

    class Islemler 
    {
        public int Expo(int sayi, int üs)
        {
            if (üs<2)
            {
                return sayi;
            }
            return Expo(sayi, üs-1) * sayi;

            // Expo(3,4)
            // Expo(3,3) * 3;
            // Expo(3,2) * 3 * 3;
            // Expo(3-1) * 3 * 3 * 3;
            // 3 * 3 * 3 * 3 = 3^4; 
        }
    }

    static class Extension
    {
        public static bool CheckSpaces(this string value)
        {
            // Verilen değişkenin içeriğinde boşluk(space) varmı - kontrolü yapan bir metot.
            // this ifadesi ile 'extension Metot' hline getiririz.

            return value.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string value)
        {
            // Bu metot verdiğimde değerde boşluk(spaces) varsa onu kaldırmaya yarıyor.

            string[] dizi = value.Split(" "); // Bu stringi boşuklara göre ayır ve diziye al.

            return string.Join("*",dizi); // Boşluk olan değeri, boşluk olmayan değerler değiştir. - yıldız ile
        }

        public static string MakeUpperCase(this string value)
        {
            // Bu metot verilen ifadenin içerisindeki metinin harflerini vs. BÜYÜK yapar. 
            return value.ToUpper();
        }

        public static string MakeLowerCase(this string value)
        {
            // Bu metot verilen ifadenin harflerini/metini tamamıyla küçük hale çevirir.
            return value.ToLower();
        }

        public static int[] SortArray(this int[] values)
        {
            // Bu extension metot ise bir int tipindeki diziyi sıralamaya yarıyor.
            Array.Sort(values);
            return values;
        }

        public static void PrintToScreen(this int[] value)
        {
            foreach (int item in value)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int value)
        {
            // Verilen değer ikiye bölünüyormu. 
            return value%2==0;
        }

        public static string GetFirstCharacter(this string value)
        {
            return value.Substring(0,1); // Start-End indexi. Bunların araındakini ver yani ilk değeri / Bir karekter getir.
        }
    }
}
