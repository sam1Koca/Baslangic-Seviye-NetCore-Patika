using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();

            ogrenci1.Isim = "Dennis ";
            ogrenci1.Soyisim = "Ritchie";
            ogrenci1.OgrenciNo = 101;
            ogrenci1.Sinif = 3;

            ogrenci1.SinifAtlat();

            ogrenci1.OgrenciBilgileriniGetir();


            Ogrenci ogrenci2 = new Ogrenci("Kevin","Mitnick",202,1);
            ogrenci2.SinifDusur();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim 
        { 
            get {return isim;}  // Aşağıdakilerle Aynı
            set {isim = value;} 
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        {   
            get => sinif; 
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir!");
                    sinif=1;
                }
                else
                {
                    sinif = value;
                } 
            }
        }

        public Ogrenci(){} // Boş yapıcı metot.

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("****** Öğrenci Bilgileri ******");

            Console.WriteLine("Öğrenci Adı          : {0}", this.Isim);
            Console.WriteLine("Öğrenci Soyisim      : {0}", this.Soyisim);
            Console.WriteLine("Öğrenci No           : {0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı       : {0}", this.Sinif);
        }


        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}
