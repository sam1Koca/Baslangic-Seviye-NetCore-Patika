using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Değişkenlerin her zaman bir değeri olmak zorundadır. Yoksa null tanımlanmalıdır. Ataması yapılmayan değişkenler kullanıldığında derleyici hata verir.
            int value = 10;


            // case-Sensitive duyarlıdır
            string name = null;
            string Name = null;


            // Değişkn isimleri Rakam ile başlayamaz
            //    int 45 = null; !hata verir


            // Değişken isimleri boşluk içeremez. Yalnızca "_" ifadesi kullanılabilir.
                //   string name surname = null;  !hata verir || Doğrusu aşağıda
            string name_surname = null; 


            // Değişken isimlerinin arasında matematiksel ifadeler yani işlem operatörleri kullanılamaz.
                // string age+yas = null;

            // Class namespace gibi özel isimler kullanılamaz.
                // string Class = null; !hata verir


            //  Değişken tipleri   -   Bellekte Kapladığı Miktarlar
            
            //Reel - Tam Saylıar
            byte values = 5;           // 1 byte
            sbyte values_2 = 10;      // 1 byte
 
            short values_3 = 15;     // 2 byte
            ushort values_4 = 20;    // 2 byte

            Int16 values_5 = 2;       // 2 byte
            int values_6 = 2;         // 4 byte
            Int32 values_7 = 2;       // 4 byte
            Int64 values_8 = 2;        // 8 byte

            uint values_9 = 2;        // 4 byte
            long values_10 = 2;       // 8 byte
            ulong values_11 = 2;       // 8 byte

            // Ondalıklı Sayılar
            float values_12 = 1.5;     // 4 byte
            double values_13 = 2.75;   // 8 byte
            decimal values_14 = 9.22;  // 16 byte


            
            
            char values_15 = '1';   // 2 byte

            // Stringlerle işlem yapmak veritabanında maliyetli işlemlerdir :)
            string values_16 = "I am Koca";   // Sınırsız


            // Boolean İfadeler

            bool values_17 = false;
            bool values_18 = true;


            // O an ki tarih ve saati DateTime kütüphanesini kullanarak ekrana bastım.

            DateTime dateTime = DateTime.Now;

            Console.WriteLine(dateTime);



            // objects - Her türden veriyi alabilir. (Tüm değişkenler bundan türer)
            object o1 = "patika";
            object o2 = "x";
            object o3 = 15;
            object o4 = 21.75;
            object o5 = true;


            // string ifadeler

            string str1 = string.Empty;  // boş değer

            str1 = "Sayit Sami Koca";
            string name = "Sayit Sami";
            string surname = "Koca";

            string fullName = name + " " + surname;


            // integer tanımlama işlemleri

            int integer1 = 5;
            int integer2 = 3;
            int sonuc = integer1 * integer2;

            // Boolean

            bool boolValue = 2<1; // false değer döner.


            // Değişken Dönüşümleri

            string sayi = "20";
            int sayi2 = 20;
            string yeniDeger = sayi + sayi2.ToString(); // İlk dönüştürme yolu
            Console.WriteLine(yeniDeger); // Output 2020


            int number3 = sayi2 + Convert.ToInt32(sayi); // İkinci dönüştürme yolu
            Console.WriteLine(number3); // output 40


            int number4 = sayi2 + int.Parse(sayi);  // Üçüncü dönüştürme yolu
            Console.WriteLine(number4); // output 40



            // Date Time

            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime); // Yukarıdaki formatta getirir.


            string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTime);

            // saat
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
             
        }
    }
}
