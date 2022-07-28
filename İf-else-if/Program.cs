using System;

namespace İf_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour; // O an ki saati aldım.

            Console.WriteLine(time);


            if (time>=6 && time<11)
            {
                Console.WriteLine("Günaydın");
            }

            else if (time <= 18)
            {
                Console.WriteLine("İyi Günler");
            }

            else
            {
                Console.WriteLine("İyi Geceler");
            }


            string sonuc = time <=18 ? "İyi Günler" : "İyi Geceler"; 

            sonuc = time>=6 && time<11 ? "İyi Günler" : time <= 18 ? "İyi Günler" : "İyi Geceler";

            // Yukarıdaki Koşul sağlanırsa soru işaretinden sonra ilk ifade çalışır.
            // : ifadesi, değilse anlamına gelmekte. Bu ifade ile bir durumu belirtip sonlandırınca farklı bir koşul daha yazabilirim.


            Console.WriteLine(sonuc);
        }
    }
}
