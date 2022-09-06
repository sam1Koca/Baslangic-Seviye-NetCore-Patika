using System;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
        double pos = 0;
        double neg = 0;
        double zero = 0;

        foreach(int num in arr) {
            if(num > 0) {
                pos++;
            }
            else if(num < 0) {
                neg++;
            }
            else {
                zero++;
            }
        }

        Console.WriteLine(pos / arr.Length);
        Console.WriteLine(neg / arr.Length);
        Console.WriteLine(zero / arr.Length);
        }
    }
}
