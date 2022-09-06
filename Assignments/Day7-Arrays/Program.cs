using System;

namespace Day7_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        
            for (var i = n - 1; i > -1; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
