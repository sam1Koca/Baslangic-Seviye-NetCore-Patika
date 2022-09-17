using System;

namespace CSharp_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            // enum : Enumeration - (Sıralı)
            // Birden fazla sabite ihtiyaç varsa kullanılabilir kodun okunabilirliğini artırmak için.

            Console.WriteLine(Gunler.Pazar);
            // Pazarı bana string bir şekilde getirir.


            Console.WriteLine((int)Gunler.Cumartesi); // index numarasını getirir.



            int sicaklik = 21;

            if (sicaklik <= (int)HavaDurumu.Normal) // int değere cast etmem gerek normalde bana enum değer dönmekte. 
            {
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim...");
            }

            else if(sicaklik >= (int)HavaDurumu.Sıcak)
            {
                Console.WriteLine("Dışarıya Çıkmak İçin çok sıcak birgün...");
            }

            else if(sicaklik>=(int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.CokSıcak)
            {
                Console.WriteLine("Hava Gayet Uygun! Hadi Dışarıya Çıkalım...");
            }

        }
    }

    enum Gunler
    {
        Pazartesi, // index:0 ,  -> Pazartesi=1, şeklinde yaparsak indexi 1 yapar
        Salı,
        Çarşamba,
        Perşembe,
        Cuma = 23,
        Cumartesi,
        Pazar
    }


    enum HavaDurumu
    {
        Soguk = 5, // soguk benim için 5 demekir.

        Normal = 20,

        Sıcak = 25,

        CokSıcak = 30
    }
}
