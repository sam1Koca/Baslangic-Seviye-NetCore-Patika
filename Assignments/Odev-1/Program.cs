using System;

namespace Odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Odevler odevler = new Odevler();

            odevler.Task1();

            odevler.Task2();
            
            odevler.Task3();
            
            odevler.Task4();
        }
    }

    class Odevler
    {
        // 1- Kullanıcıdan n adet Pozitif Sayı Girmesini İsteyin(n) Girilen Sayıların pozitif olanlarını Console'a yazdırın
        public void Task1()
        {
            Console.WriteLine("Kaç tane pozitif sayı girmek istiyorsunuz: ");
            int sayac = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[sayac];


            for (int i = 0; i < sayac; i++)
            {
                Console.WriteLine("{0}. Sayıyı Giriniz: ", i+1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Girilen Pozitif Sayılar: ");
            foreach (var number in sayilar)
            {
                Console.Write("{0},", number);   
            }

            Console.WriteLine("\nGirilen Pozitif Çift Sayılar: ");
            foreach (var item in sayilar)
            {
                if (item%2==0)
                {
                    Console.Write("{0}, ", item);
                }
            }

            
        }



        // 2- Kullanıcıdan pozitif iki sayı girmesini isteyin(n,m). Sonrasında Kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'ye eşit yada tam bölünenleri ekrana yazdırın.
        public void Task2()
        {
            Console.WriteLine("Kaç adet sayı Girmek istiyorsunuz: "); // Kullanıcıdan n tane sayı girmesini isteyin.. (Ben kaç sayı girmek istediğini sordum)
            int sayiDizisi = int.Parse(Console.ReadLine()); // n

             Console.WriteLine("Karşılaştırmak İstediğiniz Sayıyı Giriniz: "); // Bu sayıya eşit yada tam bölünenler console'a yazılacak.
            int number = int.Parse(Console.ReadLine()); // m

            int[] sayilar = new int[sayiDizisi];

            for (int i = 0; i < sayiDizisi; i++) 
            {
                Console.WriteLine("{0}. Sayıyı Giriniz: ", i+1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }


            Console.Write("\nGirdiğiniz Sayıya Tam bölünen yada Eşit Olan değerler: ");
            foreach (var item in sayilar)
            {
                if (item==number || item%number==0) // m'ye eşit yada tam bölünenleri console'a yazdırın.
                {
                    Console.Write(item + ",");
                }
            }



            
        }



        // 3- Kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet kelime girmesini isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru sıralayarak console'a yazdırın
        public void Task3()
        {
            Console.WriteLine("Girmek İstediğiniz Kelime Kadar Pozitif Bir Sayı Giriniz: ");
            int kelimeSayisi = int.Parse(Console.ReadLine()); // n tane pozitif sayı

            string[] kelimeDizisi = new string[kelimeSayisi];

            for (int i = 0; i < kelimeSayisi; i++)
            {
                Console.WriteLine("{0}. Kelimeyi Giriniz: ", i+1);
                kelimeDizisi[i] = Console.ReadLine();
            }

            Console.WriteLine("\nDizinin İlk Hali:");
            
            foreach (var item in kelimeDizisi)
            {
                Console.Write(item + ",");
            }


            Console.WriteLine("\n\nDizinin Son Hali: ");
            Array.Reverse(kelimeDizisi);

            foreach (var item in kelimeDizisi)
            {
                Console.Write(item+", ");
            }


            


        } 
    


        // 4- Console'a Kullanıcının Bir cümle yazmasını isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın
        public void Task4()
        {
            string[] girilenCumle = new string[1];

            Console.WriteLine("Bir cümle Giriniz: ");
            girilenCumle[0] = Console.ReadLine();

            var toplamHarf = girilenCumle[0].Length; // Toplam Harf Sayısını Bulmak İçin...
            Console.WriteLine(toplamHarf);

            var toplamKelime = girilenCumle[0].Split(" "); // Kelimeleri Bulmak İçin..
            Console.WriteLine(toplamKelime.Length);

        }
    }
}
