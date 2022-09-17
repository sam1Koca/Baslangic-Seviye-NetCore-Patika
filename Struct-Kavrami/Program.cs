using System;

namespace Struct_Kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            // Struct'larda değer tipler arasında yer alır.

            Dikdortgen dikdortgen = new Dikdortgen();

            dikdortgen.kisaKenar = 3;
            dikdortgen.uzunKenar = 4;

            Console.WriteLine("Class Alan Hesabı  :  {0}",dikdortgen.AlanHesapla());


            Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct();

            // Dikdortgen_Struct dikdortgen_Struct1;   -> new'lemeden de olur.
            
            dikdortgen_Struct.kisaKenar = 3;
            dikdortgen_Struct.uzunKenar = 4;

            Console.WriteLine("Struct Class Alan Hesabı  : {0}",dikdortgen_Struct.AlanHesapla());
        }
    }

    class Dikdortgen
    {
        public int kisaKenar;
        public int uzunKenar;

        public Dikdortgen()
        {
            kisaKenar = 3;
            uzunKenar = 4;
        }


        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }
    }

    struct Dikdortgen_Struct  // Uzmanlar der ki :) -> 16 byte'a kadar olan datalar için bu yapılrı kullanın, büyük olanlar için ise class yapıları daha uygun. 
    {
        public int kisaKenar;
        public int uzunKenar;

        // Burada constructor bu şekilde kullanılmakta.
        public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
        {
            this.kisaKenar = kisaKenar;
            this.uzunKenar = uzunKenar;
        }


        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }
    }
}
