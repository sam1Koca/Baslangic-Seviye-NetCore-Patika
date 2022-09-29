using System;

namespace Arayuzler
{
    class SmsLogger : ILogger // Implement Interface - Arabirimi Uygula
    {
        public void WriteLog()
        {
           Console.WriteLine("Sms Olarak Yazar...");
        }
    }
}