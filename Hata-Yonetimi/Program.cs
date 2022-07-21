using System;

namespace Hata_Yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try // Hataya neden olabilecek kodu buraya yazıyoruz
            {
                Console.WriteLine("Bir sayı Giriniz: ");
                int input = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Girmiş Olduğunuz Sayı: " + input);
            }

            catch (Exception ex) // Hata olduğunda
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }

            finally 
            {
                // Bir kod bloğu hata alsın almasın, çalıştırmak istediğimiz başka kod bloğu varsa buraya yaz.

                Console.WriteLine("İşlem Tamamlandı..!");

                // finaly bloğunu yazmak zorunlu değil, opsiyonel..
            }
            


            Console.WriteLine("**************** Hata Türleri-Tipleri ve Hakkında ************************");
            // ***********************************************************************************************

            try
            {
                int a = int.Parse(null); // null değerini, int'e cast etmek istiyorum..
            }
            catch (ArgumentNullException ex)
            {
                // Burdan fırlatılan hata ArgumentNullExcep. hatası ise:

                Console.WriteLine("Boş Değer Girdiniz..");
                Console.WriteLine(ex);
            }


            // ************** Farklı Bir Hata Örneği ********************************************
            Console.WriteLine("************** Farklı Bir Hata Örneği ****************");

            try
            {
                int value = int.Parse("test"); // int değere parse edilemeyen bir değer verelim
            }
            catch (FormatException ex )
            {
                Console.WriteLine("Veri Tipi Uygun Değil..!");
                Console.WriteLine(ex);
            }



            // ************** Farklı Bir Hata Örneği ********************************************
            Console.WriteLine("************** Farklı Bir Hata Örneği ****************");

            try
            {
                int value = int.Parse("-20000000000");

                // overflow hatası: vari tipinin max-min. aralığında farklı olması. Ya çok küçük, yada çok büyük.. 
            }
            catch (OverflowException ex )
            {
                Console.WriteLine("Çok Küçük yada Çok büyük bir değer girdiniz..!");
                Console.WriteLine(ex);
            }

            finally{
                Console.WriteLine("İşlem Başarıyla Tamamlandı..");
            }

        }
    }
}
