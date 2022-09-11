using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Collections

            
            ArrayList liste = new ArrayList();

            liste.Add(20);
            liste.Add(true);
            liste.Add('A');

            // İçerisindeki Verilere Erişim
            Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }


            // AddRange - Birden fazla Elemanı toplu halde ekleme
            Console.WriteLine("****** ADD RANGE ******");

            string[] renkler = {"kırmızı", "sarı", "yeşil"};

            List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};

            liste.AddRange(renkler);
            liste.AddRange(sayilar);


            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Sort
            Console.WriteLine("********** SORT ***********");
            liste.Sort();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }


            //Binary Search
            Console.WriteLine("********** Binary Search ***********");
            Console.WriteLine(liste.BinarySearch(9));



            // Reverse
            Console.WriteLine("******* Reverse *******");
            liste.Reverse();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }


            //Clear
            Console.WriteLine("******* Clear *******");
            liste.Clear();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

        }
    }
}
