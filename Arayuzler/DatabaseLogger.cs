using System;

namespace Arayuzler
{
    class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Database'e Yazar");
        }
    }
}