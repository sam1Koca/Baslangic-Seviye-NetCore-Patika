using System;

namespace Hazir_Metotlar_DateTime_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); // Günün tarihini getirir.
            Console.WriteLine(DateTime.Now.Date); // Bulunduğum zamanın tam taihini getir
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek); // Bulunduğumuz günün string olarak getirir.
            Console.WriteLine(DateTime.Now.DayOfYear); // Bulunduğumuz yılın kaçıncı günündeyiz.

            Console.WriteLine(DateTime.Now.ToLongDateString()); // Gün ve Ay string/sayıile - yılı da sayı ile getirir.
            Console.WriteLine(DateTime.Now.ToShortDateString()); // Tarih formatında getirir. Hesaplamalarda vs. bunu kullanırız.
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2)); // 2 gün ekle
            Console.WriteLine(DateTime.Now.AddHours(3)); // 3 saat ekle
            Console.WriteLine(DateTime.Now.AddSeconds(30)); // 30 sn. ekle
            Console.WriteLine(DateTime.Now.AddMonths(5)); // 5 ay ekle
            Console.WriteLine(DateTime.Now.AddYears(10)); // 10 yıl ekle
            Console.WriteLine(DateTime.Now.AddMilliseconds(50)); // 50 milisaniye ekle.


            // DateTime Format

            Console.WriteLine(DateTime.Now.ToString("dd")); // Günü string olarak değil sayı olarak getir.(11)
            Console.WriteLine(DateTime.Now.ToString("ddd")); // 3 harfli şekilde Günü string getirir.(paz)
            Console.WriteLine(DateTime.Now.ToString("dddd")); // tam harfli şekilde getir. (pazar)

            Console.WriteLine(DateTime.Now.ToString("MM")); // Ayın sayısı(09)
            Console.WriteLine(DateTime.Now.ToString("MMM")); // Eyl
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //Eylül

            Console.WriteLine(DateTime.Now.ToString("yy")); // tarihi iki hanei şekilde getirir(22)
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //tarihi tam olarak getirir(2022)


            Console.WriteLine("********************* MATH KÜTÜPHANESİ ******************************");
            // Math Kütüphanesi

            Console.WriteLine(Math.Abs(-30)); // Mutlak Değeri Alır => 30
            Console.WriteLine(Math.Sin(10)); // Sin karşılığını verir - hesaplar.
            Console.WriteLine(Math.Cos(10)); // Cos hesaplaması yapar.
            Console.WriteLine(Math.Tan(10)); // Tan hesaplaması yapar.

            Console.WriteLine(Math.Ceiling(22.3)); // 22.3'den büyük en küçük tam sayıyı getirir. => 23 !!Herzaman yukarıya yuvarlar
            Console.WriteLine(Math.Round(22.3)); //22.3 hangisinde daha yakınsa onu getirir => 22 
            Console.WriteLine(Math.Round(22.7)); // => 23
            Console.WriteLine(Math.Floor(22.7)); // 22.7'den küçük, en büyük tam sayıyı getirir. !Herzamana aşağı yuvarlar

            Console.WriteLine(Math.Max(2,6)); // 6 getirir.
            Console.WriteLine(Math.Min(2,6)); // 2 getirir.

            Console.WriteLine(Math.Pow(3,4)); // 3^4'ü verir (3 üzeri 4)
            Console.WriteLine(Math.Sqrt(9)); // Karekök Alır.
            Console.WriteLine(Math.Log(9)); // Logoritma işlemi yapar. {9'un e tabanındaki logoritmik karşılığı}
            Console.WriteLine(Math.Exp(3)); // e üzeri 3'ü verir
            Console.WriteLine(Math.Log10(10)); // 10 sayısının logoritma 10 tabanındaki karşılığını verir.
        }
    }
}
