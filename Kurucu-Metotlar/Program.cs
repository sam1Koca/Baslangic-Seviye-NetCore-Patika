using System;

namespace Kurucu_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
        /*    Sözdizimi

            class SinifAdi 
            {
                [Erişim Belirleyici] [Veri Tipi] OzellikAdi;

                [Erişim Belirleyici] [Geri Dönüş Tipi] MetoAdi([Paremetre Listesi])
                {
                     Metot Komutları
                }
                

                Erişim Belirleyiciler:
                    -> Public
                    -> Private
                    -> Internal
                    -> Protected
            */



            Calisan calisan1 = new Calisan("Mark", "Zuckerberg", 101 , "Backend Developer");

            calisan1.CalisanBilgileri();

            Console.WriteLine("\n*******************************************");


            Calisan calisan2 = new Calisan("Kevin", "Mitnick", 102, "Siber Güvenlik Mühendisi");

            calisan2.CalisanBilgileri();


            Console.WriteLine("\nÇalışan 3 *********************************\n");
            Calisan calisan3 = new Calisan("Sayit Sami", "Koca");
            calisan3.CalisanBilgileri();
        }
    }

    
    class Calisan
    {
        // Property ve İş Yapıcı Bir metot tutan Class

        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad,int no ,string departman)     // Yapıcı bir metot oluşturalım.
        {
            this.Ad =ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;

            // Bu sınıfın propertylerini set eden bir yapıcı metot.
            // Bununla beraber - Sinif Kavrami İlk bölüm dersinde yazdığımız kodları refactor ettik (iyileştirdik)
        }

        public Calisan(string ad, string soyad)     // Aşırı Yükleme Yapalım
        {
            this.Ad =ad;
            this.Soyad = soyad;
        }

        public Calisan(){}


        public void CalisanBilgileri(){
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan No: {0}", No);
            Console.WriteLine("Çalışan Departman: {0}", Departman);
        }
    }
}
