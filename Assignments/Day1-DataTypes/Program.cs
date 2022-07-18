using System;
using System.Collections.Generic;
using System.IO;

namespace Day1_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declaration of second Integer, Double, and String variables.
        int i_2;
        double d_2;
        string s_2;
        
        i_2 = Convert.ToInt32(Console.ReadLine());
        d_2 = Convert.ToDouble(Console.ReadLine());
        s_2 = Console.ReadLine();
        
        // Print the sum of both integer variables on a new line.

        Console.WriteLine(i_2 + i);
        Console.WriteLine("{0:F1}", d + d_2);
        Console.WriteLine(s + s_2);        

        // Print the sum of the double variables on a new line.
        
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.

        }
    }
}
