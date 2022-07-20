using System;

namespace Tip_Donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion (Bilinçsiz Dönüşüm) -  Düşük Kapasiteli bir değişkenin, kendinden yüksek kapasiteli değişkene dönüşmesi-aktarılması.
            Console.WriteLine(" ******** Implicit Conversion ******* ");

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c; // Diğerlerinden Kapasitesi Daha Fazla - int

            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);


            string e = "koca";
            char f = 'k';
            object g = e+f+d;
            Console.WriteLine("g: " + g);


            Console.WriteLine(" ******** Explicit Conversion ******* ");
            // Explicit Conversion (Bilinçli Dönüşüm) - c#'ın kendi kendine yapamadığı dönüşümler. Bunu kendimiz compiler'a söylememiz gerekli... {convertTo,To, Parse}

            int x = 4;
            byte y = (byte)x; // sağındaki değişkeni, parentez içindeki tipe convert edecek.
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);

            // Convert İşlemlerinde data kayıbı olabilir. Bunları Göz önünde bulunduralım !!!



            // ***** ToString Methodu ******
            Console.WriteLine(" ******** ToString Conversion ******* ");
            int a_1 = 200;
            string b_1 = a_1.ToString();
            Console.WriteLine("b_1: " + b_1);

            string c_1 = 12.5f.ToString();
            Console.WriteLine("c_1: " + c_1); 


            // System.Convert
            System.Console.WriteLine("********* System.Convert Sınıfı ************");

            string s1="10" , s2="20";

            int sayi1,sayi2,toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;

            System.Console.WriteLine("Toplam: "+ toplam);


            // Parse
            System.Console.WriteLine("********* Parse Method************");

            ParseMethod();
            
        }

        static void ParseMethod(){

            // Parse sadece string data-type alır
            string text1 = "10";
            string text2 = "10.25";
            int rakam1;
            double rakam2;

            rakam1 = Int32.Parse(text1);
            rakam2 = Double.Parse(text2);

            System.Console.WriteLine("Rakam1: " + rakam1);
            System.Console.WriteLine("Rakam2: " + rakam2);

        }
    }
}
