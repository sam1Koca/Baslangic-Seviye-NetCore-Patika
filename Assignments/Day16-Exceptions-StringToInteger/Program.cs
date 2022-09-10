using System;

namespace Day16_Exceptions_StringToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
        
        try
        {
            var i = int.Parse(S);
            Console.Write(i);
        }
        catch
        {
            Console.Write("Bad String");
        }
        }
    }
}
