using System;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
        
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = Result.timeConversion(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

    class Result
    {

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

        public static string timeConversion(string s)
        {
            bool succesfulConversion = DateTime.TryParse(s, out DateTime time);
        
            if(succesfulConversion)
            {
                return time.ToString("HH:mm:ss");
            }
        
            return "HackerRank gave me bad input";
        }

    }
}
