using System;
using System.Collections.Generic;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            //System.Collections.Generic
            // T -> Object türündedir.


            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);


            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");


            //Count - İstediğim listenin kaç elemanı olduğunu verir.
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);




            //Foreach ve List.ForEach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));


            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));


            //Listeden index ile eleman çıkarma

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));


            //Liste içerisinde Arama
            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("10 Liste İçerisinde Bulundu");
            }


            //Eleman ie index'e erişme
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));



            // Diziyi List'e Çevirme
            string[] hayvanlar = {"Kedi","Köpek","Kuş"};

            List<string> hayvanListesi = new List<string>(hayvanlar);


            //Listeyi Nasıl Temizleriz
            hayvanListesi.Clear();



            //List İçerisinde Nesne Tutmak
            List<Kullanıcılar> kullaniciListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanici1 = new Kullanıcılar();
            kullanici1.Isim = "Sayit Sami";
            kullanici1.Soyisim = "KOCA";
            kullanici1.Yas = 19;

            Kullanıcılar kullanici2 = new Kullanıcılar();
            kullanici1.Isim = "Kevin";
            kullanici1.Soyisim = "Mitnick";
            kullanici1.Yas = 67;


            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);



            List<Kullanıcılar> yeniKullanicilar = new List<Kullanıcılar>();
            yeniKullanicilar.Add(new Kullanıcılar{
                Isim = "Cahit",
                Soyisim= "Koca",
                Yas=11
            });

            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı: " + kullanici.Isim);
                Console.WriteLine("Kullanıcı Soyadı: " + kullanici.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı: " + kullanici.Yas);
            }


            yeniKullanicilar.Clear(); // Enson listeyi temizledim.



        }
    }

    public class Kullanıcılar
    {
        string isim;
        string soyisim;
        int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }

}
