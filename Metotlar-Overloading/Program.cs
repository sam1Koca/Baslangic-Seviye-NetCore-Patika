using System;

namespace Metotlar_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // out parametreler

            string sayi = "999";

            // bu değişkenin değerini int tipine parse ettiğini kontrol et, eğer parse ederse outSayi şeklinde çıkart.

            bool sonuc = int.TryParse(sayi, out int outSayi);

            if (sonuc)
            {
                Console.WriteLine("Parse İşlemi Başarılı");
                Console.WriteLine(outSayi);
            }

            else{
                Console.WriteLine("Başarısız!");
            }

            Metotlar metotlar = new Metotlar();

            metotlar.Topla(2,3, out int toplamSonuc);

            Console.WriteLine(toplamSonuc);



            // Metot Overloading - Metot Aşırı Yükleme

            int number1 = 999;
            metotlar.PrintToScreen(number1);
            metotlar.PrintToScreen("Sayit Sami", "Koca");
            
            // Metot İmzası
            // MetotAdı + paremetreSayisi + paremetre {Bunların hepsi aynı olursa kızar}

        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a+b;
        }

        public void PrintToScreen(string text)
        {
            Console.WriteLine(text);
        }

        public void PrintToScreen(int text) // Bu metotla overloading yaptım. Hem int, hemde string alabilir
        {
            Console.WriteLine(text);
        }

         public void PrintToScreen(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
