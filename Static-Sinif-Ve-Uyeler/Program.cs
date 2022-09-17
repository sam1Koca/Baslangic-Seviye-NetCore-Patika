using System;

namespace Static_Sinif_Ve_Uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi);

            Calisan calisan1 = new Calisan("Sayit Sami","KOCA","Full-Stack Developer");
            Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("Kevin","Mitnick","Cyber Security Researcher");
            Calisan calisan3 = new Calisan("Dennis","Ritchie","Back-end Developer");

            Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi);


            Console.WriteLine("Toplama İşlemi Sonucu: {0}", Islemler.Topla(100,200));

            Console.WriteLine("Toplama İşlemi Sonucu: {0}", Islemler.Cikar(400,50));

        }
    }


    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}

        private string isim;
        private string soyisim;
        private string departman;

        static Calisan(){
            // Çalışan sınıfı ilk created edildiğinde;

            calisanSayisi = 0;

            // Bu yapıcı metot ise bir kez çalışır, oda ilk çağırıldığında
        }

         public Calisan(string isim, string soyisim, string departman) // Bunları setlemek isterssen sadece buradan setleyebilirsin !!
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.departman = departman;

            calisanSayisi ++; // get ettiğimde arttırılmış olarak dönecek.

            // Ben her nesne oluşturduğumda gider public constructorı çalıştırır.. Yani burası
        }
    }

        static class Islemler
        {
            // Kalıtım İşlemi Uygulanamaz! - İnstance alma işlemi yapılmaz...

            public static long Topla(int sayi1, int sayi2)
            {
                return sayi1 + sayi2;
            }

            public static long Cikar(int sayi1, int sayi2)
            {
                return sayi1 - sayi2;
            }
        }
}
