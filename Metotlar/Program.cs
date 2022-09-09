using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            Syntax:
            erisimBelirteci geriDonusTipi metotAdi(paremetreListesi arguman)
            {
                // komutlar
                // return - geri donus varsa..
            }

            */


            int sayi1 = 2;
            int sayi2 = 3;

            int sonuc = Topla(sayi1, sayi2);

            // Console.WriteLine(sonuc);

            Metotlar metotlar = new Metotlar();
            metotlar.PrintToScreen(Convert.ToString(sonuc));

            int sonuc2 = metotlar.ArttirVeTopla(ref sayi1, ref sayi2); 
            metotlar.PrintToScreen(Convert.ToString(sonuc2));

            // ref keywordünü kullanmak, benim sana verdiğim şey bellekte ki değerlerini vermek yerine, ref ile adreslerini vermek




        }

        static int Topla(int value1, int value2)
        {
            return value1 + value2;
        }
    }

    class Metotlar
    {
        public void PrintToScreen(string text)
        {
            Console.WriteLine(text);
        }

        public int ArttirVeTopla(ref int val1, ref int val2)
        {
            val1+=1;
            val2+=2;
            
            return val1 + val2;
        }
    }
}
