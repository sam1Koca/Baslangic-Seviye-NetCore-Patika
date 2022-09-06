using System;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = candles.First();
            int count = 1;
        
            for(int i = 1; i< candles.Count; i++)
            {
            
                if(candles[i] > max)
                {
                    max = candles[i];
                    count = 1;
                }
            
                else if(candles[i] == max)
                {
                    count++; 
                }
            }
        
            return count;
        }
    }
}
