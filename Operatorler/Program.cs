using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Atama ve İşlemli Atama Operatörleri *****");
            // Atama ve İşlemli Atama

            int x = 3;
            int y = 3;

            // İşlemli Atama
            y = y + 2;

            Console.WriteLine(y);
            y += 2;

            Console.WriteLine(y);
            y /=1;

            Console.WriteLine(y);
            x *= 2;

            Console.WriteLine(x);


            Console.WriteLine("***** Mantıksal Operatörler *****");
            // Mantıksal Operatörler [ || , && , ! ]
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted){
                Console.WriteLine("Perfect.");
            }


            if (isSuccess || isCompleted){
                // isSucces ise veya isCompleted ise..
                Console.WriteLine("Great.");
            }

            if(isSuccess && !isCompleted){
                // isSuccess ise ve isCompleted değilse..
                Console.WriteLine("Perfect.");
            }


            Console.WriteLine("***** İlişkisel Operatörler *****");
            // İlişkisel Operatörler [ < , > , <= , >= , == , != ]

            int a = 3;
            int b = 4;

            bool sonuc = a<b;
            Console.WriteLine(sonuc);

            sonuc = a>b;
            Console.WriteLine(sonuc);

            sonuc = a>=b;
            Console.WriteLine(sonuc);

            sonuc = a<=b;
            Console.WriteLine(sonuc);

            sonuc = a==b;
            Console.WriteLine(sonuc);

             sonuc = a!=b;
            Console.WriteLine(sonuc);




            Console.WriteLine("***** Aritmetik Operatörler *****");

            // Aritmetik Operatörler [ / , * , + , - ]

            int number1 = 10;
            int number2 = 5;

            int sonuc1 = number1/number2;
            Console.WriteLine(sonuc1);

            sonuc1 = number1 * number2;
            Console.WriteLine(sonuc1);

            sonuc1 = number1 + number2;
            Console.WriteLine(sonuc1);

            sonuc1 = ++number1; 
            Console.WriteLine(sonuc1);

            sonuc1 = 20%3; // mod alma 
            Console.WriteLine(sonuc1);

        }
    }
}
