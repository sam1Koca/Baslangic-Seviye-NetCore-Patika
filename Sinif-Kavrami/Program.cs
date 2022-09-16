using System;

namespace Sinif_Kavrami
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
                }

                Erişim Belirleyiciler:
                    -> Public
                    -> Private
                    -> Internal
                    -> Protected
            */



            Calisan calisan1 = new Calisan();

            calisan1.Ad = "Mark";
            calisan1.Soyad = "Zuckerberg";
            calisan1.No = 101;
            calisan1.Departman = "Backend Developer";

            calisan1.CalisanBilgileri();

            Console.WriteLine("\n*******************************************");


            Calisan calisan2 = new Calisan();

            calisan2.Ad = "Kevin";
            calisan2.Soyad = "Mitnick";
            calisan2.No = 102;
            calisan2.Departman = "Siber Güvenlik Analisti";

            calisan2.CalisanBilgileri();






        }
    }

    class Calisan
    {
        // Property ve İş Yapıcı Bir metot tutan Class

        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri(){
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan No: {0}", No);
            Console.WriteLine("Çalışan Departman: {0}", Departman);
        }
    }
}
