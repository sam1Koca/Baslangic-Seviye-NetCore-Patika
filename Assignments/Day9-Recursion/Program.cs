using System;
using System.Collections.Generic;
using System.IO;

namespace Day9_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */      
            int n = Int32.Parse(Console.ReadLine());
            int res = factorial(n);
            Console.WriteLine(res);
        }

         public static int factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return (n * factorial(n - 1));
            }
        }
    }
}
