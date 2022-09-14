using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                -> Klavyeden Girilen Cümle içerisindeki sesli harfleri bir dizi içeriinde saklayan ve dizinin elemanlarını sıralayn programı yazınız.
            */

            Console.WriteLine("Bir Cümle Giriniz: ");
            string girilenCumle = Console.ReadLine();

            string sesliHarfler = "aeıioöuü";

            ArrayList sesliDizi = new ArrayList();

            if (!string.IsNullOrEmpty(girilenCumle))
            {
                string cumle = girilenCumle.ToLower();
                for (int i = 0; i < girilenCumle.Length; i++)
                {
                    if (sesliHarfler.Contains(cumle[i]))
                    {
                        sesliDizi.Add(cumle[i]);
                    }
                }
            }

            sesliDizi.Sort();

            Console.Write("Girilen Cümledeki Sesli Harfler: ");
            foreach (var harf in sesliDizi)
            {
                Console.Write(harf + ",");
            }

        }
    }
}
