using System;
using System.Collections;
using System.Collections.Generic;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Collections

            ArrayList array_List = new ArrayList();

            array_List.Add(20);
            array_List.Add(true);
            array_List.Add('A');

            // İçerisindeki Verilere Erişim
            Console.WriteLine(array_List[1]);

            foreach (var item in array_List)
            {
                Console.WriteLine(item);
            }


            // AddRange - Birden fazla Elemanı toplu halde ekleme
            Console.WriteLine("****** ADD RANGE ******");

            string[] renkler = {"kırmızı", "sarı", "yeşil"};

            List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};

            array_List.AddRange(renkler);
            array_List.AddRange(sayilar);


            foreach (var item in array_List)
            {
                Console.WriteLine(item);
            }

            //Sort
            Console.WriteLine("********** SORT ***********");
            array_List.Sort();

            foreach (var item in array_List)
            {
                Console.WriteLine(item);
            }


            //Binary Search
            Console.WriteLine("********** Binary Search ***********");
            Console.WriteLine(array_List.BinarySearch(9));



            // Reverse
            Console.WriteLine("******* Reverse *******");
            array_List.Reverse();

            foreach (var item in array_List)
            {
                Console.WriteLine(item);
            }


            //Clear
            Console.WriteLine("******* Clear *******");
            array_List.Clear();

            foreach (var item in array_List)
            {
                Console.WriteLine(item);
            }
        }
    }
}
